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
    public partial class PlaylistForm : Form
    {
        DBConnect dbConn = new DBConnect();
        public PlaylistForm()
        {
            InitializeComponent();
        }

        private void getTable1()
        {
            try
            {
                string selectQuery = "SELECT * FROM Playlists";
                SqlCommand command = new SqlCommand(selectQuery, dbConn.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_playlists.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getTable2()
        {
            try
            {
                string selectQuery = "SELECT * FROM Songplaylist";
                SqlCommand command = new SqlCommand(selectQuery, dbConn.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_songs.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button_delete_playlists_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_userID.Text == "" || textBox_name.Text == "" || textBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this playlist?", "Delete playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Playlists WHERE name='" + textBox_name.Text + "'";
                        SqlCommand command3 = new SqlCommand(deleteQuery, dbConn.GetConnection());
                        dbConn.OpenConnection();
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Playlist deleted succesfully", "Delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConn.CloseConnection();
                        getTable1();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_playlist_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_userID.Text == "" || textBox_name.Text == "" || textBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Playlists SET id_user='" + textBox_userID.Text + "', description = '" + textBox_description.Text + "' WHERE name='" + textBox_name.Text + "'";
                    SqlCommand command2 = new SqlCommand(updateQuery, dbConn.GetConnection());
                    dbConn.OpenConnection();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Playlist status updated succesfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConn.CloseConnection();
                    getTable1();

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
            label_logout.ForeColor = Color.CornflowerBlue;
        }

        private void button_albums_Click(object sender, EventArgs e)
        {
            AlbumsForm albumForm = new AlbumsForm();
            albumForm.Show();
            this.Hide();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            getTable1();
            getTable2();
        }

        private void dataGridView_playlists_Click(object sender, EventArgs e)
        {
            textBox_userID.Text = dataGridView_playlists.SelectedRows[0].Cells[1].Value.ToString();
            textBox_name.Text = dataGridView_playlists.SelectedRows[0].Cells[2].Value.ToString();
            textBox_description.Text = dataGridView_playlists.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dataGridView_songs_Click(object sender, EventArgs e)
        {
            textBox_songID.Text = dataGridView_songs.SelectedRows[0].Cells[1].Value.ToString();
            textBox_playlistID.Text = dataGridView_songs.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button_Songs_Click(object sender, EventArgs e)
        {
            SongsForm songForm = new SongsForm();
            songForm.Show();
            this.Hide();
        }

        private void button_add_playlist_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Playlists VALUES( '" + textBox_userID.Text + "', ' " + textBox_name.Text + "','" + textBox_description.Text + "')"; ;
                SqlCommand command = new SqlCommand(insertQuery, dbConn.GetConnection());
                dbConn.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Playlist added succesfully", "Playlist information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConn.CloseConnection();
                getTable1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_add_songs_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Songplaylist VALUES( '" + textBox_songID.Text + "','" + textBox_playlistID.Text + "')"; ;
                SqlCommand command = new SqlCommand(insertQuery, dbConn.GetConnection());
                dbConn.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Song in playlist added succesfully", "Song Playlist information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConn.CloseConnection();
                getTable2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modify_songs_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_songID.Text == "" || textBox_playlistID.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Songplaylist SET id_playlist='" + textBox_playlistID.Text + "' WHERE id_song='" + textBox_songID.Text + "'";
                    SqlCommand command2 = new SqlCommand(updateQuery, dbConn.GetConnection());
                    dbConn.OpenConnection();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Song in playlist status updated succesfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConn.CloseConnection();
                    getTable2();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_songs_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_songID.Text == "" || textBox_playlistID.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this song from this playlist?", "Delete playlist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Songplaylist WHERE id_song='" + textBox_songID.Text + "'";
                        SqlCommand command3 = new SqlCommand(deleteQuery, dbConn.GetConnection());
                        dbConn.OpenConnection();
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Song from playlist deleted succesfully", "Delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConn.CloseConnection();
                        getTable2();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
