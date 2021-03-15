using BUS_QLTV;
using DTO_QLTV;
using System;
using System.Windows.Forms;

namespace QLTV.Popup_Reader
{
    public partial class Edit_Reader : Form
    {
        int authorId;
        public Edit_Reader(DTO_DocGia authorInfo)
        {
            InitializeComponent();
            this.authorId = authorInfo.MaDG;
            txtReaderName.Text = authorInfo.TenDG;
            txtNK.Text = authorInfo.NienKhoa.ToString();
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

            string confirmMessage = "Bạn có chắc muốn thay đổi thông tin độc giả?";
            string titleMessage = "Cập nhật thông tin tác giả";     
            DialogResult confirmDialog = MessageBox.Show(confirmMessage, titleMessage, MessageBoxButtons.YesNo);

            bool isUpdate = this.UpdateReader();

            if (confirmDialog == DialogResult.Yes && isUpdate == false)
            {             
                MessageBox.Show("Cập nhật độc giả thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật độc giả thành công");
                this.Close();
            } 
        }

        private bool UpdateReader()
        {
            try
            {
                BUS_DocGia updateAuthor = new BUS_DocGia();

                int gioitinh = 1;
                if(radGTMale.Checked == false)
                {
                    gioitinh = 0;
                }
            
                DTO_DocGia dtoReader = new DTO_DocGia(this.authorId, txtReaderName.Text, int.Parse(txtNK.Text), gioitinh);
                updateAuthor.updateDocGia(dtoReader);
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
            if(txtReaderName.Text == "" || txtReaderName.Equals(""))
            {
                errorMessage = "Xin nhập tên tác giả";
                return false;
            }
            if(txtNK.ToString() == "")
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
