namespace QLTV.Popup_Reader
{
    partial class Delete_Reader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radGTFemale = new System.Windows.Forms.RadioButton();
            this.radGTMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNK = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNK);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtReaderName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(833, 161);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radGTFemale);
            this.groupBox2.Controls.Add(this.radGTMale);
            this.groupBox2.Location = new System.Drawing.Point(113, 69);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(144, 47);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // radGTFemale
            // 
            this.radGTFemale.AutoSize = true;
            this.radGTFemale.Enabled = false;
            this.radGTFemale.Location = new System.Drawing.Point(79, 16);
            this.radGTFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGTFemale.Name = "radGTFemale";
            this.radGTFemale.Size = new System.Drawing.Size(47, 21);
            this.radGTFemale.TabIndex = 23;
            this.radGTFemale.TabStop = true;
            this.radGTFemale.Text = "Nữ";
            this.radGTFemale.UseVisualStyleBackColor = true;
            // 
            // radGTMale
            // 
            this.radGTMale.AutoSize = true;
            this.radGTMale.Enabled = false;
            this.radGTMale.Location = new System.Drawing.Point(0, 16);
            this.radGTMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGTMale.Name = "radGTMale";
            this.radGTMale.Size = new System.Drawing.Size(58, 21);
            this.radGTMale.TabIndex = 22;
            this.radGTMale.TabStop = true;
            this.radGTMale.Text = "Nam";
            this.radGTMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên độc giả:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(725, 100);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtReaderName
            // 
            this.txtReaderName.Location = new System.Drawing.Point(113, 37);
            this.txtReaderName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.ReadOnly = true;
            this.txtReaderName.Size = new System.Drawing.Size(284, 22);
            this.txtReaderName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Niên Khóa:";
            // 
            // txtNK
            // 
            this.txtNK.Location = new System.Drawing.Point(501, 38);
            this.txtNK.Name = "txtNK";
            this.txtNK.Size = new System.Drawing.Size(324, 22);
            this.txtNK.TabIndex = 25;
            // 
            // Delete_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 186);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Delete_Reader";
            this.Text = "Delete_Author";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radGTFemale;
        private System.Windows.Forms.RadioButton radGTMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNK;
    }
}