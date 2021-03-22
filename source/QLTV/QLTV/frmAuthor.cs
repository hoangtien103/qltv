using BUS_QLTV;
using DTO_QLTV;
using QLTV.Popup_Author;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTV
{
    public partial class AuthorGUI : Form
    {

        BUS_TacGia busTacgia = new BUS_TacGia();
        DTO_Tacgia dtoTacgia = new DTO_Tacgia();

        public AuthorGUI()
        {
            InitializeComponent();
            ShowAuthorList();
            this.dgvAuthor.Rows[0].Selected = true;
            load_details();
        }

        #region Show Author List
        void ShowAuthorList()
        {
            this.dgvAuthor.Rows.Clear();
            DataTable dtTable = busTacgia.getTacGia();

            foreach (DataRow item in dtTable.Rows)
            {
                int rowIndex = dgvAuthor.Rows.Add();
                dgvAuthor.Rows[rowIndex].Cells[4].Value = item.ItemArray[0].ToString();
                dgvAuthor.Rows[rowIndex].Cells[0].Value = item.ItemArray[1].ToString();
                dgvAuthor.Rows[rowIndex].Cells[1].Value = Convert.ToDateTime(item.ItemArray[2].ToString());
                dgvAuthor.Columns["Birthday"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvAuthor.Rows[rowIndex].Cells[3].Value = item.ItemArray[3].ToString();
                dgvAuthor.Rows[rowIndex].Cells[2].Value = item.ItemArray[3].ToString() == "True" ? "Nam" : "Nữ";
            }

        }
        #endregion

        #region Button

        // Open Insert Author
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert_Author deleteAuthor = new Insert_Author();

            deleteAuthor.ShowDialog();
            this.ShowAuthorList();
        }

        //  Open Delete Author dialog
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvAuthor.SelectedRows.Count > 0 &&
                this.dgvAuthor.SelectedRows[0].Index ==
                this.dgvAuthor.Rows.Count - 1)
            {
                MessageBox.Show("Xin chọn thông tin tác giả cần xóa!");
                return;
            }
            int gioitinh = 0;

            if (radGTMale.Checked == true)
            {
                gioitinh = 1;
            }

            int colIndex = this.dgvAuthor.SelectedRows[0].Index;
            int authorId = int.Parse(this.dgvAuthor.Rows[colIndex].Cells[4].Value.ToString());

            var authorInfo = new DTO_Tacgia(authorId, txtAuthorName.Text, dtpNgaySinh.Value.ToString(), gioitinh);

            Delete_Author deleteAuthor = new Delete_Author(authorInfo);

            deleteAuthor.ShowDialog();
            this.ShowAuthorList();
        }

        // Open Update Author dialog
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvAuthor.SelectedRows.Count > 0 &&
                this.dgvAuthor.SelectedRows[0].Index ==
                this.dgvAuthor.Rows.Count - 1)
            {
                MessageBox.Show("Xin chọn thông tin tác giả cần chỉnh sửa!");
                return;
            }
            int gioitinh = 0;

            if (radGTMale.Checked == true)
            {
                gioitinh = 1;
            }

            int colIndex = this.dgvAuthor.SelectedRows[0].Index;
            int authorId = int.Parse(this.dgvAuthor.Rows[colIndex].Cells[4].Value.ToString());

            var authorInfo = new DTO_Tacgia(authorId, txtAuthorName.Text, dtpNgaySinh.Value.ToString(), gioitinh);

            Edit_Author editAuthor = new Edit_Author(authorInfo);

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
            if (this.dgvAuthor.SelectedRows.Count > 0 &&
                this.dgvAuthor.SelectedRows[0].Index ==
                this.dgvAuthor.Rows.Count - 1)
            {
                this.txtAuthorName.ResetText();
                this.dtpNgaySinh.ResetText();
                this.radGTFemale.Checked = true;
                this.radGTMale.Checked = false;
            }

            if (this.dgvAuthor.SelectedRows.Count > 0 && this.dgvAuthor.SelectedRows[0].Index == 0)
            {
                int rowindex = this.dgvAuthor.SelectedCells[0].RowIndex;
                if (null == this.dgvAuthor.Rows[rowindex].Cells[0].Value)
                {
                    this.txtAuthorName.Text = "";
                }
                else
                {
                    this.txtAuthorName.Text = this.dgvAuthor.Rows[rowindex].Cells[0].Value.ToString();
                }
                if (null == this.dgvAuthor.Rows[rowindex].Cells[1].Value)
                {
                    this.dtpNgaySinh.Text = "";
                }
                else
                {
                    this.dtpNgaySinh.Text = this.dgvAuthor.Rows[rowindex].Cells[1].Value.ToString();
                }

                this.radGTFemale.Checked = true;

                if (null != this.dgvAuthor.Rows[rowindex].Cells[3].Value
                    && this.dgvAuthor.Rows[rowindex].Cells[3].Value.ToString() == "True"
                    )
                {
                    this.radGTMale.Checked = true;
                }
            }
            if (this.dgvAuthor.SelectedRows.Count > 0 &&
                this.dgvAuthor.SelectedRows[0].Index !=
                this.dgvAuthor.Rows.Count - 1)
            {
                int rowindex = this.dgvAuthor.SelectedCells[0].RowIndex;
                this.txtAuthorName.Text = this.dgvAuthor.Rows[rowindex].Cells[0].Value.ToString();
                DateTime isBirthDay = DateTime.Parse(this.dgvAuthor.Rows[rowindex].Cells[1].Value.ToString());
                this.dtpNgaySinh.Text = isBirthDay.ToString();
                this.radGTFemale.Checked = true;

                if (null != this.dgvAuthor.Rows[rowindex].Cells[3].Value
                    && this.dgvAuthor.Rows[rowindex].Cells[3].Value.ToString() == "True"
                    )
                {
                    this.radGTMale.Checked = true;
                }
            }
        }
        #endregion
    }
}
