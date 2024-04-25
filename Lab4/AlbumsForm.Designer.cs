namespace ISS
{
    partial class AlbumsForm
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
            textBox_description = new TextBox();
            label5_exit = new Label();
            textBox_album_name = new TextBox();
            panel1 = new Panel();
            btnUploadImage = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridViewAlbums = new DataGridView();
            label1 = new Label();
            buttonDelete = new Button();
            butonModify = new Button();
            dataGridViewSongsList = new DataGridView();
            pictureBox = new PictureBox();
            button_Songs = new Button();
            button_main = new Button();
            button_user = new Button();
            button_artists = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSongsList).BeginInit();
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
            // textBox_description
            // 
            textBox_description.BackColor = Color.Gray;
            textBox_description.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_description.Location = new Point(790, 233);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(160, 107);
            textBox_description.TabIndex = 7;
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
            // textBox_album_name
            // 
            textBox_album_name.BackColor = Color.Gray;
            textBox_album_name.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_album_name.Location = new Point(790, 172);
            textBox_album_name.Name = "textBox_album_name";
            textBox_album_name.Size = new Size(160, 27);
            textBox_album_name.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnUploadImage);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridViewAlbums);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(butonModify);
            panel1.Controls.Add(dataGridViewSongsList);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(textBox_description);
            panel1.Controls.Add(textBox_album_name);
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
            btnUploadImage.Location = new Point(817, 57);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(133, 88);
            btnUploadImage.TabIndex = 44;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(653, 233);
            label4.Name = "label4";
            label4.Size = new Size(129, 33);
            label4.TabIndex = 36;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(702, 165);
            label3.Name = "label3";
            label3.Size = new Size(71, 33);
            label3.TabIndex = 35;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(107, 13);
            label2.Name = "label2";
            label2.Size = new Size(89, 33);
            label2.TabIndex = 32;
            label2.Text = "Albums";
            // 
            // dataGridViewAlbums
            // 
            dataGridViewAlbums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlbums.BackgroundColor = Color.Gray;
            dataGridViewAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlbums.Location = new Point(37, 69);
            dataGridViewAlbums.Name = "dataGridViewAlbums";
            dataGridViewAlbums.RowHeadersWidth = 51;
            dataGridViewAlbums.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlbums.Size = new Size(597, 153);
            dataGridViewAlbums.TabIndex = 31;
            dataGridViewAlbums.Click += dataGridViewAlbums_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(107, 281);
            label1.Name = "label1";
            label1.Size = new Size(100, 33);
            label1.TabIndex = 30;
            label1.Text = "Song list";
            // 
            // buttonDelete
            // 
            buttonDelete.FlatAppearance.BorderColor = Color.White;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Sitka Display", 13.7999992F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.FromArgb(0, 192, 0);
            buttonDelete.Location = new Point(831, 372);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(103, 49);
            buttonDelete.TabIndex = 29;
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
            butonModify.Location = new Point(673, 372);
            butonModify.Name = "butonModify";
            butonModify.Size = new Size(109, 49);
            butonModify.TabIndex = 28;
            butonModify.Text = "Modify";
            butonModify.UseVisualStyleBackColor = true;
            butonModify.Click += butonModify_Click;
            // 
            // dataGridViewSongsList
            // 
            dataGridViewSongsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSongsList.BackgroundColor = Color.Gray;
            dataGridViewSongsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSongsList.Location = new Point(37, 335);
            dataGridViewSongsList.Name = "dataGridViewSongsList";
            dataGridViewSongsList.RowHeadersWidth = 51;
            dataGridViewSongsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSongsList.Size = new Size(597, 231);
            dataGridViewSongsList.TabIndex = 27;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(685, 60);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(110, 88);
            pictureBox.TabIndex = 26;
            pictureBox.TabStop = false;
            pictureBox.Tag = "";
            // 
            // button_Songs
            // 
            button_Songs.FlatAppearance.BorderColor = Color.White;
            button_Songs.FlatAppearance.BorderSize = 0;
            button_Songs.FlatStyle = FlatStyle.Flat;
            button_Songs.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_Songs.ForeColor = Color.FromArgb(0, 192, 0);
            button_Songs.Location = new Point(-21, 160);
            button_Songs.Name = "button_Songs";
            button_Songs.Size = new Size(180, 49);
            button_Songs.TabIndex = 26;
            button_Songs.Text = "Songs";
            button_Songs.UseVisualStyleBackColor = true;
            button_Songs.Click += button_Songs_Click;
            // 
            // button_main
            // 
            button_main.FlatAppearance.BorderColor = Color.White;
            button_main.FlatAppearance.BorderSize = 0;
            button_main.FlatStyle = FlatStyle.Flat;
            button_main.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_main.ForeColor = Color.FromArgb(0, 192, 0);
            button_main.Location = new Point(-11, 214);
            button_main.Name = "button_main";
            button_main.Size = new Size(153, 107);
            button_main.TabIndex = 29;
            button_main.Text = "Main menu";
            button_main.UseVisualStyleBackColor = true;
            button_main.Click += button_main_Click;
            // 
            // button_user
            // 
            button_user.FlatAppearance.BorderColor = Color.White;
            button_user.FlatAppearance.BorderSize = 0;
            button_user.FlatStyle = FlatStyle.Flat;
            button_user.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_user.ForeColor = Color.FromArgb(0, 192, 0);
            button_user.Location = new Point(-32, 44);
            button_user.Name = "button_user";
            button_user.Size = new Size(191, 49);
            button_user.TabIndex = 30;
            button_user.Text = "User";
            button_user.UseVisualStyleBackColor = true;
            button_user.Click += button_users_Click;
            // 
            // button_artists
            // 
            button_artists.FlatAppearance.BorderColor = Color.White;
            button_artists.FlatAppearance.BorderSize = 0;
            button_artists.FlatStyle = FlatStyle.Flat;
            button_artists.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_artists.ForeColor = Color.FromArgb(0, 192, 0);
            button_artists.Location = new Point(-32, 99);
            button_artists.Name = "button_artists";
            button_artists.Size = new Size(191, 49);
            button_artists.TabIndex = 31;
            button_artists.Text = "Artists";
            button_artists.UseVisualStyleBackColor = true;
            button_artists.Click += button_artists_Click;
            // 
            // AlbumsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1100, 650);
            Controls.Add(button_artists);
            Controls.Add(button_user);
            Controls.Add(button_main);
            Controls.Add(label_logout);
            Controls.Add(label5_exit);
            Controls.Add(panel1);
            Controls.Add(button_Songs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlbumsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlbumsForm";
            Load += AlbumsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlbums).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSongsList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_logout;
        private Label label6;
        private TextBox textBox_description;
        private Button button_category;
        private Button button_product;
        private Label label5_exit;
        private TextBox textBox_album_name;
        private Panel panel1;
        private Button button_Songs;
        private PictureBox pictureBox;
        private Label label2;
        private DataGridView dataGridViewAlbums;
        private Label label1;
        private Button buttonDelete;
        private Button butonModify;
        private DataGridView dataGridViewSongsList;
        private Label label3;
        private Label label4;
        private Button button_main;
        private Button button_user;
        private Button button_artists;
        private Button btnUploadImage;
    }
}