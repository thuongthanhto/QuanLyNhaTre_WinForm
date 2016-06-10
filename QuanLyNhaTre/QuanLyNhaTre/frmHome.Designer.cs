namespace QuanLyNhaTre
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMininize = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnNHKL = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnQLTre = new System.Windows.Forms.Button();
            this.btnXepLop = new System.Windows.Forms.Button();
            this.btnQLThucDon = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.btnMininize);
            this.pnlTitle.Controls.Add(this.btnResize);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1119, 34);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản Lý Nhà Trẻ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMininize
            // 
            this.btnMininize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMininize.BackgroundImage")));
            this.btnMininize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMininize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMininize.FlatAppearance.BorderSize = 0;
            this.btnMininize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(219)))));
            this.btnMininize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(219)))));
            this.btnMininize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMininize.Location = new System.Drawing.Point(984, 0);
            this.btnMininize.Name = "btnMininize";
            this.btnMininize.Size = new System.Drawing.Size(45, 34);
            this.btnMininize.TabIndex = 3;
            this.btnMininize.UseVisualStyleBackColor = true;
            this.btnMininize.Click += new System.EventHandler(this.btnMininize_Click);
            // 
            // btnResize
            // 
            this.btnResize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResize.BackgroundImage")));
            this.btnResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(219)))));
            this.btnResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(219)))));
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResize.Location = new System.Drawing.Point(1029, 0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(45, 34);
            this.btnResize.TabIndex = 2;
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1074, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(49)))));
            this.pnlLeft.Controls.Add(this.btnHelp);
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.btnSetting);
            this.pnlLeft.Controls.Add(this.btnMenu);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 34);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(270, 556);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(0, 511);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(45, 45);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(45, 45);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQLThucDon);
            this.panel1.Controls.Add(this.btnXepLop);
            this.panel1.Controls.Add(this.btnQLTre);
            this.panel1.Controls.Add(this.btnPhanCong);
            this.panel1.Controls.Add(this.btnNHKL);
            this.panel1.Controls.Add(this.btnQLNhanVien);
            this.panel1.Location = new System.Drawing.Point(-4, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 413);
            this.panel1.TabIndex = 2;
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQLNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQLNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnQLNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQLNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNhanVien.Image")));
            this.btnQLNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(279, 45);
            this.btnQLNhanVien.TabIndex = 3;
            this.btnQLNhanVien.Text = "        Quản Lý Nhân Viên          ";
            this.btnQLNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // btnNHKL
            // 
            this.btnNHKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNHKL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNHKL.FlatAppearance.BorderSize = 0;
            this.btnNHKL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnNHKL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnNHKL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNHKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNHKL.ForeColor = System.Drawing.Color.White;
            this.btnNHKL.Image = ((System.Drawing.Image)(resources.GetObject("btnNHKL.Image")));
            this.btnNHKL.Location = new System.Drawing.Point(0, 45);
            this.btnNHKL.Name = "btnNHKL";
            this.btnNHKL.Size = new System.Drawing.Size(279, 45);
            this.btnNHKL.TabIndex = 4;
            this.btnNHKL.Text = "        Năm Học - Khối - Lớp      ";
            this.btnNHKL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNHKL.UseVisualStyleBackColor = true;
            this.btnNHKL.Click += new System.EventHandler(this.btnNHKL_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPhanCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanCong.FlatAppearance.BorderSize = 0;
            this.btnPhanCong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnPhanCong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanCong.Image")));
            this.btnPhanCong.Location = new System.Drawing.Point(0, 90);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(279, 45);
            this.btnPhanCong.TabIndex = 5;
            this.btnPhanCong.Text = "        Phân Công                       ";
            this.btnPhanCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnQLTre
            // 
            this.btnQLTre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQLTre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTre.FlatAppearance.BorderSize = 0;
            this.btnQLTre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnQLTre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnQLTre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTre.ForeColor = System.Drawing.Color.White;
            this.btnQLTre.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTre.Image")));
            this.btnQLTre.Location = new System.Drawing.Point(0, 135);
            this.btnQLTre.Name = "btnQLTre";
            this.btnQLTre.Size = new System.Drawing.Size(279, 45);
            this.btnQLTre.TabIndex = 6;
            this.btnQLTre.Text = "        Quản Lý Trẻ                     ";
            this.btnQLTre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLTre.UseVisualStyleBackColor = true;
            this.btnQLTre.Click += new System.EventHandler(this.btnQLTre_Click);
            // 
            // btnXepLop
            // 
            this.btnXepLop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXepLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXepLop.FlatAppearance.BorderSize = 0;
            this.btnXepLop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnXepLop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnXepLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXepLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLop.ForeColor = System.Drawing.Color.White;
            this.btnXepLop.Image = ((System.Drawing.Image)(resources.GetObject("btnXepLop.Image")));
            this.btnXepLop.Location = new System.Drawing.Point(0, 180);
            this.btnXepLop.Name = "btnXepLop";
            this.btnXepLop.Size = new System.Drawing.Size(279, 45);
            this.btnXepLop.TabIndex = 7;
            this.btnXepLop.Text = "        Xếp Lớp                             ";
            this.btnXepLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXepLop.UseVisualStyleBackColor = true;
            this.btnXepLop.Click += new System.EventHandler(this.btnXepLop_Click);
            // 
            // btnQLThucDon
            // 
            this.btnQLThucDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQLThucDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLThucDon.FlatAppearance.BorderSize = 0;
            this.btnQLThucDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnQLThucDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnQLThucDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLThucDon.ForeColor = System.Drawing.Color.White;
            this.btnQLThucDon.Image = ((System.Drawing.Image)(resources.GetObject("btnQLThucDon.Image")));
            this.btnQLThucDon.Location = new System.Drawing.Point(0, 225);
            this.btnQLThucDon.Name = "btnQLThucDon";
            this.btnQLThucDon.Size = new System.Drawing.Size(279, 45);
            this.btnQLThucDon.TabIndex = 8;
            this.btnQLThucDon.Text = "        Quản Lý Thực Đơn           ";
            this.btnQLThucDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLThucDon.UseVisualStyleBackColor = true;
            this.btnQLThucDon.Click += new System.EventHandler(this.btnQLThucDon_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(89)))), ((int)(((byte)(149)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(0, 466);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 45);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1119, 590);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMininize;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnNHKL;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnQLTre;
        private System.Windows.Forms.Button btnXepLop;
        private System.Windows.Forms.Button btnQLThucDon;
        private System.Windows.Forms.Button btnHelp;
    }
}

