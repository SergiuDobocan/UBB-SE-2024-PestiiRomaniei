namespace ISS
{
    partial class ArtistsForm
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
            dataGridView_artists = new DataGridView();
            button_delete = new Button();
            button_modify = new Button();
            textBox_description = new TextBox();
            button_albums = new Button();
            button_user = new Button();
            label5_exit = new Label();
            textBox_name = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            textBox_country = new TextBox();
            label4 = new Label();
            textBox_social = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            button_songs = new Button();
            button_main = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_artists).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // dataGridView_artists
            // 
            dataGridView_artists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_artists.BackgroundColor = Color.Gray;
            dataGridView_artists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_artists.Location = new Point(38, 81);
            dataGridView_artists.Name = "dataGridView_artists";
            dataGridView_artists.RowHeadersWidth = 51;
            dataGridView_artists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_artists.Size = new Size(858, 249);
            dataGridView_artists.TabIndex = 16;
            dataGridView_artists.Click += dataGridView_artists_Click;
            // 
            // button_delete
            // 
            button_delete.FlatAppearance.BorderColor = Color.White;
            button_delete.FlatAppearance.BorderSize = 0;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_delete.ForeColor = Color.FromArgb(0, 192, 0);
            button_delete.Location = new Point(515, 530);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(103, 49);
            button_delete.TabIndex = 12;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_modify
            // 
            button_modify.FlatAppearance.BorderColor = Color.White;
            button_modify.FlatAppearance.BorderSize = 0;
            button_modify.FlatStyle = FlatStyle.Flat;
            button_modify.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            button_modify.ForeColor = Color.FromArgb(0, 192, 0);
            button_modify.Location = new Point(302, 530);
            button_modify.Name = "button_modify";
            button_modify.Size = new Size(109, 49);
            button_modify.TabIndex = 11;
            button_modify.Text = "Modify";
            button_modify.UseVisualStyleBackColor = true;
            button_modify.Click += button_update_Click;
            // 
            // textBox_description
            // 
            textBox_description.BackColor = Color.Gray;
            textBox_description.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_description.Location = new Point(605, 373);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(291, 121);
            textBox_description.TabIndex = 7;
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
            // textBox_name
            // 
            textBox_name.BackColor = Color.Gray;
            textBox_name.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_name.Location = new Point(246, 357);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(165, 27);
            textBox_name.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox_country);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_social);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView_artists);
            panel1.Controls.Add(button_delete);
            panel1.Controls.Add(button_modify);
            panel1.Controls.Add(textBox_description);
            panel1.Controls.Add(textBox_name);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(138, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 603);
            panel1.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(103, 461);
            label5.Name = "label5";
            label5.Size = new Size(95, 33);
            label5.TabIndex = 42;
            label5.Text = "Country";
            // 
            // textBox_country
            // 
            textBox_country.BackColor = Color.Gray;
            textBox_country.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_country.Location = new Point(246, 467);
            textBox_country.Name = "textBox_country";
            textBox_country.Size = new Size(165, 27);
            textBox_country.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(103, 408);
            label4.Name = "label4";
            label4.Size = new Size(137, 33);
            label4.TabIndex = 40;
            label4.Text = "Social media";
            // 
            // textBox_social
            // 
            textBox_social.BackColor = Color.Gray;
            textBox_social.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_social.Location = new Point(246, 414);
            textBox_social.Name = "textBox_social";
            textBox_social.Size = new Size(165, 27);
            textBox_social.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(462, 405);
            label2.Name = "label2";
            label2.Size = new Size(129, 33);
            label2.TabIndex = 38;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(125, 350);
            label3.Name = "label3";
            label3.Size = new Size(71, 33);
            label3.TabIndex = 36;
            label3.Text = "Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(159, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 62);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(53, 13);
            label7.Name = "label7";
            label7.Size = new Size(82, 33);
            label7.TabIndex = 19;
            label7.Text = "Artists";
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
            button_songs.Click += button_songs_Click;
            // 
            // button_main
            // 
            button_main.FlatAppearance.BorderColor = Color.White;
            button_main.FlatAppearance.BorderSize = 0;
            button_main.FlatStyle = FlatStyle.Flat;
            button_main.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_main.ForeColor = Color.FromArgb(0, 192, 0);
            button_main.Location = new Point(-11, 218);
            button_main.Name = "button_main";
            button_main.Size = new Size(153, 107);
            button_main.TabIndex = 29;
            button_main.Text = "Main menu";
            button_main.UseVisualStyleBackColor = true;
            button_main.Click += button_main_Click;
            // 
            // ArtistsForm
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
            Name = "ArtistsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeesForm";
            Load += EmployeesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_artists).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_logout;
        private DataGridView dataGridView_artists;
        private Button button_delete;
        private Button button_modify;
        private TextBox textBox_description;
        private Button button_albums;
        private Button button_user;
        private Label label5_exit;
        private TextBox textBox_email;
        private TextBox textBox_name;
        private Panel panel1;
        private Button button_songs;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox_social;
        private Label label5;
        private TextBox textBox_country;
        private Button button_main;
    }
}