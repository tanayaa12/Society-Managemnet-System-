using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
    public partial class visitors : Form
    {
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tanaya\OneDrive\Desktop\Documents\Visitors.mdf;Integrated Security=True;Connect Timeout=30");

        public visitors()
        {
            InitializeComponent();
            this.Load += new EventHandler(visitors_Load);
            populate();
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM VisTbl";
            using (SqlDataAdapter da = new SqlDataAdapter(query, Con))
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                VisiGrid.DataSource = ds.Tables[0];
            }
            Con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string query = "INSERT INTO VisTbl (VisiN, VisiP, DOE, VisiT, VisiD) VALUES (@VisiN, @VisiP, @DOE, @VisiT, @VisiD)";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@VisiN", VisiN.Text);
                    cmd.Parameters.AddWithValue("@VisiP", VisiP.Text);
                    cmd.Parameters.AddWithValue("@DOE", DateTime.Parse(DOE.Text)); // Parse to DateTime
                    cmd.Parameters.AddWithValue("@VisiT", VisiT.Text);
                    cmd.Parameters.AddWithValue("@VisiD", VisiD.Text);

                    try
                    {
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Failed to add");
                    }
                    finally
                    {
                        Con.Close();
                    }

                    populate();
                }
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(VisiN.Text))
            {
                MessageBox.Show("Name is required", "Failed");
                return false;
            }

            // Additional validation logic can be added here if needed.

            // Return true when all validations pass.
            return true;
        }

        private void visitors_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(VisiN.Text))
            {
                MessageBox.Show("Enter the visitor's Name");
            }
            else
            {
                string query = "DELETE FROM VisTbl WHERE VisiN = @VisiN";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@VisiN", VisiN.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully");
                    Con.Close();
                    populate();
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string query = "UPDATE VisTbl SET VisiP = @VisiP, DOE = @DOE, VisiT = @VisiT, VisiD = @VisiD WHERE VisiN = @VisiN";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@VisiN", VisiN.Text);
                    cmd.Parameters.AddWithValue("@VisiP", VisiP.Text);
                    cmd.Parameters.AddWithValue("@DOE", DOE.Text);
                    cmd.Parameters.AddWithValue("@VisiT", VisiT.Text);
                    cmd.Parameters.AddWithValue("@VisiD", VisiD.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                    Con.Close();
                    populate();
                }
            }
        }


        private void VisiGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 Res = new Dashboard2();
            Res.Show();
            this.Hide();
        }
    }
}
