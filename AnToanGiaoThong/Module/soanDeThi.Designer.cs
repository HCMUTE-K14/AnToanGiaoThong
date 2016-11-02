namespace AnToanGiaoThong.Module
{
    partial class soanDeThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSoan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXuatPDF = new System.Windows.Forms.Button();
            this.btnHuyDeThi = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(302, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(489, 382);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // btnSoan
            // 
            this.btnSoan.BackColor = System.Drawing.Color.Teal;
            this.btnSoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoan.Location = new System.Drawing.Point(158, 9);
            this.btnSoan.Name = "btnSoan";
            this.btnSoan.Size = new System.Drawing.Size(75, 33);
            this.btnSoan.TabIndex = 16;
            this.btnSoan.Text = "SOẠN";
            this.btnSoan.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cau,
            this.MaCau,
            this.DapAn});
            this.dataGridView1.Location = new System.Drawing.Point(2, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 382);
            this.dataGridView1.TabIndex = 13;
            // 
            // Cau
            // 
            this.Cau.HeaderText = "Câu";
            this.Cau.Name = "Cau";
            this.Cau.Width = 50;
            // 
            // MaCau
            // 
            this.MaCau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCau.HeaderText = "Mã Câu";
            this.MaCau.Name = "MaCau";
            // 
            // DapAn
            // 
            this.DapAn.HeaderText = "Đáp Án";
            this.DapAn.Name = "DapAn";
            this.DapAn.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Số Câu";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(74, 13);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 26);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          
            this.button3.Location = new System.Drawing.Point(598, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//           
            this.btnXuatPDF.Location = new System.Drawing.Point(406, 451);
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.Size = new System.Drawing.Size(75, 45);
            this.btnXuatPDF.TabIndex = 20;
            this.btnXuatPDF.UseVisualStyleBackColor = true;
            // 
            // btnHuyDeThi
            // 
            this.btnHuyDeThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //
            this.btnHuyDeThi.Location = new System.Drawing.Point(248, 243);
            this.btnHuyDeThi.Name = "btnHuyDeThi";
            this.btnHuyDeThi.Size = new System.Drawing.Size(48, 40);
            this.btnHuyDeThi.TabIndex = 19;
            this.btnHuyDeThi.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //
            this.btnXuat.Location=new System.Drawing.Point(248, 175);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(48, 40);
            this.btnXuat.TabIndex = 18;
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //
            this.button2.Location = new System.Drawing.Point(145, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           // 
            this.btnAdd.Location = new System.Drawing.Point(26, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 45);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // soanDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXuatPDF);
            this.Controls.Add(this.btnHuyDeThi);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSoan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "soanDeThi";
            this.Size = new System.Drawing.Size(794, 527);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.btnXuat.Image=global::AnToanGiaoThong.Properties.Resources.document_arrow_right_icon;
            this.button2.Image=global::AnToanGiaoThong.Properties.Resources.Close_2_icon;
            this.btnHuyDeThi.Image=global::AnToanGiaoThong.Properties.Resources.File_Delete_icon;
            this.btnAdd.Image=global::AnToanGiaoThong.Properties.Resources.add_icon__1_;
            this.btnXuatPDF.Image=global::AnToanGiaoThong.Properties.Resources.pdf_icon__1_;
            this.button3.Image=global::AnToanGiaoThong.Properties.Resources.folder_printer_icon;

        }

        #endregion
        private System.Windows.Forms.Button btnXuatPDF;
        private System.Windows.Forms.Button btnHuyDeThi;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSoan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
    }
}
