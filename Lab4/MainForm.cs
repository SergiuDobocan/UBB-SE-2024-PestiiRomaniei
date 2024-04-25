using System.Data;
using System.Data.SqlClient;

namespace ISS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Artists_Click(object sender, EventArgs e)
        {
            ArtistsForm artistForm = new ArtistsForm();
            artistForm.Show();
            this.Hide();
        }


        private void button_Requests_Click(object sender, EventArgs e)
        {
            RequestForm reqForm = new RequestForm();
            reqForm.Show();
            this.Hide();
        }

        private void button_Users_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Red;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Green;
        }
    }
}
