namespace ISS
{
    partial class SongsForm
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
            dataGridView_songs = new DataGridView();
            label5_exit = new Label();
            panel1 = new Panel();
            btnUploadImage = new Button();
            label4 = new Label();
            label3 = new Label();
            buttonDelete = new Button();
            butonModify = new Button();
            textBox_lyrics = new TextBox();
            textBox_song_name = new TextBox();
            pictureBox = new PictureBox();
            label7 = new Label();
            button_playlist = new Button();
            button_main = new Button();
            button_users = new Button();
            button_albums = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_songs).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
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
            // dataGridView_songs
            // 
            dataGridView_songs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_songs.BackgroundColor = Color.Gray;
            dataGridView_songs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_songs.Location = new Point(41, 99);
            dataGridView_songs.Name = "dataGridView_songs";
            dataGridView_songs.RowHeadersWidth = 51;
            dataGridView_songs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_songs.Size = new Size(523, 405);
            dataGridView_songs.TabIndex = 16;
            dataGridView_songs.Click += dataGridView_songs_Click;
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
            panel1.Controls.Add(btnUploadImage);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(butonModify);
            panel1.Controls.Add(textBox_lyrics);
            panel1.Controls.Add(textBox_song_name);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView_songs);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(138, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 603);
            panel1.TabIndex = 22;
            // 
            // btnUploadImage
            // 
            btnUploadImage.FlatAppearance.BorderColor = Color.White;
            btnUploadImage.FlatAppearance.BorderSize = 0;
            btnUploadImage.FlatStyle = FlatStyle.Flat;
            btnUploadImage.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            btnUploadImage.ForeColor = Color.FromArgb(0, 192, 0);
            btnUploadImage.Location = new Point(702, 138);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(174, 49);
            btnUploadImage.TabIndex = 43;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(670, 289);
            label4.Name = "label4";
            label4.Size = new Size(73, 33);
            label4.TabIndex = 42;
            label4.Text = "Lyrics";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(672, 221);
            label3.Name = "label3";
            label3.Size = new Size(71, 33);
            label3.TabIndex = 41;
            label3.Text = "Name";
            // 
            // buttonDelete
            // 
            buttonDelete.FlatAppearance.BorderColor = Color.White;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.FromArgb(0, 192, 0);
            buttonDelete.Location = new Point(801, 428);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(103, 49);
            buttonDelete.TabIndex = 40;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // butonModify
            // 
            butonModify.FlatAppearance.BorderColor = Color.White;
            butonModify.FlatAppearance.BorderSize = 0;
            butonModify.FlatStyle = FlatStyle.Flat;
            butonModify.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            butonModify.ForeColor = Color.FromArgb(0, 192, 0);
            butonModify.Location = new Point(643, 428);
            butonModify.Name = "butonModify";
            butonModify.Size = new Size(109, 49);
            butonModify.TabIndex = 39;
            butonModify.Text = "Modify";
            butonModify.UseVisualStyleBackColor = true;
            butonModify.Click += butonModify_Click;
            // 
            // textBox_lyrics
            // 
            textBox_lyrics.BackColor = Color.Gray;
            textBox_lyrics.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_lyrics.Location = new Point(760, 289);
            textBox_lyrics.Multiline = true;
            textBox_lyrics.Name = "textBox_lyrics";
            textBox_lyrics.Size = new Size(160, 107);
            textBox_lyrics.TabIndex = 38;
            // 
            // textBox_song_name
            // 
            textBox_song_name.BackColor = Color.Gray;
            textBox_song_name.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_song_name.Location = new Point(760, 228);
            textBox_song_name.Name = "textBox_song_name";
            textBox_song_name.Size = new Size(160, 27);
            textBox_song_name.TabIndex = 37;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(702, 15);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(172, 103);
            pictureBox.TabIndex = 26;
            pictureBox.TabStop = false;
            pictureBox.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(83, 29);
            label7.Name = "label7";
            label7.Size = new Size(74, 33);
            label7.TabIndex = 19;
            label7.Text = "Songs";
            // 
            // button_playlist
            // 
            button_playlist.FlatAppearance.BorderColor = Color.White;
            button_playlist.FlatAppearance.BorderSize = 0;
            button_playlist.FlatStyle = FlatStyle.Flat;
            button_playlist.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_playlist.ForeColor = Color.FromArgb(0, 192, 0);
            button_playlist.Location = new Point(-21, 199);
            button_playlist.Name = "button_playlist";
            button_playlist.Size = new Size(180, 49);
            button_playlist.TabIndex = 26;
            button_playlist.Text = "Playlists";
            button_playlist.UseVisualStyleBackColor = true;
            button_playlist.Click += button_playlist_Click;
            // 
            // button_main
            // 
            button_main.FlatAppearance.BorderColor = Color.White;
            button_main.FlatAppearance.BorderSize = 0;
            button_main.FlatStyle = FlatStyle.Flat;
            button_main.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_main.ForeColor = Color.FromArgb(0, 192, 0);
            button_main.Location = new Point(-11, 270);
            button_main.Name = "button_main";
            button_main.Size = new Size(153, 107);
            button_main.TabIndex = 29;
            button_main.Text = "Main menu";
            button_main.UseVisualStyleBackColor = true;
            button_main.Click += button_main_Click;
            // 
            // button_users
            // 
            button_users.FlatAppearance.BorderColor = Color.White;
            button_users.FlatAppearance.BorderSize = 0;
            button_users.FlatStyle = FlatStyle.Flat;
            button_users.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_users.ForeColor = Color.FromArgb(0, 192, 0);
            button_users.Location = new Point(-21, 42);
            button_users.Name = "button_users";
            button_users.Size = new Size(180, 49);
            button_users.TabIndex = 30;
            button_users.Text = "Users";
            button_users.UseVisualStyleBackColor = true;
            button_users.Click += button_users_Click;
            // 
            // button_albums
            // 
            button_albums.FlatAppearance.BorderColor = Color.White;
            button_albums.FlatAppearance.BorderSize = 0;
            button_albums.FlatStyle = FlatStyle.Flat;
            button_albums.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_albums.ForeColor = Color.FromArgb(0, 192, 0);
            button_albums.Location = new Point(-21, 125);
            button_albums.Name = "button_albums";
            button_albums.Size = new Size(180, 49);
            button_albums.TabIndex = 31;
            button_albums.Text = "Albums";
            button_albums.UseVisualStyleBackColor = true;
            button_albums.Click += button_albums_Click;
            // 
            // SongsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1100, 650);
            Controls.Add(button_albums);
            Controls.Add(button_users);
            Controls.Add(button_main);
            Controls.Add(label_logout);
            Controls.Add(label5_exit);
            Controls.Add(panel1);
            Controls.Add(button_playlist);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SongsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SongsForm";
            Load += SongsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_songs).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_logout;
        private DataGridView dataGridView_songs;
        private Label label6;
        private Button button_category;
        private Button button_product;
        private Label label5_exit;
        private Panel panel1;
        private Button button_playlist;
        private Label label7;
        private PictureBox pictureBox;
        private Button button_main;
        private Label label4;
        private Label label3;
        private Button buttonDelete;
        private Button butonModify;
        private TextBox textBox_lyrics;
        private TextBox textBox_song_name;
        private Button button_users;
        private Button button_albums;
        private Button btnUploadImage;
    }
}