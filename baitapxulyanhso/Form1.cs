using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapxulyanhso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void xuly(bool b)
        {
            btnSave.Enabled = b;
            btnRgbtogray.Enabled = btnGraytobin.Enabled = btnRgbtobin.Enabled = btnInvent.Enabled = btnDosang.Enabled=b;
        }
        private void anhmoi_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuly(true);
            Opendialog.Title = "mở ảnh";
            Opendialog.InitialDirectory = @"C:\Users\ADMIN\Desktop";
            if(Opendialog.ShowDialog()==DialogResult.OK)
            {
                anhgoc.Image = Image.FromFile(Opendialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Savedialog.Title="save file";
            Savedialog.InitialDirectory = @"C:\Users\ADMIN\Desktop";
            if (Savedialog.ShowDialog() == DialogResult.OK)
            {
                anhmoi.Image.Save(Savedialog.FileName);

            }
        }

        private void rGBToGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //thuật toán chuyển ảnh màu thành âm bản
            //tạo mội ảnh clone và gán ảnh vào ma trận bitmap
            Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    //lấy giá trị mày tại điểm (x,y)
                    Color p = bmp.GetPixel(x, y);
                    //gán giá trị màu đảo ngược cho điểm (x,y)
                    int t = (int)(p.R * .299 + p.G * .587 + p.B * .114);
                    bmp.SetPixel(x, y, Color.FromArgb(t, t, t));

                }
            }
            anhmoi.Image = bmp;

        }

        private void grayToBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //thuật toán chuyển đổi ảnh xám
            Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int t = (int)(p.R * .299 + p.G * .587 + p.B * .114);
                    if (t >= 128) 
                    t = 255;
                    else
                        t = 0;
                    bmp.SetPixel(x, y, Color.FromArgb(t, t, t));


                }
            }
            anhmoi.Image = bmp;

        }

        private void rGBToBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int t1, t2, t3;
                    t1 = (p.R >= 128) ? 225 : 0;
                    t2 = (p.G >= 128) ? 225 : 0;
                    t3 = (p.B >= 128) ? 225 : 0;
                    bmp.SetPixel(x, y, Color.FromArgb(t1, t2, t3));
                }
            }
            anhmoi.Image = bmp;
        }

        private void inventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            anhmoi.Image = bmp;
        }

        private void thayĐổiĐộSángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTruyenthamso frm = new frmTruyenthamso();
            frm.ShowDialog();
            int value = int.Parse(frm.textBox1.Text);
            Bitmap bmp = (Bitmap)anhgoc.Image.Clone();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int t1 = Math.Max(Math.Min(c.R + value, 255), 0);
                    int t2 = Math.Max(Math.Min(c.G + value, 255), 0);
                    int t3 = Math.Max(Math.Min(c.B + value, 255), 0);
                    bmp.SetPixel(x, y, Color.FromArgb(t1, t2, t3));
                }
            }
            anhmoi.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xuly(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void theoĐịnhNghĩaToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap ptrC = (Bitmap)anhgoc.Image.Clone();
            Color point = ptrC.GetPixel(0, 0);
            for (int y = 0; y <ptrC.Height; y++)
            {
                for (int x = 0; x < ptrC.Width; x++)
                {
                    //lấy màu tại điểm(x,y)
                    Color thisPoint = ptrC.GetPixel(x, y);

                    
                }
            }
        }

        private void theoĐịnhNghĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap data = (Bitmap)anhgoc.Image.Clone();
            Color p = data.GetPixel(0, 0);
            for (int y = 0; y < data.Height; y++)
            {
                for (int x = 0; x < data.Width; x++)
                {
                    Color pNext = data.GetPixel(x, y);

                    Color pCheck = Color.FromArgb(checkValueColor.validateColor(pNext.R - p.R), checkValueColor.validateColor(pNext.G - p.G), checkValueColor.validateColor(pNext.B - p.B));

                    p = data.GetPixel(x, y);

                    if (pCheck.R >= 50 || pCheck.G >= 50 || pCheck.B >= 50)
                    {
                        data.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        data.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            anhmoi.Image = data;
        }
    }
}
