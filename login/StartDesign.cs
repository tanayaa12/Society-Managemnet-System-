using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class StartDesign : Form
    {
        private string text;
        private int len = 0;
        public StartDesign()
        {
            InitializeComponent();
        }
        int startpoint = 0;


        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void StartDesign_Load(object sender, EventArgs e)
        {
            text = label1.Text;
            label1.Text = "";
          
         
            timer2.Start();
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
               Homepage log = new Homepage();
                this.Hide();
                log.Show();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                label1.Text = label1.Text + text.ElementAt(len);
                len++;

            }
            else
                timer2.Stop();

        }

        
    }
}
