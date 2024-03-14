using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class Staff : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tanaya\OneDrive\Desktop\Documents\staff.mdf;Integrated Security=True;Connect Timeout=30");

        public Staff()
        {
            InitializeComponent();
            populate(); // Populate the data when the form loads
        }

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM Staff";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            staffdata.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string query = "INSERT INTO Staff (StaffN, StaffWork, StaffNo, StaffAdd, StaffSalry) VALUES (@StaffN, @StaffWork, @StaffNo, @StaffAdd, @StaffSalry)";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@StaffN", StaffN.Text);
                    cmd.Parameters.AddWithValue("@StaffWork", StaffWork.Text);
                    cmd.Parameters.AddWithValue("@StaffNo", StaffNo.Text);
                    cmd.Parameters.AddWithValue("@StaffAdd", StaffAdd.Text);
                    cmd.Parameters.AddWithValue("@StaffSalry", StaffSalry.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully");
                    Con.Close();
                    populate(); // Refresh the data grid after adding a new record
                }
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(StaffN.Text))
            {
                MessageBox.Show("Name is required", "Failed");
                return false;
            }

            // Additional validation logic can be added here if needed.

            // Return true when all validations pass.
            return true;
        }

        private void staffdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffNo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard2 Res = new Dashboard2();
            Res.Show();
            this.Hide();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
