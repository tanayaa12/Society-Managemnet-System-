using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace login
{
    public partial class Form1 : Form
    {
        private string text;
        private int len = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid user name", "error");
                return false;

            }
            else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid password", "error");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tanaya\source\repos\login\login\Database1.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM LOGIN WHERE username = '" + textBox1.Text.Trim() + "'And password ='" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        Dashboard2 res = new Dashboard2();
                        this.Hide();
                        res.Show();
                    }
                    // Process the data in the DataTable
                }
            }
            
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text = lab.Text;
            lab.Text = "";


          
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lab.Text = lab.Text + text.ElementAt(len);
                len++;

            }
            else
                timer1.Stop();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            // Set the PasswordChar property to '*' for hiding the password
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
