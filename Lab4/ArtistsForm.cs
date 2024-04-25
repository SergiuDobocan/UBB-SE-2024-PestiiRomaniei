using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class ArtistsForm : Form
    {
        DBConnect dbConn = new DBConnect();
        public ArtistsForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Artists";
                SqlCommand command = new SqlCommand(selectQuery, dbConn.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_artists.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            textBox_name.Clear();
            textBox_social.Clear();
            textBox_description.Clear();
            textBox_country.Clear();
        }

        /*
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Artists VALUES( " + textBox_user.Text + ",'" + "','" + textBox_description.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dbConn.GetConnection());
                dbConn.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Artist added succesfully", "Artist information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConn.CloseConnection();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_name.Text == "" || textBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this artist?", "Delete artist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Artists WHERE name='" + textBox_name.Text + "'";
                        SqlCommand command3 = new SqlCommand(deleteQuery, dbConn.GetConnection());
                        dbConn.OpenConnection();
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Artist deleted succesfully", "Delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_name.Text == "" || textBox_description.Text == "" || textBox_social.Text == "" || textBox_country.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Artists SET socialmedia='" + textBox_social.Text + "', country = '" + textBox_country.Text + "', description = '" + textBox_description.Text + "' WHERE name='" + textBox_name.Text + "'";
                    SqlCommand command2 = new SqlCommand(updateQuery, dbConn.GetConnection());
                    dbConn.OpenConnection();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Artist status updated succesfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label5_exit_MouseEnter(object sender, EventArgs e)
        {
            label5_exit.ForeColor = Color.Red;
        }

        private void label5_exit_MouseLeave(object sender, EventArgs e)
        {
            label5_exit.ForeColor = Color.CornflowerBlue;
        }

        private void label5_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_logout.ForeColor = Color.Green;
        }

        private void button_albums_Click(object sender, EventArgs e)
        {
            AlbumsForm albumsForm = new AlbumsForm();
            albumsForm.Show();
            this.Hide();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm();
            userForm.Show();
            this.Hide();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void dataGridView_artists_Click(object sender, EventArgs e)
        {
            textBox_name.Text = dataGridView_artists.SelectedRows[0].Cells[2].Value.ToString();
            textBox_country.Text = dataGridView_artists.SelectedRows[0].Cells[6].Value.ToString();
            textBox_description.Text = dataGridView_artists.SelectedRows[0].Cells[3].Value.ToString();
            textBox_social.Text = dataGridView_artists.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_songs_Click(object sender, EventArgs e)
        {
            SongsForm songsForm = new SongsForm();
            songsForm.Show();
            this.Hide();
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
