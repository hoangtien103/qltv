using BUS_QLTV;
using DTO_QLTV;
using System;
using System.Windows.Forms;

namespace QLTV.Popup_Reader
{
    public partial class Delete_Reader : Form
    {
        int authorId;
        public Delete_Reader(DTO_DocGia ReaderInfo)
        {
            InitializeComponent();
            this.authorId = ReaderInfo.MaDG;
            txtReaderName.Text = ReaderInfo.TenDG;
            txtNK.Text = ReaderInfo.NienKhoa.ToString();
            if (ReaderInfo.GioiTinh == 0)
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
            string confirmMessage = "Bạn có chắc muốn xóa thông tin độc giả?";
            string titleMessage = "Xóa thông tin độc giả";
            DialogResult confirmDialog = MessageBox.Show(confirmMessage, titleMessage, MessageBoxButtons.YesNo);

            bool isUpdate = this.deleteDocGia();

            if (confirmDialog == DialogResult.Yes && isUpdate == false)
            {
                MessageBox.Show("Xóa độc giả thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Xóa độc giả thành công");
                this.Close();
            }
        }

        private bool deleteDocGia()
        {
            try
            {
                BUS_DocGia deleteAuthor = new BUS_DocGia();

                deleteAuthor.deleteDocGia(this.authorId);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
