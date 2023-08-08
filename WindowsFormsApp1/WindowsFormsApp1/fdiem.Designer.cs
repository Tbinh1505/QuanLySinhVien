namespace WindowsFormsApp1
{
    partial class fdiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMsvSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtDiemTiengAnh = new System.Windows.Forms.TextBox();
            this.txtDiemTinHoc = new System.Windows.Forms.TextBox();
            this.txtDiemTC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dta = new System.Windows.Forms.DataGridView();
            this.di = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiengAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GDTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Điểm Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV:";
            // 
            // txtMsvSearch
            // 
            this.txtMsvSearch.Location = new System.Drawing.Point(76, 12);
            this.txtMsvSearch.Name = "txtMsvSearch";
            this.txtMsvSearch.Size = new System.Drawing.Size(160, 20);
            this.txtMsvSearch.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtMsvSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(275, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 44);
            this.panel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(264, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ tên SV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã SV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiếng anh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tin học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Giáo dục TC";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.Control;
            this.txtHoTen.ForeColor = System.Drawing.Color.Blue;
            this.txtHoTen.Location = new System.Drawing.Point(111, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(160, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(111, 53);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(160, 20);
            this.txtMasv.TabIndex = 5;
            // 
            // txtDiemTiengAnh
            // 
            this.txtDiemTiengAnh.Location = new System.Drawing.Point(111, 96);
            this.txtDiemTiengAnh.Name = "txtDiemTiengAnh";
            this.txtDiemTiengAnh.Size = new System.Drawing.Size(160, 20);
            this.txtDiemTiengAnh.TabIndex = 7;
            // 
            // txtDiemTinHoc
            // 
            this.txtDiemTinHoc.Location = new System.Drawing.Point(111, 136);
            this.txtDiemTinHoc.Name = "txtDiemTinHoc";
            this.txtDiemTinHoc.Size = new System.Drawing.Size(160, 20);
            this.txtDiemTinHoc.TabIndex = 9;
            // 
            // txtDiemTC
            // 
            this.txtDiemTC.Location = new System.Drawing.Point(111, 185);
            this.txtDiemTC.Name = "txtDiemTC";
            this.txtDiemTC.Size = new System.Drawing.Size(160, 20);
            this.txtDiemTC.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtDiemTB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtDiemTC);
            this.panel2.Controls.Add(this.txtDiemTinHoc);
            this.panel2.Controls.Add(this.txtDiemTiengAnh);
            this.panel2.Controls.Add(this.txtMasv);
            this.panel2.Controls.Add(this.txtHoTen);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(232, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 227);
            this.panel2.TabIndex = 14;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiemTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTB.ForeColor = System.Drawing.Color.Blue;
            this.txtDiemTB.Location = new System.Drawing.Point(296, 133);
            this.txtDiemTB.Multiline = true;
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.ReadOnly = true;
            this.txtDiemTB.Size = new System.Drawing.Size(51, 46);
            this.txtDiemTB.TabIndex = 13;
            this.txtDiemTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Điểm TB:";
            // 
            // dta
            // 
            this.dta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.di,
            this.MASV,
            this.Hoten,
            this.TiengAnh,
            this.TinHoc,
            this.GDTC});
            this.dta.Location = new System.Drawing.Point(64, 486);
            this.dta.Name = "dta";
            this.dta.Size = new System.Drawing.Size(796, 137);
            this.dta.TabIndex = 16;
            this.dta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dta_CellClick_1);
            // 
            // di
            // 
            this.di.DataPropertyName = "ID";
            this.di.HeaderText = "ID";
            this.di.Name = "di";
            this.di.Visible = false;
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã SV";
            this.MASV.Name = "MASV";
            this.MASV.Width = 150;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 200;
            // 
            // TiengAnh
            // 
            this.TiengAnh.DataPropertyName = "TiengAnh";
            this.TiengAnh.HeaderText = "Tiếng Anh";
            this.TiengAnh.Name = "TiengAnh";
            // 
            // TinHoc
            // 
            this.TinHoc.DataPropertyName = "TinHoc";
            this.TinHoc.HeaderText = "Tin Học";
            this.TinHoc.Name = "TinHoc";
            // 
            // GDTC
            // 
            this.GDTC.DataPropertyName = "GDTC";
            this.GDTC.HeaderText = "GDTC";
            this.GDTC.Name = "GDTC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "3 Sinh viên có điểm cao nhất";
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_end_502;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.Location = new System.Drawing.Point(548, 407);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 52);
            this.button9.TabIndex = 15;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_fast_forward_round_502;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Location = new System.Drawing.Point(472, 407);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 52);
            this.button8.TabIndex = 14;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_rewind_button_round_502;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Location = new System.Drawing.Point(392, 407);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 52);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_end_50__1_3;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Location = new System.Drawing.Point(326, 407);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 52);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.edit_16px2;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(615, 306);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close_16px2;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(615, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 29);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.save_16px2;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(615, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Plus_16px2;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(615, 177);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 29);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // fdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 625);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dta);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "fdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "diem";
            this.Load += new System.EventHandler(this.fdiem_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fdiem_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMsvSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtDiemTiengAnh;
        private System.Windows.Forms.TextBox txtDiemTinHoc;
        private System.Windows.Forms.TextBox txtDiemTC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn di;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiengAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GDTC;
    }
}