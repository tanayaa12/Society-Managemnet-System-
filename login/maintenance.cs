using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class maintenance : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tanaya\OneDrive\Desktop\Documents\Maintenance.mdf;Integrated Security=True;Connect Timeout=30");

        public maintenance()
        {
            InitializeComponent();
        }

        private void maintenance_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM Maint"; // Corrected table name to "Maint" instead of "Maintenance"
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Maint.DataSource = ds.Tables[0]; // Corrected DataGridView name to "Maint" instead of "Maintgrid"
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string query = "INSERT INTO Maint (ResiN, Building, FlatN, Amount, Status, DOP) VALUES (@ResiN, @Building, @FlatN, @Amount, @Status, @DOP)";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ResiN", ResiN.Text);
                    cmd.Parameters.AddWithValue("@Building", Building.Text);
                    cmd.Parameters.AddWithValue("@FlatN", FlatNo.Text); // Corrected parameter name to @FlatN
                    cmd.Parameters.AddWithValue("@Amount", Amount.Text);
                    cmd.Parameters.AddWithValue("@Status", Status.Text);
                    cmd.Parameters.AddWithValue("@DOP", DOP.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully");
                    Con.Close();
                    populate();
                }
            }
        }
        public void Textboxfilter()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM Maint where Status = @Status";
                SqlDataAdapter da = new SqlDataAdapter(query, Con);
                da.SelectCommand.Parameters.AddWithValue("@Status", Status.Text);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Maint.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {

            Textboxfilter();
        }


        private void maintenance_Load_1(object sender, EventArgs e)
        {

        }

        private void Maint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard2 Res = new Dashboard2();
            Res.Show();
            this.Hide();
        }
    }
}
