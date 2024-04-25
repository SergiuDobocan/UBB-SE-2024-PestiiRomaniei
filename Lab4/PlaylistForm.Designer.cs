namespace ISS
{
    partial class PlaylistForm
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
            dataGridView_playlists = new DataGridView();
            button_delete_playlist = new Button();
            button_modify_playlist = new Button();
            button_albums = new Button();
            button_user = new Button();
            label5_exit = new Label();
            panel1 = new Panel();
            button_add_songs = new Button();
            label6 = new Label();
            textBox_playlistID = new TextBox();
            label5 = new Label();
            textBox_songID = new TextBox();
            button_add_playlist = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox_description = new TextBox();
            textBox_name = new TextBox();
            textBox_userID = new TextBox();
            label1 = new Label();
            button_delete_songs = new Button();
            button_modify_songs = new Button();
            dataGridView_songs = new DataGridView();
            label7 = new Label();
            button_songs = new Button();
            button_main = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_playlists).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_songs).BeginInit();
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
            // dataGridView_playlists
            // 
            dataGridView_playlists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_playlists.BackgroundColor = Color.Gray;
            dataGridView_playlists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_playlists.Location = new Point(35, 60);
            dataGridView_playlists.Name = "dataGridView_playlists";
            dataGridView_playlists.RowHeadersWidth = 51;
            dataGridView_playlists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_playlists.Size = new Size(412, 305);
            dataGridView_playlists.TabIndex = 16;
            dataGridView_playlists.Click += dataGridView_playlists_Click;
            // 
            // button_delete_playlist
            // 
            button_delete_playlist.FlatAppearance.BorderColor = Color.White;
            button_delete_playlist.FlatAppearance.BorderSize = 0;
            button_delete_playlist.FlatStyle = FlatStyle.Flat;
            button_delete_playlist.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_delete_playlist.ForeColor = Color.FromArgb(0, 192, 0);
            button_delete_playlist.Location = new Point(297, 531);
            button_delete_playlist.Name = "button_delete_playlist";
            button_delete_playlist.Size = new Size(103, 49);
            button_delete_playlist.TabIndex = 12;
            button_delete_playlist.Text = "Delete";
            button_delete_playlist.UseVisualStyleBackColor = true;
            button_delete_playlist.Click += button_delete_playlists_Click;
            // 
            // button_modify_playlist
            // 
            button_modify_playlist.FlatAppearance.BorderColor = Color.White;
            button_modify_playlist.FlatAppearance.BorderSize = 0;
            button_modify_playlist.FlatStyle = FlatStyle.Flat;
            button_modify_playlist.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_modify_playlist.ForeColor = Color.FromArgb(0, 192, 0);
            button_modify_playlist.Location = new Point(156, 531);
            button_modify_playlist.Name = "button_modify_playlist";
            button_modify_playlist.Size = new Size(109, 49);
            button_modify_playlist.TabIndex = 11;
            button_modify_playlist.Text = "Modify";
            button_modify_playlist.UseVisualStyleBackColor = true;
            button_modify_playlist.Click += button_update_playlist_Click;
            // 
            // button_albums
            // 
            button_albums.FlatAppearance.BorderColor = Color.White;
            button_albums.FlatAppearance.BorderSize = 0;
            button_albums.FlatStyle = FlatStyle.Flat;
            button_albums.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_albums.ForeColor = Color.FromArgb(0, 192, 0);
            button_albums.Location = new Point(-21, 94);
            button_albums.Name = "button_albums";
            button_albums.Size = new Size(180, 49);
            button_albums.TabIndex = 25;
            button_albums.Text = "Albums";
            button_albums.UseVisualStyleBackColor = true;
            button_albums.Click += button_albums_Click;
            // 
            // button_user
            // 
            button_user.FlatAppearance.BorderColor = Color.White;
            button_user.FlatAppearance.BorderSize = 0;
            button_user.FlatStyle = FlatStyle.Flat;
            button_user.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_user.ForeColor = Color.FromArgb(0, 192, 0);
            button_user.Location = new Point(-32, 39);
            button_user.Name = "button_user";
            button_user.Size = new Size(191, 49);
            button_user.TabIndex = 24;
            button_user.Text = "User";
            button_user.UseVisualStyleBackColor = true;
            button_user.Click += button_users_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button_add_songs);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox_playlistID);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox_songID);
            panel1.Controls.Add(button_add_playlist);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_description);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(textBox_userID);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_delete_songs);
            panel1.Controls.Add(button_modify_songs);
            panel1.Controls.Add(dataGridView_songs);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView_playlists);
            panel1.Controls.Add(button_delete_playlist);
            panel1.Controls.Add(button_modify_playlist);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(138, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 603);
            panel1.TabIndex = 22;
            // 
            // button_add_songs
            // 
            button_add_songs.FlatAppearance.BorderColor = Color.White;
            button_add_songs.FlatAppearance.BorderSize = 0;
            button_add_songs.FlatStyle = FlatStyle.Flat;
            button_add_songs.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_add_songs.ForeColor = Color.FromArgb(0, 192, 0);
            button_add_songs.Location = new Point(564, 531);
            button_add_songs.Name = "button_add_songs";
            button_add_songs.Size = new Size(109, 49);
            button_add_songs.TabIndex = 42;
            button_add_songs.Text = "Add";
            button_add_songs.UseVisualStyleBackColor = true;
            button_add_songs.Click += button_add_songs_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.FromArgb(0, 192, 0);
            label6.Location = new Point(564, 458);
            label6.Name = "label6";
            label6.Size = new Size(141, 37);
            label6.TabIndex = 41;
            label6.Text = "Playlist ID";
            // 
            // textBox_playlistID
            // 
            textBox_playlistID.BackColor = Color.Gray;
            textBox_playlistID.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_playlistID.Location = new Point(717, 469);
            textBox_playlistID.Name = "textBox_playlistID";
            textBox_playlistID.Size = new Size(147, 27);
            textBox_playlistID.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(593, 394);
            label5.Name = "label5";
            label5.Size = new Size(112, 37);
            label5.TabIndex = 39;
            label5.Text = "Song ID";
            // 
            // textBox_songID
            // 
            textBox_songID.BackColor = Color.Gray;
            textBox_songID.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_songID.Location = new Point(717, 405);
            textBox_songID.Name = "textBox_songID";
            textBox_songID.Size = new Size(147, 27);
            textBox_songID.TabIndex = 38;
            // 
            // button_add_playlist
            // 
            button_add_playlist.FlatAppearance.BorderColor = Color.White;
            button_add_playlist.FlatAppearance.BorderSize = 0;
            button_add_playlist.FlatStyle = FlatStyle.Flat;
            button_add_playlist.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_add_playlist.ForeColor = Color.FromArgb(0, 192, 0);
            button_add_playlist.Location = new Point(41, 531);
            button_add_playlist.Name = "button_add_playlist";
            button_add_playlist.Size = new Size(109, 49);
            button_add_playlist.TabIndex = 37;
            button_add_playlist.Text = "Add";
            button_add_playlist.UseVisualStyleBackColor = true;
            button_add_playlist.Click += button_add_playlist_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(53, 469);
            label3.Name = "label3";
            label3.Size = new Size(155, 37);
            label3.TabIndex = 36;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(26, 420);
            label2.Name = "label2";
            label2.Size = new Size(182, 37);
            label2.TabIndex = 35;
            label2.Text = "Playlist name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(102, 374);
            label4.Name = "label4";
            label4.Size = new Size(106, 37);
            label4.TabIndex = 34;
            label4.Text = "User ID";
            // 
            // textBox_description
            // 
            textBox_description.BackColor = Color.Gray;
            textBox_description.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_description.Location = new Point(220, 480);
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(147, 27);
            textBox_description.TabIndex = 33;
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.Gray;
            textBox_name.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_name.Location = new Point(220, 430);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(147, 27);
            textBox_name.TabIndex = 32;
            // 
            // textBox_userID
            // 
            textBox_userID.BackColor = Color.Gray;
            textBox_userID.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_userID.Location = new Point(220, 385);
            textBox_userID.Name = "textBox_userID";
            textBox_userID.Size = new Size(147, 27);
            textBox_userID.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(689, 13);
            label1.Name = "label1";
            label1.Size = new Size(175, 33);
            label1.TabIndex = 30;
            label1.Text = "Songs in playlist";
            // 
            // button_delete_songs
            // 
            button_delete_songs.FlatAppearance.BorderColor = Color.White;
            button_delete_songs.FlatAppearance.BorderSize = 0;
            button_delete_songs.FlatStyle = FlatStyle.Flat;
            button_delete_songs.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_delete_songs.ForeColor = Color.FromArgb(0, 192, 0);
            button_delete_songs.Location = new Point(761, 531);
            button_delete_songs.Name = "button_delete_songs";
            button_delete_songs.Size = new Size(103, 49);
            button_delete_songs.TabIndex = 29;
            button_delete_songs.Text = "Delete";
            button_delete_songs.UseVisualStyleBackColor = true;
            button_delete_songs.Click += button_delete_songs_Click;
            // 
            // button_modify_songs
            // 
            button_modify_songs.FlatAppearance.BorderColor = Color.White;
            button_modify_songs.FlatAppearance.BorderSize = 0;
            button_modify_songs.FlatStyle = FlatStyle.Flat;
            button_modify_songs.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_modify_songs.ForeColor = Color.FromArgb(0, 192, 0);
            button_modify_songs.Location = new Point(661, 531);
            button_modify_songs.Name = "button_modify_songs";
            button_modify_songs.Size = new Size(109, 49);
            button_modify_songs.TabIndex = 28;
            button_modify_songs.Text = "Modify";
            button_modify_songs.UseVisualStyleBackColor = true;
            button_modify_songs.Click += button_modify_songs_Click;
            // 
            // dataGridView_songs
            // 
            dataGridView_songs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_songs.BackgroundColor = Color.Gray;
            dataGridView_songs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_songs.Location = new Point(544, 60);
            dataGridView_songs.Name = "dataGridView_songs";
            dataGridView_songs.RowHeadersWidth = 51;
            dataGridView_songs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_songs.Size = new Size(406, 305);
            dataGridView_songs.TabIndex = 27;
            dataGridView_songs.Click += dataGridView_songs_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(183, 13);
            label7.Name = "label7";
            label7.Size = new Size(97, 33);
            label7.TabIndex = 19;
            label7.Text = "Playlists";
            // 
            // button_songs
            // 
            button_songs.FlatAppearance.BorderColor = Color.White;
            button_songs.FlatAppearance.BorderSize = 0;
            button_songs.FlatStyle = FlatStyle.Flat;
            button_songs.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_songs.ForeColor = Color.FromArgb(0, 192, 0);
            button_songs.Location = new Point(-21, 149);
            button_songs.Name = "button_songs";
            button_songs.Size = new Size(180, 49);
            button_songs.TabIndex = 26;
            button_songs.Text = "Songs";
            button_songs.UseVisualStyleBackColor = true;
            button_songs.Click += button_Songs_Click;
            // 
            // button_main
            // 
            button_main.FlatAppearance.BorderColor = Color.White;
            button_main.FlatAppearance.BorderSize = 0;
            button_main.FlatStyle = FlatStyle.Flat;
            button_main.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_main.ForeColor = Color.FromArgb(0, 192, 0);
            button_main.Location = new Point(-11, 204);
            button_main.Name = "button_main";
            button_main.Size = new Size(153, 107);
            button_main.TabIndex = 29;
            button_main.Text = "Main menu";
            button_main.UseVisualStyleBackColor = true;
            button_main.Click += button_main_Click;
            // 
            // PlaylistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1100, 650);
            Controls.Add(button_main);
            Controls.Add(label_logout);
            Controls.Add(button_albums);
            Controls.Add(button_user);
            Controls.Add(label5_exit);
            Controls.Add(panel1);
            Controls.Add(button_songs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlaylistForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeesForm";
            Load += EmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_playlists).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_songs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_logout;
        private DataGridView dataGridView_playlists;
        private Button button_delete_playlist;
        private Button button_modify_playlist;
        private Button button_albums;
        private Button button_user;
        private Label label5_exit;
        private Panel panel1;
        private Button button_songs;
        private Label label7;
        private Label label1;
        private Button button_delete_songs;
        private Button button_modify_songs;
        private DataGridView dataGridView_songs;
        private Button button_add_playlist;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox_description;
        private TextBox textBox_name;
        private TextBox textBox_userID;
        private Button button_add_songs;
        private Label label6;
        private TextBox textBox_playlistID;
        private Label label5;
        private TextBox textBox_songID;
        private Button button_main;
    }
}