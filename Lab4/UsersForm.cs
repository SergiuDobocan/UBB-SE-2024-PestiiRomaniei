using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ISS
{
    public partial class UsersForm : Form
    {
        DBConnect dbConn = new DBConnect();
        public UsersForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Users";
                SqlCommand command = new SqlCommand(selectQuery, dbConn.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_Users.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_user.Text == "" || textBox_email.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string modifyQuery = "UPDATE Users SET email='" + textBox_email.Text + "', password = '" + GetSHA384(textBox_user.Text, textBox_password.Text) + "' WHERE username='" + textBox_user.Text + "'";
                    SqlCommand command2 = new SqlCommand(modifyQuery, dbConn.GetConnection());
                    dbConn.OpenConnection();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("User modified succesfully", "Modify information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConn.CloseConnection();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_user.Text == "" || textBox_email.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Users WHERE username='" + textBox_user.Text + "'";
                        SqlCommand command3 = new SqlCommand(deleteQuery, dbConn.GetConnection());
                        dbConn.OpenConnection();
                        command3.ExecuteNonQuery();
                        MessageBox.Show("User deleted succesfully", "Delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConn.CloseConnection();
                        getTable();
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void label5_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_category_Click(object sender, EventArgs e)
        {
            textBox_user.Text = dataGridView_Users.SelectedRows[0].Cells[3].Value.ToString();
            textBox_email.Text = dataGridView_Users.SelectedRows[0].Cells[1].Value.ToString();
            textBox_password.Text = dataGridView_Users.SelectedRows[0].Cells[2].Value.ToString();
        }


        private void clear()
        {
            textBox_user.Clear();
            textBox_email.Clear();
            textBox_password.Clear();
        }

        private void label5_exit_MouseEnter(object sender, EventArgs e)
        {
            label5_exit.ForeColor = Color.Red;
        }

        private void label5_exit_MouseLeave(object sender, EventArgs e)
        {
            label5_exit.ForeColor = Color.Green;
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Green;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_artist_Click(object sender, EventArgs e)
        {
            ArtistsForm artistsForm = new ArtistsForm();
            artistsForm.Show();
            this.Hide();
        }

        private void button_request_Click(object sender, EventArgs e)
        {
            RequestForm reqForm = new RequestForm();
            reqForm.Show();
            this.Hide();
        }

        private void button_playlists_Click(object sender, EventArgs e)
        {
            PlaylistForm playForm = new PlaylistForm();
            playForm.Show();
            this.Hide();
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

        private void button_main_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
