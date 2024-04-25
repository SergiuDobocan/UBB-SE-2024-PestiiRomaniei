namespace ISS
{
    partial class RequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_logout = new Label();
            dataGridView_requests = new DataGridView();
            button_deny = new Button();
            button_accept = new Button();
            button_Albums = new Button();
            button_User = new Button();
            label5_exit = new Label();
            textBox_ArtistName = new TextBox();
            panel1 = new Panel();
            textBox_request_body = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            button_Songs = new Button();
            button_main = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_requests).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_logout
            // 
            label_logout.AutoSize = true;
            label_logout.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label_logout.ForeColor = Color.FromArgb(0, 192, 0);
            label_logout.Location = new Point(3, 604);
            label_logout.Name = "label_logout";
            label_logout.Size = new Size(139, 41);
            label_logout.TabIndex = 27;
            label_logout.Text = "LOGOUT";
            label_logout.Click += label_logout_Click;
            label_logout.MouseEnter += label_logout_MouseEnter;
            label_logout.MouseLeave += label_logout_MouseLeave;
            // 
            // dataGridView_requests
            // 
            dataGridView_requests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_requests.BackgroundColor = Color.Gray;
            dataGridView_requests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_requests.Location = new Point(35, 60);
            dataGridView_requests.Name = "dataGridView_requests";
            dataGridView_requests.RowHeadersWidth = 51;
            dataGridView_requests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_requests.Size = new Size(329, 503);
            dataGridView_requests.TabIndex = 16;
            dataGridView_requests.Click += dataGridView_employees_Click;
            // 
            // button_deny
            // 
            button_deny.FlatAppearance.BorderColor = Color.White;
            button_deny.FlatAppearance.BorderSize = 0;
            button_deny.FlatStyle = FlatStyle.Flat;
            button_deny.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_deny.ForeColor = Color.FromArgb(0, 192, 0);
            button_deny.Location = new Point(701, 330);
            button_deny.Name = "button_deny";
            button_deny.Size = new Size(103, 49);
            button_deny.TabIndex = 12;
            button_deny.Text = "Deny";
            button_deny.UseVisualStyleBackColor = true;
            // 
            // button_accept
            // 
            button_accept.FlatAppearance.BorderColor = Color.White;
            button_accept.FlatAppearance.BorderSize = 0;
            button_accept.FlatStyle = FlatStyle.Flat;
            button_accept.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_accept.ForeColor = Color.FromArgb(0, 192, 0);
            button_accept.Location = new Point(486, 330);
            button_accept.Name = "button_accept";
            button_accept.Size = new Size(109, 49);
            button_accept.TabIndex = 11;
            button_accept.Text = "Accept";
            button_accept.UseVisualStyleBackColor = true;
            // 
            // button_Albums
            // 
            button_Albums.FlatAppearance.BorderColor = Color.White;
            button_Albums.FlatAppearance.BorderSize = 0;
            button_Albums.FlatStyle = FlatStyle.Flat;
            button_Albums.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_Albums.ForeColor = Color.FromArgb(0, 192, 0);
            button_Albums.Location = new Point(-21, 94);
            button_Albums.Name = "button_Albums";
            button_Albums.Size = new Size(180, 49);
            button_Albums.TabIndex = 25;
            button_Albums.Text = "Albums";
            button_Albums.UseVisualStyleBackColor = true;
            button_Albums.Click += button_albums_Click;
            // 
            // button_User
            // 
            button_User.FlatAppearance.BorderColor = Color.White;
            button_User.FlatAppearance.BorderSize = 0;
            button_User.FlatStyle = FlatStyle.Flat;
            button_User.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_User.ForeColor = Color.FromArgb(0, 192, 0);
            button_User.Location = new Point(-32, 39);
            button_User.Name = "button_User";
            button_User.Size = new Size(191, 49);
            button_User.TabIndex = 24;
            button_User.Text = "User";
            button_User.UseVisualStyleBackColor = true;
            button_User.Click += button_users_Click;
            // 
            // label5_exit
            // 
            label5_exit.AutoSize = true;
            label5_exit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label5_exit.ForeColor = Color.FromArgb(0, 192, 0);
            label5_exit.Location = new Point(1067, -10);
            label5_exit.Name = "label5_exit";
            label5_exit.Size = new Size(42, 46);
            label5_exit.TabIndex = 23;
            label5_exit.Text = "X";
            label5_exit.Click += label5_exit_Click;
            label5_exit.MouseEnter += label5_exit_MouseEnter;
            label5_exit.MouseLeave += label5_exit_MouseLeave;
            // 
            // textBox_ArtistName
            // 
            textBox_ArtistName.BackColor = Color.Gray;
            textBox_ArtistName.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_ArtistName.Location = new Point(608, 70);
            textBox_ArtistName.Multiline = true;
            textBox_ArtistName.Name = "textBox_ArtistName";
            textBox_ArtistName.Size = new Size(185, 41);
            textBox_ArtistName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(textBox_request_body);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView_requests);
            panel1.Controls.Add(button_deny);
            panel1.Controls.Add(button_accept);
            panel1.Controls.Add(textBox_ArtistName);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(138, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 603);
            panel1.TabIndex = 22;
            // 
            // textBox_request_body
            // 
            textBox_request_body.BackColor = Color.Gray;
            textBox_request_body.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_request_body.Location = new Point(608, 158);
            textBox_request_body.Multiline = true;
            textBox_request_body.Name = "textBox_request_body";
            textBox_request_body.Size = new Size(297, 111);
            textBox_request_body.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(386, 166);
            label1.Name = "label1";
            label1.Size = new Size(197, 33);
            label1.TabIndex = 37;
            label1.Text = "Artist request info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(461, 70);
            label3.Name = "label3";
            label3.Size = new Size(131, 33);
            label3.TabIndex = 36;
            label3.Text = "Artist name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(86, 16);
            label7.Name = "label7";
            label7.Size = new Size(104, 33);
            label7.TabIndex = 19;
            label7.Text = "Requests";
            // 
            // button_Songs
            // 
            button_Songs.FlatAppearance.BorderColor = Color.White;
            button_Songs.FlatAppearance.BorderSize = 0;
            button_Songs.FlatStyle = FlatStyle.Flat;
            button_Songs.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_Songs.ForeColor = Color.FromArgb(0, 192, 0);
            button_Songs.Location = new Point(-21, 149);
            button_Songs.Name = "button_Songs";
            button_Songs.Size = new Size(180, 49);
            button_Songs.TabIndex = 26;
            button_Songs.Text = "Songs";
            button_Songs.UseVisualStyleBackColor = true;
            button_Songs.Click += button_artists_Click;
            // 
            // button_main
            // 
            button_main.FlatAppearance.BorderColor = Color.White;
            button_main.FlatAppearance.BorderSize = 0;
            button_main.FlatStyle = FlatStyle.Flat;
            button_main.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_main.ForeColor = Color.FromArgb(0, 192, 0);
            button_main.Location = new Point(-11, 200);
            button_main.Name = "button_main";
            button_main.Size = new Size(153, 107);
            button_main.TabIndex = 28;
            button_main.Text = "Main menu";
            button_main.UseVisualStyleBackColor = true;
            button_main.Click += button_main_Click;
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1100, 650);
            Controls.Add(button_main);
            Controls.Add(label_logout);
            Controls.Add(button_Albums);
            Controls.Add(button_User);
            Controls.Add(label5_exit);
            Controls.Add(panel1);
            Controls.Add(button_Songs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RequestForm";
            Load += RequestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_requests).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_logout;
        private DataGridView dataGridView_requests;
        private Label label6;
        private Button button_deny;
        private Button button_accept;
        private TextBox textBox_description;
        private Button button_Albums;
        private Button button_User;
        private Label label5_exit;
        private TextBox textBox_country;
        private TextBox textBox_email;
        private TextBox textBox_ArtistName;
        private Panel panel1;
        private Button button_Songs;
        private Label label7;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button_addArtist;
        private TextBox textBox_id;
        private TextBox textBox_request_body;
        private Button button_main;
    }
}