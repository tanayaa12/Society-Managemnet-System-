using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login
{
    public partial class residents : Form
    {
        private string text;
        private int len = 0;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tanaya\OneDrive\Desktop\Documents\Residents.mdf;Integrated Security=True;Connect Timeout=30");

        public residents()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "SELECT * FROM Resident";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Residentsdta.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string query = "INSERT INTO Resident (ResiN, FlatN, Building, YouAre) VALUES (@ResiN, @FlatN, @Building, @YouAre)";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ResiN", ResiN.Text);
                    cmd.Parameters.AddWithValue("@FlatN", FlatNo.Text);
                    cmd.Parameters.AddWithValue("@Building", Building.Text);
                    cmd.Parameters.AddWithValue("@YouAre", YouAre.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully");
                    Con.Close();
                }
                populate();
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(ResiN.Text))
            {
                MessageBox.Show("Name is required", "Failed");
                return false;
            }

            // Additional validation logic can be added here if needed.

            // Return true when all validations pass.
            return true;
        }

        private void residents_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ResiN.Text))
            {
                MessageBox.Show("Enter the Resident Name");
            }
            else
            {
                string query = "DELETE FROM Resident WHERE ResiN = @ResiN";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ResiN", ResiN.Text);
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
                string query = "UPDATE Resident SET FlatN = @FlatN, Building = @Building WHERE ResiN = @ResiN";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ResiN", ResiN.Text);
                    cmd.Parameters.AddWithValue("@FlatN", FlatNo.Text);
                    cmd.Parameters.AddWithValue("@Building", Building.Text); // Add this line to update Building
                    cmd.Parameters.AddWithValue("@YouAre", YouAre.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                    Con.Close();
                    populate();
                }
            }
        }




        public void Textboxfilter()
        {
            Con.Open();
            string query = "SELECT * FROM Resident where Building = @Nametb";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            da.SelectCommand.Parameters.AddWithValue("@Nametb", Nametb.Text);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Residentsdta.DataSource = ds.Tables[0];
            Con.Close();
        }
        public void Buildingfilter()
        {
            try
            {
                Con.Open();

                string query = "SELECT * FROM Resident WHERE Building = @Building";

                using (SqlDataAdapter da = new SqlDataAdapter(query, Con))
                {
                    // Make sure Building.SelectedValue is not null and has a valid value
                    if (Building.SelectedValue != null)
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Building", Building.SelectedValue.ToString());

                        var ds = new DataSet();
                        da.Fill(ds);

                        // Assuming Residentsdta is a DataGridView, make sure it's properly set up in your UI
                        Residentsdta.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display an error message)
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Textboxfilter();
          


        }
        private void Building_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buildingfilter();
        }

        private void FlatNo_OnValueChanged(object sender, EventArgs e)
        {
        }
        

        private void residents_Load_1(object sender, EventArgs e)
        {
            text = label1.Text;
            label1.Text = "";



            timer1.Start();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Dashboard2 des = new Dashboard2();
            des.Show();
            this.Hide();
        }

        private void Residentsdta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                label1.Text = label1.Text + text.ElementAt(len);
                len++;

            }
            else
                timer1.Stop();
        }
    }
    }

