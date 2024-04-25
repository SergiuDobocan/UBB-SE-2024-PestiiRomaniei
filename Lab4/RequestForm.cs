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
    public partial class RequestForm : Form
    {
        DBConnect dbConn = new DBConnect();
        public RequestForm()
        {
            InitializeComponent();
        }

        private void getTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Requests";
                SqlCommand command = new SqlCommand(selectQuery, dbConn.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView_requests.DataSource = dt;
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

        private void button_albums_Click(object sender, EventArgs e)
        {
            AlbumsForm albumsForm = new AlbumsForm();
            albumsForm.Show();
            this.Hide();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void dataGridView_employees_Click(object sender, EventArgs e)
        {
            textBox_request_body.Text = dataGridView_requests.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button_artists_Click(object sender, EventArgs e)
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
