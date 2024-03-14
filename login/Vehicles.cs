using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class Vehicles : Form
    {
        private string text;
        private int len = 0;
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tanaya\\OneDrive\\Desktop\\Documents\\Vehicles.mdf;Integrated Security=True;Connect Timeout=30");

        public Vehicles()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "SELECT * FROM Vehicles";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Residentsdta.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string query = "INSERT INTO Vehicles (VehiID, VehiName, VehiOwner, ParkingSlot) VALUES (@VehiID, @VehiName, @VehiOwner, @ParkingSlot)";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@VehiID", VehiID.Text);
                    cmd.Parameters.AddWithValue("@VehiName", VehiName.Text);
                    cmd.Parameters.AddWithValue("@VehiOwner", VehiOwner.Text);
                    cmd.Parameters.AddWithValue("@ParkingSlot", ParkingSlot.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully");
                    Con.Close();
                    populate();
                }
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(VehiName.Text))
            {
                MessageBox.Show("Name is required", "Failed");
                return false;
            }

            // Additional validation logic can be added here if needed.

            // Return true when all validations pass.
            return true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(VehiID.Text))
            {
                MessageBox.Show("Enter the Vehicle Id");
            }
            else
            {
                string query = "DELETE FROM Vehicles WHERE VehiID = @VehiID";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@VehiID", VehiID.Text);
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
                string query = "UPDATE Vehicles SET VehiName = @VehiName WHERE VehiID = @VehiID";
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@VehiName", VehiName.Text);
                    cmd.Parameters.AddWithValue("@VehiID", VehiID.Text);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");
                    Con.Close();
                    populate();
                }
            }
        }
        private void VehicleID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Dashboard2 des = new Dashboard2();
            des.Show();
            this.Hide();
        }
    }
}
