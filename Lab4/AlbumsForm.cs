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
    public partial class AlbumsForm : Form
    {
        DBConnect dbConn = new DBConnect();
        public AlbumsForm()
        {
            InitializeComponent();
        }

        private void getTable1()
        {
            try
            {
                string selectQuery = "SELECT * FROM Album";
                SqlCommand command = new SqlCommand(selectQuery, dbConn.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewAlbums.DataSource = dt;
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
                string selectQuery = "SELECT * FROM AlbumSongs";
                SqlCommand command = new SqlCommand(selectQuery, dbConn.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewSongsList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            textBox_album_name.Clear();
            textBox_description.Clear();

        }

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


        private void AlbumsForm_Load(object sender, EventArgs e)
        {
            getTable1();
            getTable2();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_album_name.Text == "" || textBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if ((MessageBox.Show("Are you sure you want to delete this album?", "Delete album", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        string deleteQuery = "DELETE FROM Album WHERE album_name='" + textBox_album_name.Text + "'";
                        SqlCommand command3 = new SqlCommand(deleteQuery, dbConn.GetConnection());
                        dbConn.OpenConnection();
                        command3.ExecuteNonQuery();
                        MessageBox.Show("Album deleted succesfully", "Delete information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dbConn.CloseConnection();
                        getTable1();
                        clear();
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

        private void button_users_Click(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm();
            userForm.Show();
            this.Hide();
        }

        private void button_artists_Click(object sender, EventArgs e)
        {
            ArtistsForm artForm = new ArtistsForm();
            artForm.Show();
            this.Hide();
        }

        private void button_Songs_Click(object sender, EventArgs e)
        {
            SongsForm songForm = new SongsForm();
            songForm.Show();
            this.Hide();
        }

        private void butonModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_album_name.Text == "" || textBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Album SET Description='" + textBox_description.Text + "' WHERE album_name='" + textBox_album_name.Text + "'";
                    SqlCommand command2 = new SqlCommand(updateQuery, dbConn.GetConnection());
                    dbConn.OpenConnection();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Artist status updated succesfully", "Update information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbConn.CloseConnection();
                    getTable1();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewAlbums_Click(object sender, EventArgs e)
        {
            textBox_description.Text = dataGridViewAlbums.SelectedRows[0].Cells[2].Value.ToString();
            textBox_album_name.Text = dataGridViewAlbums.SelectedRows[0].Cells[4].Value.ToString();
            // Display image if ImagePath is not null
            string imagePath = dataGridViewAlbums.SelectedRows[0].Cells["albumpicture"].Value.ToString();
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string imageName = Path.GetFileName(fileName);

                string uploadFolderPath = @"C:\Users"; // Specify your upload folder path
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
                string imagePath = Path.Combine(uploadFolderPath, uniqueFileName);

                File.Copy(fileName, imagePath); // Copy the file to the upload folder

                // Update image path in database
                int selectedAlbumID = Convert.ToInt32(dataGridViewAlbums.SelectedRows[0].Cells["album_id"].Value);
                UpdateImagePath(selectedAlbumID, imagePath);

                // Update UI
                pictureBox.Image = Image.FromFile(imagePath);
                MessageBox.Show("Image uploaded successfully!");
            }
        }

        private void UpdateImagePath(int albumID, string imagePath)
        {
            try
            {
                string updateQuery = "UPDATE Album SET albumpicture = @ImagePath WHERE album_id = @albumID";
                SqlCommand command = new SqlCommand(updateQuery, dbConn.GetConnection());
                command.Parameters.AddWithValue("@ImagePath", imagePath);
                command.Parameters.AddWithValue("@albumID", albumID);

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
