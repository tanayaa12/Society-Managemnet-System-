using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;

namespace login
{
    public partial class TotalExpenses : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tanaya\OneDrive\Desktop\Documents\Expenses.mdf;Integrated Security=True;Connect Timeout=30");

        public TotalExpenses()
        {
            InitializeComponent();
            populate();
        }

        void populate()
        {
            using (var da = new SqlDataAdapter("SELECT * FROM ExpTbl", Con))
            {
                var ds = new DataSet();
                da.Fill(ds);
                ExpData.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string query = "INSERT INTO ExpTbl (ExName, ExAmount, DOES, [Desc]) VALUES (@ExName, @ExAmount, @DOES, @Desc)";
                using (var cmd = new SqlCommand(query, Con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ExName", ExName.Text);
                    cmd.Parameters.AddWithValue("@ExAmount", decimal.Parse(ExAmount.Text));
                    cmd.Parameters.AddWithValue("@DOES", DOES.Text);
                    cmd.Parameters.AddWithValue("@Desc", Desc.Text);

                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    populate();
                    MessageBox.Show("Added successfully");
                }
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(ExName.Text))
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
            decimal totalExpense = 0;

            foreach (DataGridViewRow row in ExpData.Rows)
            {
                if (row.Cells["ExAmount"].Value != null && decimal.TryParse(row.Cells["ExAmount"].Value.ToString(), out decimal expense))
                {
                    totalExpense += expense;
                }
            }
            MessageBox.Show($"Total amount: {totalExpense}");

            //label1.Text = totalExpense.ToString();
        }
        private void FindMaximumAmount()
        {
            decimal maxAmount = decimal.MinValue; // Initialize to the smallest possible value

            foreach (DataGridViewRow row in ExpData.Rows)
            {
                if (row.Cells["ExAmount"].Value != null && decimal.TryParse(row.Cells["ExAmount"].Value.ToString(), out decimal expense))
                {
                    if (expense > maxAmount)
                    {
                        maxAmount = expense;
                    }
                }
            }

            MessageBox.Show($"Maximum amount: {maxAmount}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindMaximumAmount();
        }

        private void TotalExpenses_Load(object sender, EventArgs e)
        {

        }

        private void ExpData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard2 Res = new Dashboard2();
            Res.Show();
            this.Hide();
        }
    }
}