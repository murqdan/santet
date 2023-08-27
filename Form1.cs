using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            this.timer1.Start();     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(2);

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();

                if (rdbLaki.Checked == true)
                {
                    MessageBox.Show("Santet Berhasil Terkirim !");
                }
                else
                {
                    MessageBox.Show("Santet Berhasil Terkirim !");
                }

            }
        }
    }
}
