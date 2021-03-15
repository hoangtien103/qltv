using BUS_QLTV;
using DTO_QLTV;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTV.GUI
{
    public partial class CategoryGUI : Form
    {
        BUS_Category busCategory = new BUS_Category();
        DTO_Category dtoCategory = new DTO_Category();

        public CategoryGUI()
        {
            InitializeComponent();
            ShowCategoryList();
        }

        #region Show Category List

        void ShowCategoryList()
        {
            this.dgvCategory.Rows.Clear();
            DataTable dtTable = busCategory.getCategory();
            foreach (DataRow item in dtTable.Rows)
            {
                int rowIndex = dgvCategory.Rows.Add();
                dgvCategory.Rows[rowIndex].Cells[2].Value = item.ItemArray[0].ToString();
                dgvCategory.Rows[rowIndex].Cells[0].Value = item.ItemArray[1].ToString();
                dgvCategory.Rows[rowIndex].Cells[1].Value = item.ItemArray[2].ToString();

            }
        }
        #endregion

        #region Button event  

        /** Insert catelogy
         */
        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
                return;
            }

            DTO_Category dtoCategory = new DTO_Category(6, txtCategoryName.Text, txtCategoryNote.Text);

            bool insertSuccess = busCategory.insertCategory(dtoCategory);

            if (insertSuccess == false)
            {
                MessageBox.Show("Thêm tác giả thất bại");
                return;
            }

            MessageBox.Show("Thêm tác giả thành công");

            this.ShowCategoryList();
        }
        

        /** Edit Category Info
         */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!dgvCategory.CurrentRow.Selected)
            {
                MessageBox.Show("Hãy chọn tác giả muốn sửa");
                return;
            }

            int index = this.dgvCategory.SelectedRows[0].Index;
            int categoryId = Convert.ToInt32(this.dgvCategory.Rows[index].Cells[2].Value);

            DTO_Category cateId = new DTO_Category(categoryId, txtCategoryName.Text, txtCategoryNote.Text);

            if (txtCategoryName.Text != "")
            {
                if (busCategory.updateCategory(cateId))
                {
                    MessageBox.Show("Sửa thông tin tác giả thành công");
                    this.ShowCategoryList();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin tác giả ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Tên tác giả không được để trống!");
            }
        }

        /** delete Category Info
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvCategory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn tác giả muốn xóa");
                return;
            }



            string message = "Bạn có chắc muốn xóa Loại sách này?";
            string title = "Xác nhận xóa";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption: title, buttons);

            if (result == DialogResult.Yes)
            {
                if (this.dgvCategory.SelectedRows.Count > 0 &&
                    this.dgvCategory.SelectedRows[0].Index == this.dgvCategory.Rows.Count - 1)
                {
                    MessageBox.Show("Hãy chọn tác giả muốn xóa");
                    return;
                }
                else
                {
                    int index = this.dgvCategory.SelectedRows[0].Index;
                    busCategory.deleteCategory(Convert.ToInt32(this.dgvCategory.Rows[index].Cells[2].Value));
                    dgvCategory.Rows.RemoveAt(index);
                }
            }

            return;
        }

        /** Close Category Form
         */
        private void closeBtn_Click(object sender, EventArgs e)
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

        #region Set Focus Category info to Textbox
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCategory.SelectedRows.Count > 0 &&
                this.dgvCategory.SelectedRows[0].Index !=
                this.dgvCategory.Rows.Count - 1)
            {
                int rowindex = this.dgvCategory.SelectedCells[0].RowIndex;
                this.txtCategoryName.Text = this.dgvCategory.Rows[rowindex].Cells[0].Value.ToString();
                this.txtCategoryNote.Text = this.dgvCategory.Rows[rowindex].Cells[1].Value.ToString();
            }
            else return;
        }
        
        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvCategory.SelectedRows.Count > 0 &&
                this.dgvCategory.SelectedRows[0].Index !=
                this.dgvCategory.Rows.Count - 1)
            {
                int rowindex = e.RowIndex;
                this.txtCategoryName.Text = this.dgvCategory.Rows[rowindex].Cells[0].Value.ToString();
                this.txtCategoryNote.Text = this.dgvCategory.Rows[rowindex].Cells[1].Value.ToString();
            }
            else return;
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvCategory.SelectedRows.Count > 0 &&
                this.dgvCategory.SelectedRows[0].Index !=
                this.dgvCategory.Rows.Count - 1)
            {
                int rowindex = e.RowIndex;
                this.txtCategoryName.Text = this.dgvCategory.Rows[rowindex].Cells[0].Value.ToString();
                this.txtCategoryNote.Text = this.dgvCategory.Rows[rowindex].Cells[1].Value.ToString();
            }
            else return;
        }

        private void dgvCategory_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowindex = e.RowIndex;
            string a = this.dgvCategory.Rows[rowindex].Cells[0].Value.ToString();
            if (this.dgvCategory.SelectedRows.Count > 0 &&
                a.Length > 0)
            {

                this.txtCategoryName.Text = this.dgvCategory.Rows[rowindex].Cells[0].Value.ToString();
                this.txtCategoryNote.Text = this.dgvCategory.Rows[rowindex].Cells[1].Value.ToString();
            }

        }

        #endregion
    }
}
