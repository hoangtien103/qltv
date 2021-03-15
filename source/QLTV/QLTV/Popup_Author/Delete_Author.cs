using BUS_QLTV;
using DTO_QLTV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Popup_Author
{
    public partial class Delete_Author : Form
    {
        int authorId;
        public Delete_Author(DTO_Tacgia authorInfo)
        {
            InitializeComponent();
            this.authorId = authorInfo.MaTG;
            txtAuthorName.Text = authorInfo.TenTG;
            dtpNgaySinh.Text = authorInfo.NgaySinh;
            if (authorInfo.GioiTinh == 0)
            {
                radGTFemale.Checked = true;
            }
            else
            {
                radGTMale.Checked = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string confirmMessage = "Bạn có chắc muốn xóa thông tin tác giả?";
            string titleMessage = "Xóa thông tin tác giả";
            DialogResult confirmDialog = MessageBox.Show(confirmMessage, titleMessage, MessageBoxButtons.YesNo);

            bool isUpdate = this.DeleteAuthor();

            if (confirmDialog == DialogResult.Yes && isUpdate == false)
            {
                MessageBox.Show("Xóa tác giả thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Xóa tác giả thành công");
                this.Close();
            }
        }

        private bool DeleteAuthor()
        {
            try
            {
                BUS_TacGia deleteAuthor = new BUS_TacGia();

                deleteAuthor.deleteTacGia(this.authorId);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
