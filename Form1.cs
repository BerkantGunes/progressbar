using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbar
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sny;
        Timer tmr = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            sny = int.Parse(textBox1.Text);

            tmr.Interval = 1000;

            progressBar1.Maximum = sny;

            tmr.Tick += Tmr_Tick;
            tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<sny)
            {
                progressBar1.Value++;
            }
            else
            {
                tmr.Stop();
            }
        }
    }
}
