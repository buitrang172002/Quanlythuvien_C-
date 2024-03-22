
namespace _1_BTHuyenTrang_VTAnhTrinh_NVThanh_LDThanh_LTNET
{
    partial class frmBaoCaoSach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchCủaNhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchĐộcGiảMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchĐộcGiảTrảQuáHạnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchChoMượnSáchCủaNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1458, 466);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 30);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(1452, 433);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "BÁO CÁO THỐNG KÊ SÁCH CÓ TRONG THƯ VIỆN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1458, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::_1_BTHuyenTrang_VTAnhTrinh_NVThanh_LDThanh_LTNET.Properties.Resources.exit__1_;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1004, 59);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(174, 48);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(616, 59);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(235, 48);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(248, 59);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(235, 48);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1575, 40);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchCủaNhàXuấtBảnToolStripMenuItem,
            this.sáchĐộcGiảMượnToolStripMenuItem,
            this.sáchĐộcGiảTrảQuáHạnToolStripMenuItem,
            this.danhSáchChoMượnSáchCủaNVToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(221, 36);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo, thống kê";
            // 
            // sáchCủaNhàXuấtBảnToolStripMenuItem
            // 
            this.sáchCủaNhàXuấtBảnToolStripMenuItem.Name = "sáchCủaNhàXuấtBảnToolStripMenuItem";
            this.sáchCủaNhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(469, 36);
            this.sáchCủaNhàXuấtBảnToolStripMenuItem.Text = "Sách của nhà xuất bản";
            this.sáchCủaNhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.sáchCủaNhàXuấtBảnToolStripMenuItem_Click);
            // 
            // sáchĐộcGiảMượnToolStripMenuItem
            // 
            this.sáchĐộcGiảMượnToolStripMenuItem.Name = "sáchĐộcGiảMượnToolStripMenuItem";
            this.sáchĐộcGiảMượnToolStripMenuItem.Size = new System.Drawing.Size(469, 36);
            this.sáchĐộcGiảMượnToolStripMenuItem.Text = "Sách độc giả mượn";
            this.sáchĐộcGiảMượnToolStripMenuItem.Click += new System.EventHandler(this.sáchĐộcGiảMượnToolStripMenuItem_Click);
            // 
            // sáchĐộcGiảTrảQuáHạnToolStripMenuItem
            // 
            this.sáchĐộcGiảTrảQuáHạnToolStripMenuItem.Name = "sáchĐộcGiảTrảQuáHạnToolStripMenuItem";
            this.sáchĐộcGiảTrảQuáHạnToolStripMenuItem.Size = new System.Drawing.Size(469, 36);
            this.sáchĐộcGiảTrảQuáHạnToolStripMenuItem.Text = "Sách độc giả trả quá hạn";
            this.sáchĐộcGiảTrảQuáHạnToolStripMenuItem.Click += new System.EventHandler(this.sáchĐộcGiảTrảQuáHạnToolStripMenuItem_Click);
            // 
            // danhSáchChoMượnSáchCủaNVToolStripMenuItem
            // 
            this.danhSáchChoMượnSáchCủaNVToolStripMenuItem.Name = "danhSáchChoMượnSáchCủaNVToolStripMenuItem";
            this.danhSáchChoMượnSáchCủaNVToolStripMenuItem.Size = new System.Drawing.Size(469, 36);
            this.danhSáchChoMượnSáchCủaNVToolStripMenuItem.Text = "Danh sách cho mượn sách của NV";
            this.danhSáchChoMượnSáchCủaNVToolStripMenuItem.Click += new System.EventHandler(this.danhSáchChoMượnSáchCủaNVToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(469, 36);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmBaoCaoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 809);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmBaoCaoSach";
            this.Text = "frmBaoCaoSach";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchCủaNhàXuấtBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchĐộcGiảMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchĐộcGiảTrảQuáHạnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchChoMượnSáchCủaNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}