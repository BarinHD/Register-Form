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
    public partial class Form1 : Form
    {
        public const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Student\Desktop\ \Boyan Metodiev 12g\ProbaZaPrakticheskaZad1\Prakticheska1.accdb";
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckPasswords()
        {
            return txtBox_ConfPass.Text == txtBox_Pass.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_Showpass.Checked)
            {
                txtBox_Pass.PasswordChar = '\0';
                txtBox_ConfPass.PasswordChar = '\0';
            }
            else
            {
                txtBox_Pass.PasswordChar = '*';
                txtBox_ConfPass.PasswordChar = '*';
            }
        }

        private void btn_Reg_Click(object sender, EventArgs e)
        {
            string myquery = "INSERT INTO Accounts VALUES ('" + txtBox_User.Text + "','" + txtBox_Pass.Text + "')";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            OleDbCommand command = new OleDbCommand(myquery, connection);


            if (txtBox_Pass.Text.Length == 0 || txtBox_ConfPass.Text.Length == 0 || txtBox_User.Text.Length == 0)
            {
                MessageBox.Show("Write in the textboxes!", "Register unsuccessful!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                if (CheckPasswords())
                {
                    MessageBox.Show("Registered successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Register unsuccessful!", "Failure!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Datebase saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally { connection.Close(); }
            Form2 frm = new Form2();
            frm.Show(this);
            this.Hide();
        }
    }
}
