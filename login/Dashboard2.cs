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
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            residents Res = new residents();
            Res.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            visitors Res = new visitors();
            Res.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maintenance Res = new maintenance();
            Res.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff Res = new Staff();
            Res.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TotalExpenses Res = new TotalExpenses();
            Res.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vehicles Ves = new Vehicles();
            Ves.Show();
            this.Hide();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Homepage hes = new Homepage();
            hes.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
