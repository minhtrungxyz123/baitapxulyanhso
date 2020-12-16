namespace baitapxulyanhso
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.xửLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRgbtogray = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGraytobin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRgbtobin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDosang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInvent = new System.Windows.Forms.ToolStripMenuItem();
            this.lọcBiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoĐịnhNghĩaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.anhgoc = new System.Windows.Forms.PictureBox();
            this.anhmoi = new System.Windows.Forms.PictureBox();
            this.Opendialog = new System.Windows.Forms.OpenFileDialog();
            this.Savedialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhgoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhmoi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xửLýĐiểmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.btnThoat});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(130, 26);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 26);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 26);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // xửLýĐiểmToolStripMenuItem
            // 
            this.xửLýĐiểmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRgbtogray,
            this.btnGraytobin,
            this.btnRgbtobin,
            this.btnDosang,
            this.btnInvent,
            this.lọcBiênToolStripMenuItem});
            this.xửLýĐiểmToolStripMenuItem.Name = "xửLýĐiểmToolStripMenuItem";
            this.xửLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.xửLýĐiểmToolStripMenuItem.Text = "Xử lý điểm ";
            // 
            // btnRgbtogray
            // 
            this.btnRgbtogray.Name = "btnRgbtogray";
            this.btnRgbtogray.Size = new System.Drawing.Size(224, 26);
            this.btnRgbtogray.Text = "RGB to Gray";
            this.btnRgbtogray.Click += new System.EventHandler(this.rGBToGrayToolStripMenuItem_Click);
            // 
            // btnGraytobin
            // 
            this.btnGraytobin.Name = "btnGraytobin";
            this.btnGraytobin.Size = new System.Drawing.Size(224, 26);
            this.btnGraytobin.Text = "Gray To Bin";
            this.btnGraytobin.Click += new System.EventHandler(this.grayToBinToolStripMenuItem_Click);
            // 
            // btnRgbtobin
            // 
            this.btnRgbtobin.Name = "btnRgbtobin";
            this.btnRgbtobin.Size = new System.Drawing.Size(224, 26);
            this.btnRgbtobin.Text = "RGB to bin";
            this.btnRgbtobin.Click += new System.EventHandler(this.rGBToBinToolStripMenuItem_Click);
            // 
            // btnDosang
            // 
            this.btnDosang.Name = "btnDosang";
            this.btnDosang.Size = new System.Drawing.Size(224, 26);
            this.btnDosang.Text = "Thay đổi độ sáng";
            this.btnDosang.Click += new System.EventHandler(this.thayĐổiĐộSángToolStripMenuItem_Click);
            // 
            // btnInvent
            // 
            this.btnInvent.Name = "btnInvent";
            this.btnInvent.Size = new System.Drawing.Size(224, 26);
            this.btnInvent.Text = "Invent";
            this.btnInvent.Click += new System.EventHandler(this.inventToolStripMenuItem_Click);
            // 
            // lọcBiênToolStripMenuItem
            // 
            this.lọcBiênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoĐịnhNghĩaToolStripMenuItem});
            this.lọcBiênToolStripMenuItem.Name = "lọcBiênToolStripMenuItem";
            this.lọcBiênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lọcBiênToolStripMenuItem.Text = "Lọc biên";
            this.lọcBiênToolStripMenuItem.Click += new System.EventHandler(this.theoĐịnhNghĩaToolToolStripMenuItem_Click);
            // 
            // theoĐịnhNghĩaToolStripMenuItem
            // 
            this.theoĐịnhNghĩaToolStripMenuItem.Name = "theoĐịnhNghĩaToolStripMenuItem";
            this.theoĐịnhNghĩaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.theoĐịnhNghĩaToolStripMenuItem.Text = "Theo định nghĩa";
            this.theoĐịnhNghĩaToolStripMenuItem.Click += new System.EventHandler(this.theoĐịnhNghĩaToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.anhgoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.anhmoi, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 497);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // anhgoc
            // 
            this.anhgoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anhgoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anhgoc.Location = new System.Drawing.Point(3, 3);
            this.anhgoc.Name = "anhgoc";
            this.anhgoc.Size = new System.Drawing.Size(479, 491);
            this.anhgoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anhgoc.TabIndex = 0;
            this.anhgoc.TabStop = false;
            // 
            // anhmoi
            // 
            this.anhmoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.anhmoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anhmoi.Location = new System.Drawing.Point(488, 3);
            this.anhmoi.Name = "anhmoi";
            this.anhmoi.Size = new System.Drawing.Size(480, 491);
            this.anhmoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anhmoi.TabIndex = 1;
            this.anhmoi.TabStop = false;
            this.anhmoi.Click += new System.EventHandler(this.anhmoi_Click);
            // 
            // Opendialog
            // 
            this.Opendialog.FileName = "openFileDialog1";
            this.Opendialog.Filter = "Tất cả các file(*.*)(*.*)(*.png)|.*png|(*.jpg)|*.jpg|(*.bmp)|*.bmp";
            // 
            // Savedialog
            // 
            this.Savedialog.Filter = "Tất cả các file(*.*)(*.*)(*.png)|.*png|(*.jpg)|*.jpg|(*.bmp)|*.bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.anhgoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anhmoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem xửLýĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRgbtogray;
        private System.Windows.Forms.ToolStripMenuItem btnGraytobin;
        private System.Windows.Forms.ToolStripMenuItem btnRgbtobin;
        private System.Windows.Forms.ToolStripMenuItem btnDosang;
        private System.Windows.Forms.ToolStripMenuItem btnInvent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox anhgoc;
        private System.Windows.Forms.PictureBox anhmoi;
        private System.Windows.Forms.OpenFileDialog Opendialog;
        private System.Windows.Forms.SaveFileDialog Savedialog;
        private System.Windows.Forms.ToolStripMenuItem btnThoat;
        private System.Windows.Forms.ToolStripMenuItem lọcBiênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoĐịnhNghĩaToolStripMenuItem;
    }
}

