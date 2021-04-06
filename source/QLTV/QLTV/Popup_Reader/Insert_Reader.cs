using BUS_QLTV;
using DTO_QLTV;
using System;
using System.Windows.Forms;

namespace QLTV.Popup_Reader
{
    public partial class Insert_Reader : Form
    {
        public Insert_Reader()
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

            string confirmMessage = "Bạn có chắc muốn thêm mới thông tin độc giả?";
            string titleMessage = "Thêm mới thông tin độc giả";
            DialogResult confirmDialog = MessageBox.Show(confirmMessage, titleMessage, MessageBoxButtons.YesNo);

            bool isInsert = this.InsertReader();

            if (confirmDialog == DialogResult.Yes && isInsert == false)
            {
                MessageBox.Show("Thêm độc giả thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Thêm độc giả thành công");
                this.Close();
            }
        }

        private bool InsertReader()
        {
            try
            {
                BUS_DocGia insertReader = new BUS_DocGia();

                int gioitinh = 1;
                if (radGTMale.Checked == false)
                {
                    gioitinh = 0;
                }

                DTO_DocGia dtoReader = new DTO_DocGia(0, txtReaderName.Text,int.Parse(txtNK.Text), gioitinh);
                insertReader.insertdocgia(dtoReader);
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
            if (txtReaderName.Text.Trim() == "" || txtReaderName.Equals(""))
            {
                errorMessage = "Xin nhập tên độc giả";
                return false;
            }
            if (txtNK.Text.Trim() == "" || txtNK.Equals(""))
            {
                errorMessage = "Xin nhập niên khóa";
                return false;
            }
            int n;
            if (!int.TryParse(txtNK.Text.Trim(), out n))
            {
                errorMessage = "Niên khóa không hợp lệ";
                return false;
            }
            if (radGTFemale.Checked == false && radGTMale.Checked == false)
            {
                errorMessage = "Xin chọn giới tính độc giả";
                return false;
            }
            return true;
        }
    }
}
