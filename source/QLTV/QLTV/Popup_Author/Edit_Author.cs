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
    public partial class Edit_Author : Form
    {
        int authorId;
        public Edit_Author(DTO_Tacgia authorInfo)
        {
            InitializeComponent();
            this.authorId = authorInfo.MaTG;
            txtAuthorName.Text = authorInfo.TenTG;
            dtpNgaySinh.Text = authorInfo.NgaySinh;
            if(authorInfo.GioiTinh == 0)
            {
                radGTFemale.Checked = true;
            }
            else
            {
                radGTMale.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string err = string.Empty;
            bool isValid = this.validate(out err);
            if (isValid == false)
            {
                MessageBox.Show(err);
                return;
            }

            string confirmMessage = "Bạn có chắc muốn thay đổi thông tin tác giả?";
            string titleMessage = "Cập nhật thông tin tác giả";     
            DialogResult confirmDialog = MessageBox.Show(confirmMessage, titleMessage, MessageBoxButtons.YesNo);

            bool isUpdate = this.UpdateAuthor();

            if (confirmDialog == DialogResult.Yes && isUpdate == false)
            {             
                MessageBox.Show("Cập nhật tác giả thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật tác giả thành công");
                this.Close();
            } 
        }

        private bool UpdateAuthor()
        {
            try
            {
                BUS_TacGia updateAuthor = new BUS_TacGia();

                int gioitinh = 1;
                if(radGTMale.Checked == false)
                {
                    gioitinh = 0;
                }
            
                DTO_Tacgia dtoAuthor = new DTO_Tacgia(this.authorId, txtAuthorName.Text, dtpNgaySinh.Value.ToString(), gioitinh);
                updateAuthor.updateTacGia(dtoAuthor);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        private bool validate(out string errorMessage)
        {
            errorMessage = "";
            if(txtAuthorName.Text == "" || txtAuthorName.Equals(""))
            {
                errorMessage = "Xin nhập tên tác giả";
                return false;
            }
            if(dtpNgaySinh.Value.ToString() == "")
            {
                errorMessage = "Xin nhập ngày sinh tác giả";
                return false;
            }
            if(radGTFemale.Checked == false && radGTMale.Checked == false)
            {
                errorMessage = "Xin chọn giới tính tác giả";
                return false;
            }
            return true;
        }
    }
}
