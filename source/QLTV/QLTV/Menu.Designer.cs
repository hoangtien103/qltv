namespace QLTV
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenCatelogy = new System.Windows.Forms.Button();
            this.btnOpenReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ THƯ VIỆN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOpenCatelogy
            // 
            this.btnOpenCatelogy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCatelogy.Location = new System.Drawing.Point(64, 129);
            this.btnOpenCatelogy.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCatelogy.Name = "btnOpenCatelogy";
            this.btnOpenCatelogy.Size = new System.Drawing.Size(232, 89);
            this.btnOpenCatelogy.TabIndex = 6;
            this.btnOpenCatelogy.Text = "Category ";
            this.btnOpenCatelogy.UseVisualStyleBackColor = true;
            this.btnOpenCatelogy.Click += new System.EventHandler(this.btnOpenCatelogy_Click);
            // 
            // btnOpenReader
            // 
            this.btnOpenReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnOpenReader.Location = new System.Drawing.Point(64, 251);
            this.btnOpenReader.Name = "btnOpenReader";
            this.btnOpenReader.Size = new System.Drawing.Size(229, 89);
            this.btnOpenReader.TabIndex = 8;
            this.btnOpenReader.Text = "Reader";
            this.btnOpenReader.UseVisualStyleBackColor = true;
            this.btnOpenReader.Click += new System.EventHandler(this.btnOpenReader_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 775);
            this.Controls.Add(this.btnOpenReader);
            this.Controls.Add(this.btnOpenCatelogy);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton1;
        private System.Windows.Forms.Button btnOpenCatelogy;
        private System.Windows.Forms.Button btnOpenReader;
    }
}

