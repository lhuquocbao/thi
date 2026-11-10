namespace TestMaiThi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnTrai = new Button();
            btnTatca = new Button();
            btnTinhhocphi = new Button();
            btnGhifile = new Button();
            lstMonhoc = new ListBox();
            lstDachon = new ListBox();
            txtHocphi = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 27.8571434F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-1, -7);
            label1.Name = "label1";
            label1.Size = new Size(835, 145);
            label1.TabIndex = 0;
            label1.Text = "Tinh tong hoc phi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 645);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 706);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 690);
            label4.Name = "label4";
            label4.Size = new Size(0, 30);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 690);
            label5.Name = "label5";
            label5.Size = new Size(0, 30);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 706);
            label6.Name = "label6";
            label6.Size = new Size(0, 30);
            label6.TabIndex = 5;
            // 
            // btnTrai
            // 
            btnTrai.Location = new Point(332, 238);
            btnTrai.Name = "btnTrai";
            btnTrai.Size = new Size(131, 40);
            btnTrai.TabIndex = 6;
            btnTrai.Text = "<";
            btnTrai.UseVisualStyleBackColor = true;
            btnTrai.Click += btnTrai_Click;
            // 
            // btnTatca
            // 
            btnTatca.Location = new Point(332, 362);
            btnTatca.Name = "btnTatca";
            btnTatca.Size = new Size(131, 40);
            btnTatca.TabIndex = 7;
            btnTatca.Text = ">>";
            btnTatca.UseVisualStyleBackColor = true;
            btnTatca.Click += btnTatca_Click;
            // 
            // btnTinhhocphi
            // 
            btnTinhhocphi.Location = new Point(44, 589);
            btnTinhhocphi.Name = "btnTinhhocphi";
            btnTinhhocphi.Size = new Size(169, 40);
            btnTinhhocphi.TabIndex = 8;
            btnTinhhocphi.Text = "Tinh hoc phi";
            btnTinhhocphi.UseVisualStyleBackColor = true;
            btnTinhhocphi.Click += btnTinhhocphi_Click;
            // 
            // btnGhifile
            // 
            btnGhifile.Location = new Point(553, 589);
            btnGhifile.Name = "btnGhifile";
            btnGhifile.Size = new Size(131, 40);
            btnGhifile.TabIndex = 9;
            btnGhifile.Text = "Ghi file";
            btnGhifile.UseVisualStyleBackColor = true;
            btnGhifile.Click += btnGhifile_Click;
            // 
            // lstMonhoc
            // 
            lstMonhoc.FormattingEnabled = true;
            lstMonhoc.Location = new Point(-1, 152);
            lstMonhoc.Name = "lstMonhoc";
            lstMonhoc.Size = new Size(270, 364);
            lstMonhoc.TabIndex = 10;
            // 
            // lstDachon
            // 
            lstDachon.FormattingEnabled = true;
            lstDachon.Location = new Point(564, 152);
            lstDachon.Name = "lstDachon";
            lstDachon.Size = new Size(270, 364);
            lstDachon.TabIndex = 11;
            // 
            // txtHocphi
            // 
            txtHocphi.Location = new Point(271, 594);
            txtHocphi.Name = "txtHocphi";
            txtHocphi.ReadOnly = true;
            txtHocphi.Size = new Size(213, 35);
            txtHocphi.TabIndex = 12;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 27.8571434F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(-1, 662);
            label7.Name = "label7";
            label7.Size = new Size(835, 145);
            label7.TabIndex = 13;
            label7.Text = "Bai tap 3";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 805);
            Controls.Add(label7);
            Controls.Add(txtHocphi);
            Controls.Add(lstDachon);
            Controls.Add(lstMonhoc);
            Controls.Add(btnGhifile);
            Controls.Add(btnTinhhocphi);
            Controls.Add(btnTatca);
            Controls.Add(btnTrai);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnTrai;
        private Button btnTatca;
        private Button btnTinhhocphi;
        private Button btnGhifile;
        private ListBox lstMonhoc;
        private ListBox lstDachon;
        private TextBox txtHocphi;
        private Label label7;
    }
}
