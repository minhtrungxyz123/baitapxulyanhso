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
    public partial class frmTruyenthamso : Form
    {
        public frmTruyenthamso()
        {
            InitializeComponent();
        }

        private void frmTruyenthamso_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn không được để trống ô nhập giá trị", "thông báo");

            }
            else
            {
                this.Close();

            }
        }
    }
}
