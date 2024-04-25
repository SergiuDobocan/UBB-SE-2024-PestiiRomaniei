using System.Data;
using System.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ISS
{
    public partial class LoginForm : Form
    {
        //DBConnect dbConne = new DBConnect();
        public static string employeeName;
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\replace with the path from your computer\IssDB.mdf; Integrated Security = True");
            cn.Open();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox_email.Clear();
            textBox_password.Clear();
        }

        private void label5_exit_MouseEnter(object sender, EventArgs e)
        {
            label5_exit.ForeColor = Color.Red;
        }

        private void label5_exit_MouseLeave(object sender, EventArgs e)
        {
            label5_exit.ForeColor = Color.DarkGreen;
        }

        private void label4_clear_MouseEnter(object sender, EventArgs e)
        {
            label4_clear.ForeColor = Color.Red;
        }

        private void label4_clear_MouseLeave(object sender, EventArgs e)
        {
            label4_clear.ForeColor = Color.Green;
        }

        private void label5_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
        private void Button_login_Click(object sender, EventArgs e)
        {
            if (textBox_password.Text != string.Empty || textBox_email.Text != string.Empty)
            {
                // Hash the entered password
                string hashedPassword = GetSHA384(textBox_email.Text, textBox_password.Text);

                cmd = new SqlCommand("select * from Users where email=@email", cn);
                cmd.Parameters.AddWithValue("email", textBox_email.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string storedHashedPassword = dr["password"].ToString(); // Assuming "password" is the column name for hashed password in your database

                    dr.Close();

                    // Compare the hashed passwords
                    if (storedHashedPassword == hashedPassword)
                    {
                        // Passwords match - login successful
                        this.Hide();
                        UsersForm users = new UsersForm();
                        users.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if (textBox_user.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Please enter username and password", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    if (comboBox_role.SelectedIndex > -1)
                    {
                        if (comboBox_role.SelectedItem.ToString() == "ADMINISTRATOR")
                        {
                            string selectQuery = "SELECT EmployeeId FROM Employees WHERE EmployeeName='" + textBox_user.Text + "' AND EmployeePassword='" + textBox_password.Text + "'  AND EmployeeType='" + comboBox_role.Text + "' ";
                            SqlCommand command = new SqlCommand(selectQuery, dbConne.GetConnection());
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                ProductForm product = new ProductForm();
                                product.Show();
                                this.Hide();
                            }


                            else
                            {
                                MessageBox.Show("Wrong username or password, if you are not administrator change to employee", "Wrong information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (comboBox_role.SelectedItem.ToString() == "CLIENT")
                        {
                            string selectQuery3 = "SELECT * FROM Employees WHERE EmployeeName='" + textBox_user.Text + "' AND EmployeePassword='" + textBox_password.Text + "' AND EmployeeType='" + comboBox_role.Text + "' ";
                            DataTable table = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery3, dbConne.GetConnection());
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                employeeName = textBox_user.Text;
                                CashRegisterForm register = new CashRegisterForm();
                                register.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Wrong username or password employee", "Wrong information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (comboBox_role.SelectedItem.ToString() == "ARTIST")
                        {
                            string selectQuery3 = "SELECT * FROM Artists WHERE ArtistName='" + textBox_user.Text + "' AND ArtistPassword='" + textBox_password.Text + "' AND EmployeeType='" + comboBox_role.Text + "' ";
                            DataTable table = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery3, dbConne.GetConnection());
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                employeeName = textBox_user.Text;
                                CashRegisterForm register = new CashRegisterForm();
                                register.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Wrong username or password employee", "Wrong information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select type of account", "Wrong information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
        }
        */

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (textBox_email.Text != string.Empty && textBox_password.Text != string.Empty)
            {
                // Hash the entered password
                string hashedPassword = GetSHA384(textBox_email.Text, textBox_password.Text);

                // Query the database for the user's email and hashed password
                cmd = new SqlCommand("SELECT * FROM Users WHERE email=@email", cn);
                cmd.Parameters.AddWithValue("email", textBox_email.Text);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string storedHashedPassword = dr["password"].ToString(); // Assuming "password" is the column name for hashed password in your database

                    dr.Close();

                    // Compare the hashed passwords
                    if (storedHashedPassword == hashedPassword)
                    {
                        // Passwords match - login successful
                        this.Hide();
                        UsersForm users = new UsersForm();
                        users.ShowDialog();
                    }
                    else
                    {
                        // Passwords don't match
                        MessageBox.Show("Incorrect email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // No user found with the entered email
                    dr.Close();
                    MessageBox.Show("No account found with this email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Fields are empty
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Button_loginA_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.ShowDialog();
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