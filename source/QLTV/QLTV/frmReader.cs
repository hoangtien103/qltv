using BUS_QLTV;
using DTO_QLTV;
using QLTV.Popup_Reader;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTV
{
    public partial class ReaderGUI : Form
    {

        BUS_DocGia busDocGia = new BUS_DocGia();
        DTO_DocGia dtoDocGia = new DTO_DocGia();

        public ReaderGUI()
        {
            InitializeComponent();
            ShowAuthorList();
            this.dgvReader.Rows[0].Selected = true;
            load_details();
        }

        #region Show Author List
        void ShowAuthorList()
        {
            this.dgvReader.Rows.Clear();
            DataTable dtTable = busDocGia.getDocGia();
            foreach (DataRow item in dtTable.Rows)
            {
                int rowIndex = dgvReader.Rows.Add();
                dgvReader.Rows[rowIndex].Cells[4].Value = item.ItemArray[0].ToString();
                dgvReader.Rows[rowIndex].Cells[0].Value = item.ItemArray[1].ToString();
                dgvReader.Rows[rowIndex].Cells[1].Value = item.ItemArray[2].ToString();
                dgvReader.Rows[rowIndex].Cells[3].Value = item.ItemArray[3].ToString();
                dgvReader.Rows[rowIndex].Cells[2].Value = item.ItemArray[3].ToString() == "True" ? "Nam" : "Nữ";
            }

        }
        #endregion

        #region Button

        // Open Insert Author
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_Reader insert_Reader = new Insert_Reader();

            insert_Reader.ShowDialog();
            this.ShowAuthorList();
        }

        //  Open Delete Author dialog
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvReader.SelectedRows.Count > 0 &&
                this.dgvReader.SelectedRows[0].Index ==
                this.dgvReader.Rows.Count - 1)
            {
                MessageBox.Show("Xin chọn thông tin độc giả cần xóa!");
                return;
            }
            int gioitinh = 0;

            if (radGTMale.Checked == true)
            {
                gioitinh = 1;
            }

            int colIndex = this.dgvReader.SelectedRows[0].Index;
            int authorId = int.Parse(this.dgvReader.Rows[colIndex].Cells[4].Value.ToString());

            var authorInfo = new DTO_DocGia(authorId, txtReaderName.Text, int.Parse(txtNK.Text), gioitinh);

            Delete_Reader deleteAuthor = new Delete_Reader(authorInfo);

            deleteAuthor.ShowDialog();
            this.ShowAuthorList();
        }

        // Open Update Author dialog
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvReader.SelectedRows.Count > 0 &&
                this.dgvReader.SelectedRows[0].Index ==
                this.dgvReader.Rows.Count - 1)
            {
                MessageBox.Show("Xin chọn thông tin độc giả cần chỉnh sửa!");
                return;
            }
            int gioitinh = 0;

            if (radGTMale.Checked == true)
            {
                gioitinh = 1;
            }

            int colIndex = this.dgvReader.SelectedRows[0].Index;
            int authorId = int.Parse(this.dgvReader.Rows[colIndex].Cells[4].Value.ToString());

            var authorInfo = new DTO_DocGia(authorId, txtReaderName.Text, int.Parse(txtNK.Text), gioitinh);

            Edit_Reader editAuthor = new Edit_Reader(authorInfo);

            editAuthor.ShowDialog();
            this.ShowAuthorList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string mess = "Bạn có chắc muốn thoát?";
            string title = "Thoát ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mess, caption: title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        #region Details of Author
        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.load_details();
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.load_details();
        }

        private void dgvAuthor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.load_details();
        }

        private void load_details()
        {
            if (this.dgvReader.SelectedRows.Count > 0 &&
                this.dgvReader.SelectedRows[0].Index ==
                this.dgvReader.Rows.Count - 1)
            {
                this.txtReaderName.ResetText();
                this.txtNK.ResetText();
                this.radGTFemale.Checked = true;
                this.radGTMale.Checked = false;
            }

            if (this.dgvReader.SelectedRows.Count > 0 && this.dgvReader.SelectedRows[0].Index == 0)
            {
                int rowindex = this.dgvReader.SelectedCells[0].RowIndex;
                if (null == this.dgvReader.Rows[rowindex].Cells[0].Value)
                {
                    this.txtReaderName.Text = "";
                }
                else
                {
                    this.txtReaderName.Text = this.dgvReader.Rows[rowindex].Cells[0].Value.ToString();
                }

                if (null == this.dgvReader.Rows[rowindex].Cells[1].Value)
                {
                    this.txtNK.Text = "";
                }
                else
                {
                    this.txtNK.Text = this.dgvReader.Rows[rowindex].Cells[1].Value.ToString();
                }

                this.radGTFemale.Checked = true;

                if (null != this.dgvReader.Rows[rowindex].Cells[3].Value && "True" == this.dgvReader.Rows[rowindex].Cells[3].Value.ToString())
                {
                    this.radGTMale.Checked = true;
                }
            }
            if (this.dgvReader.SelectedRows.Count > 0 &&
                this.dgvReader.SelectedRows[0].Index !=
                this.dgvReader.Rows.Count - 1)
            {
                int rowindex = this.dgvReader.SelectedCells[0].RowIndex;
                this.txtReaderName.Text = this.dgvReader.Rows[rowindex].Cells[0].Value.ToString();
                this.txtNK.Text = this.dgvReader.Rows[rowindex].Cells[1].Value.ToString();
                this.radGTFemale.Checked = true;

                if (this.dgvReader.Rows[rowindex].Cells[3].Value.ToString() == "True")
                {
                    this.radGTMale.Checked = true;
                }
            }
        }
        #endregion
    }
}
