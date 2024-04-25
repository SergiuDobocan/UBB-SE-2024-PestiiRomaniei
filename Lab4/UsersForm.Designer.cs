namespace ISS
{
    partial class UsersForm
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
            dataGridView_Users = new DataGridView();
            button_delete = new Button();
            button_modify = new Button();
            textBox_password = new TextBox();
            button_artists = new Button();
            button_requests = new Button();
            label5_exit = new Label();
            textBox_email = new TextBox();
            textBox_user = new TextBox();
            panel1 = new Panel();
            button_playlists = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label_logout = new Label();
            button_main = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Users).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Users
            // 
            dataGridView_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Users.BackgroundColor = Color.Gray;
            dataGridView_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Users.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView_Users.Location = new Point(325, 65);
            dataGridView_Users.Name = "dataGridView_Users";
            dataGridView_Users.RowHeadersWidth = 51;
            dataGridView_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Users.Size = new Size(494, 516);
            dataGridView_Users.TabIndex = 16;
            dataGridView_Users.Click += dataGridView_category_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.Gray;
            button_delete.FlatAppearance.BorderColor = Color.White;
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_delete.ForeColor = Color.FromArgb(0, 192, 0);
            button_delete.Location = new Point(180, 258);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(103, 49);
            button_delete.TabIndex = 12;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_modify
            // 
            button_modify.BackColor = Color.Gray;
            button_modify.FlatAppearance.BorderColor = Color.White;
            button_modify.FlatAppearance.BorderSize = 0;
            button_modify.FlatStyle = FlatStyle.Flat;
            button_modify.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_modify.ForeColor = Color.FromArgb(0, 192, 0);
            button_modify.Location = new Point(24, 258);
            button_modify.Name = "button_modify";
            button_modify.Size = new Size(109, 49);
            button_modify.TabIndex = 11;
            button_modify.Text = "Modify";
            button_modify.UseVisualStyleBackColor = false;
            button_modify.Click += button_modify_Click;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.Gray;
            textBox_password.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_password.Location = new Point(145, 193);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(147, 27);
            textBox_password.TabIndex = 7;
            // 
            // button_artists
            // 
            button_artists.FlatAppearance.BorderColor = Color.White;
            button_artists.FlatAppearance.BorderSize = 0;
            button_artists.FlatStyle = FlatStyle.Flat;
            button_artists.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_artists.ForeColor = Color.FromArgb(0, 192, 0);
            button_artists.Location = new Point(33, 119);
            button_artists.Name = "button_artists";
            button_artists.Size = new Size(175, 49);
            button_artists.TabIndex = 18;
            button_artists.Text = "Artists";
            button_artists.UseVisualStyleBackColor = true;
            button_artists.Click += button_artist_Click;
            // 
            // button_requests
            // 
            button_requests.FlatAppearance.BorderColor = Color.White;
            button_requests.FlatAppearance.BorderSize = 0;
            button_requests.FlatStyle = FlatStyle.Flat;
            button_requests.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_requests.ForeColor = Color.FromArgb(0, 192, 0);
            button_requests.Location = new Point(33, 44);
            button_requests.Name = "button_requests";
            button_requests.Size = new Size(198, 49);
            button_requests.TabIndex = 17;
            button_requests.Text = "Requests";
            button_requests.UseVisualStyleBackColor = true;
            button_requests.Click += button_request_Click;
            // 
            // label5_exit
            // 
            label5_exit.AutoSize = true;
            label5_exit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label5_exit.ForeColor = Color.FromArgb(0, 192, 0);
            label5_exit.Location = new Point(1059, -5);
            label5_exit.Name = "label5_exit";
            label5_exit.Size = new Size(42, 46);
            label5_exit.TabIndex = 16;
            label5_exit.Text = "X";
            label5_exit.Click += label5_exit_Click;
            label5_exit.MouseEnter += label5_exit_MouseEnter;
            label5_exit.MouseLeave += label5_exit_MouseLeave;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.Gray;
            textBox_email.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_email.Location = new Point(145, 143);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(147, 27);
            textBox_email.TabIndex = 4;
            // 
            // textBox_user
            // 
            textBox_user.BackColor = Color.Gray;
            textBox_user.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_user.Location = new Point(145, 98);
            textBox_user.Name = "textBox_user";
            textBox_user.Size = new Size(147, 27);
            textBox_user.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button_playlists);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView_Users);
            panel1.Controls.Add(button_delete);
            panel1.Controls.Add(button_modify);
            panel1.Controls.Add(textBox_password);
            panel1.Controls.Add(textBox_email);
            panel1.Controls.Add(textBox_user);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(258, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 597);
            panel1.TabIndex = 15;
            // 
            // button_playlists
            // 
            button_playlists.BackColor = Color.Gray;
            button_playlists.FlatAppearance.BorderColor = Color.White;
            button_playlists.FlatAppearance.BorderSize = 0;
            button_playlists.FlatStyle = FlatStyle.Flat;
            button_playlists.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_playlists.ForeColor = Color.FromArgb(0, 192, 0);
            button_playlists.Location = new Point(70, 354);
            button_playlists.Name = "button_playlists";
            button_playlists.Size = new Size(185, 49);
            button_playlists.TabIndex = 26;
            button_playlists.Text = "See playlists";
            button_playlists.UseVisualStyleBackColor = false;
            button_playlists.Click += button_playlists_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(3, 182);
            label3.Name = "label3";
            label3.Size = new Size(130, 37);
            label3.TabIndex = 25;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(57, 132);
            label2.Name = "label2";
            label2.Size = new Size(86, 37);
            label2.TabIndex = 24;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(3, 87);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 23;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(36, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(466, 10);
            button1.Name = "button1";
            button1.Size = new Size(198, 49);
            button1.TabIndex = 21;
            button1.Text = "Users";
            button1.UseVisualStyleBackColor = true;
            // 
            // label_logout
            // 
            label_logout.AutoSize = true;
            label_logout.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label_logout.ForeColor = Color.FromArgb(0, 192, 0);
            label_logout.Location = new Point(51, 600);
            label_logout.Name = "label_logout";
            label_logout.Size = new Size(139, 41);
            label_logout.TabIndex = 20;
            label_logout.Text = "LOGOUT";
            label_logout.Click += label_logout_Click;
            label_logout.MouseEnter += label_logout_MouseEnter;
            label_logout.MouseLeave += label_logout_MouseLeave;
            // 
            // button_main
            // 
            button_main.FlatAppearance.BorderColor = Color.White;
            button_main.FlatAppearance.BorderSize = 0;
            button_main.FlatStyle = FlatStyle.Flat;
            button_main.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_main.ForeColor = Color.FromArgb(0, 192, 0);
            button_main.Location = new Point(51, 190);
            button_main.Name = "button_main";
            button_main.Size = new Size(153, 107);
            button_main.TabIndex = 29;
            button_main.Text = "Main menu";
            button_main.UseVisualStyleBackColor = true;
            button_main.Click += button_main_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1100, 650);
            Controls.Add(button_main);
            Controls.Add(label_logout);
            Controls.Add(button_artists);
            Controls.Add(button_requests);
            Controls.Add(label5_exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsersForm";
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Users).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView_Users;
        private Button button_delete;
        private Button button_modify;
        private TextBox textBox_password;
        private Button button_artists;
        private Button button_requests;
        private Label label5_exit;
        private TextBox textBox_email;
        private TextBox textBox_user;
        private Panel panel1;
        private Label label_logout;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button_playlists;
        private Button button_main;
    }
}