using QLTV.GUI;
using System;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenCatelogy_Click(object sender, EventArgs e)
        {
            CategoryGUI cateForm = new CategoryGUI();
            cateForm.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenAuthor_Click(object sender, EventArgs e)
        {
            AuthorGUI authorForm = new AuthorGUI();
            authorForm.ShowDialog();
        }

        private void btnOpenReader_Click(object sender, EventArgs e)
        {
            ReaderGUI readerForm = new ReaderGUI();
            readerForm.ShowDialog();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            AuthorGUI authorForm = new AuthorGUI();
            authorForm.ShowDialog();
        }
    }
}
