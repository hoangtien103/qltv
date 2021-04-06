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
    public partial class Insert_Author : Form
    {
        public Insert_Author()
        {
            InitializeComponent();
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

            string confirmMessage = "Bạn có chắc muốn thêm mới thông tin tác giả?";
            string titleMessage = "Thêm mới thông tin tác giả";
            DialogResult confirmDialog = MessageBox.Show(confirmMessage, titleMessage, MessageBoxButtons.YesNo);

            bool isInsert = this.InsertAuthor();

            if (confirmDialog == DialogResult.Yes && isInsert == false)
            {
                MessageBox.Show("Thêm tác giả thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Thêm tác giả thành công");
                this.Close();
            }
        }

        private bool InsertAuthor()
        {
            try
            {
                BUS_TacGia insertAuthor = new BUS_TacGia();

                int gioitinh = 1;
                if (radGTMale.Checked == false)
                {
                    gioitinh = 0;
                }

                DTO_Tacgia dtoAuthor = new DTO_Tacgia(0, txtAuthorName.Text, dtpNgaySinh.Value.ToString("MM/dd/yyyy"), gioitinh);
                insertAuthor.insertTacGia(dtoAuthor);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private bool validate(out string errorMessage)
        {
            errorMessage = "";
            if (txtAuthorName.Text.Trim() == "" || txtAuthorName.Equals(""))
            {
                errorMessage = "Xin nhập tên tác giả";
                return false;
            }
            if (dtpNgaySinh.Value>DateTime.Now)
            {
                errorMessage = "Ngày sinh không hợp lệ";
                return false;
            }
            if (dtpNgaySinh.Value.ToString() == "")
            {
                errorMessage = "Xin nhập ngày sinh tác giả";
                return false;
            }
            if (radGTFemale.Checked == false && radGTMale.Checked == false)
            {
                errorMessage = "Xin chọn giới tính tác giả";
                return false;
            }
            return true;
        }
    }
}
