namespace AnToanGiaoThong.Module
{
    partial class hocLuatGiaoThong
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Chương 1");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Điều 9");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Điều 10");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Chương 2", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("21/12/2015");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("1/6/2016");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("300000-500000");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("1000000-1500000");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLuat = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabThongtu = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.tabTraCuuMucPhat = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabLuat.SuspendLayout();
            this.tabThongtu.SuspendLayout();
            this.tabTraCuuMucPhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLuat);
            this.tabControl1.Controls.Add(this.tabThongtu);
            this.tabControl1.Controls.Add(this.tabTraCuuMucPhat);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 566);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLuat
            // 
            this.tabLuat.Controls.Add(this.label2);
            this.tabLuat.Controls.Add(this.label1);
            this.tabLuat.Controls.Add(this.richTextBox1);
            this.tabLuat.Controls.Add(this.treeView1);
            this.tabLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLuat.Location = new System.Drawing.Point(4, 29);
            this.tabLuat.Name = "tabLuat";
            this.tabLuat.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuat.Size = new System.Drawing.Size(943, 533);
            this.tabLuat.TabIndex = 0;
            this.tabLuat.Text = "Luật giao thông";
            this.tabLuat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nội dung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tra cứu";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(225, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(552, 409);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(15, 30);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Chương 1";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Điều 9";
            treeNode11.Checked = true;
            treeNode11.Name = "Node4";
            treeNode11.Text = "Điều 10";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Chương 2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(203, 409);
            this.treeView1.TabIndex = 0;
            // 
            // tabThongtu
            // 
            this.tabThongtu.Controls.Add(this.label3);
            this.tabThongtu.Controls.Add(this.label4);
            this.tabThongtu.Controls.Add(this.richTextBox2);
            this.tabThongtu.Controls.Add(this.treeView2);
            this.tabThongtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabThongtu.Location = new System.Drawing.Point(4, 29);
            this.tabThongtu.Name = "tabThongtu";
            this.tabThongtu.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongtu.Size = new System.Drawing.Size(783, 474);
            this.tabThongtu.TabIndex = 1;
            this.tabThongtu.Text = "Thông tư";
            this.tabThongtu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chi tiết nội dung thông tư";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày ra thông tư";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(222, 44);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(552, 409);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(12, 44);
            this.treeView2.Name = "treeView2";
            treeNode13.Name = "Node0";
            treeNode13.Text = "21/12/2015";
            treeNode14.Name = "Node1";
            treeNode14.Text = "1/6/2016";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.treeView2.Size = new System.Drawing.Size(203, 409);
            this.treeView2.TabIndex = 4;
            // 
            // tabTraCuuMucPhat
            // 
            this.tabTraCuuMucPhat.Controls.Add(this.label5);
            this.tabTraCuuMucPhat.Controls.Add(this.label6);
            this.tabTraCuuMucPhat.Controls.Add(this.richTextBox3);
            this.tabTraCuuMucPhat.Controls.Add(this.treeView3);
            this.tabTraCuuMucPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTraCuuMucPhat.Location = new System.Drawing.Point(4, 29);
            this.tabTraCuuMucPhat.Name = "tabTraCuuMucPhat";
            this.tabTraCuuMucPhat.Size = new System.Drawing.Size(783, 474);
            this.tabTraCuuMucPhat.TabIndex = 2;
            this.tabTraCuuMucPhat.Text = "Tra cứu mức phạt";
            this.tabTraCuuMucPhat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chi tiết lỗi phạt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khoảng phạt";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(222, 44);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(552, 409);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(12, 44);
            this.treeView3.Name = "treeView3";
            treeNode15.Name = "Node0";
            treeNode15.Text = "300000-500000";
            treeNode16.Name = "Node1";
            treeNode16.Text = "1000000-1500000";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            this.treeView3.Size = new System.Drawing.Size(203, 409);
            this.treeView3.TabIndex = 4;
            // 
            // hocLuatGiaoThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "hocLuatGiaoThong";
            this.Size = new System.Drawing.Size(951, 566);
            this.tabControl1.ResumeLayout(false);
            this.tabLuat.ResumeLayout(false);
            this.tabLuat.PerformLayout();
            this.tabThongtu.ResumeLayout(false);
            this.tabThongtu.PerformLayout();
            this.tabTraCuuMucPhat.ResumeLayout(false);
            this.tabTraCuuMucPhat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLuat;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabThongtu;
        private System.Windows.Forms.TabPage tabTraCuuMucPhat;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TreeView treeView3;
    }
}
