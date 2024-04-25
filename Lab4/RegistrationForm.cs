using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class RegistrationForm : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\replace with the path from your computer\IssDB.mdf; Integrated Security = True");
            cn.Open();
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Green;
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Green;
        }

        private void Button_loginA_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void Button_register_Click(object sender, EventArgs e)
        {
            if (textBox_passwordCR.Text != string.Empty || textBox_passwordR.Text != string.Empty || textBox_emailR.Text != string.Empty || textBox_userR.Text != string.Empty)
            {
                if (textBox_passwordR.Text == textBox_passwordCR.Text)
                {
                    cmd = new SqlCommand("select * from Users where username='" + textBox_userR.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Users values(@email,@password,@username)", cn);
                        cmd.Parameters.AddWithValue("email", textBox_emailR.Text);
                        cmd.Parameters.AddWithValue("password", GetSHA384(textBox_userR.Text,textBox_passwordR.Text));
                        cmd.Parameters.AddWithValue("username", textBox_userR.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("The password and confirmation password don't match ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            textBox_emailR.Clear();
            textBox_passwordR.Clear();
            textBox_userR.Clear();
            textBox_passwordCR.Clear();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static string GetSHA384(string userID, string password)
        {
            // SHA classes are disposable, use using to ensure any managed resources are properly disposed of by the runtime
            using SHA384 sha = new SHA384CryptoServiceProvider();

            // convert the username and password into bytes
            byte[] preHash = Encoding.ASCII.GetBytes(userID + password);

            // hash the bytes
            byte[] hash = sha.ComputeHash(preHash);

            // convert the raw bytes into a string that we can save to a database
            return Convert.ToString(hash);
        }
    }
}
