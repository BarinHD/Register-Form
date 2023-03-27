using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProbaZaPrakticheskaZad1
{
    public partial class Form2 : Form
    {
        public const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Student\Desktop\ \Boyan Metodiev 12g\ProbaZaPrakticheskaZad1\Prakticheska1.accdb";
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(this);
            this.Hide();
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Accounts WHERE Username = @Username AND Password = @Password";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", txtBox_User.Text);
                    command.Parameters.AddWithValue("@Password", txtBox_Pass.Text);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful!");
                        }
                        else
                        {
                            MessageBox.Show("Login unsuccessful!");
                        }
                    }
                }
            }
        }
    }
}
