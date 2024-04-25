using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISS
{
    public partial class SongsForm : Form
    {
        DBConnect dbConn = new DBConnect();
        public SongsForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Songs";
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

        private void clear()
        {
            textBox_song_name.Clear();
            textBox_lyrics.Clear();

        }

        /*
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Songs VALUES( " + textBox_user.Text + ",'" + "', ' " + textBox_email.Text + " ','" + textBox_country.Text + "','" + textBox_description.Text + "')";
                SqlCommand command = new SqlCommand(insertQuery, dbConn.GetConnection());
                dbConn.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Song added succesfully", "Song information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label5_exit_MouseEnter(object sender, EventArgs e)
        {
            label5_exit.ForeColor = Color.Red;
        }

        private void label5_exit_MouseLeave(object sender, EventArgs e)
        {
            label5_exit.ForeColor = Color.Green;
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


        private void SongsForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void dataGridView_songs_Click(object sender, EventArgs e)
        {
            textBox_song_name.Text = dataGridView_songs.SelectedRows[0].Cells[3].Value.ToString();
            textBox_lyrics.Text = dataGridView_songs.SelectedRows[0].Cells[2].Value.ToString();
            // Display image if ImagePath is not null
            string imagePath = dataGridView_songs.SelectedRows[0].Cells["songpicture"].Value.ToString();
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_song_name.Text == "" || textBox_lyrics.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this song?", "Delete song", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Songs WHERE song_name='" + textBox_song_name.Text + "'";
                        SqlCommand command3 = new SqlCommand(deleteQuery, dbConn.GetConnection());
                        dbConn.OpenConnection();
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Song deleted succesfully", "Delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void butonModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_song_name.Text == "" || textBox_lyrics.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Songs SET lirics='" + textBox_lyrics.Text + "' WHERE song_name='" + textBox_song_name.Text + "'";
                    SqlCommand command2 = new SqlCommand(updateQuery, dbConn.GetConnection());
                    dbConn.OpenConnection();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Song updated succesfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_albums_Click(object sender, EventArgs e)
        {
            AlbumsForm albumForm = new AlbumsForm();
            albumForm.Show();
            this.Hide();
        }

        private void button_playlist_Click(object sender, EventArgs e)
        {
            PlaylistForm playlistForm = new PlaylistForm();
            playlistForm.Show();
            this.Hide();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string imageName = Path.GetFileName(fileName);

                string uploadFolderPath = @"C:\Users\raul\Desktop"; // Specify your upload folder path
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
                string imagePath = Path.Combine(uploadFolderPath, uniqueFileName);

                File.Copy(fileName, imagePath); // Copy the file to the upload folder

                // Update image path in database
                int selectedSongID = Convert.ToInt32(dataGridView_songs.SelectedRows[0].Cells["song_id"].Value);
                UpdateImagePath(selectedSongID, imagePath);

                // Update UI
                pictureBox.Image = Image.FromFile(imagePath);
                MessageBox.Show("Image uploaded successfully!");
            }
        }


        private void UpdateImagePath(int songID, string imagePath)
        {
            try
            {
                string updateQuery = "UPDATE Songs SET songpicture = @ImagePath WHERE song_id = @SongID";
                SqlCommand command = new SqlCommand(updateQuery, dbConn.GetConnection());
                command.Parameters.AddWithValue("@ImagePath", imagePath);
                command.Parameters.AddWithValue("@SongID", songID);

                dbConn.OpenConnection();
                command.ExecuteNonQuery();
                dbConn.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
