namespace ISS
{
    partial class MainForm
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
            button_Artists = new Button();
            button_Users = new Button();
            label5_exit = new Label();
            button_Requests = new Button();
            labelExit = new Label();
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
            // 
            // button_Artists
            // 
            button_Artists.FlatAppearance.BorderColor = Color.White;
            button_Artists.FlatAppearance.BorderSize = 0;
            button_Artists.FlatStyle = FlatStyle.Flat;
            button_Artists.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_Artists.ForeColor = Color.FromArgb(0, 192, 0);
            button_Artists.Location = new Point(229, 164);
            button_Artists.Name = "button_Artists";
            button_Artists.Size = new Size(180, 49);
            button_Artists.TabIndex = 25;
            button_Artists.Text = "Artists";
            button_Artists.UseVisualStyleBackColor = true;
            button_Artists.Click += button_Artists_Click;
            // 
            // button_Users
            // 
            button_Users.FlatAppearance.BorderColor = Color.White;
            button_Users.FlatAppearance.BorderSize = 0;
            button_Users.FlatStyle = FlatStyle.Flat;
            button_Users.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_Users.ForeColor = Color.FromArgb(0, 192, 0);
            button_Users.Location = new Point(218, 84);
            button_Users.Name = "button_Users";
            button_Users.Size = new Size(191, 49);
            button_Users.TabIndex = 24;
            button_Users.Text = "Users";
            button_Users.UseVisualStyleBackColor = true;
            button_Users.Click += button_Users_Click;
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
            // 
            // button_Requests
            // 
            button_Requests.FlatAppearance.BorderColor = Color.White;
            button_Requests.FlatAppearance.BorderSize = 0;
            button_Requests.FlatStyle = FlatStyle.Flat;
            button_Requests.Font = new Font("Sitka Display", 18F, FontStyle.Bold);
            button_Requests.ForeColor = Color.FromArgb(0, 192, 0);
            button_Requests.Location = new Point(229, 245);
            button_Requests.Name = "button_Requests";
            button_Requests.Size = new Size(180, 49);
            button_Requests.TabIndex = 26;
            button_Requests.Text = "Requests";
            button_Requests.UseVisualStyleBackColor = true;
            button_Requests.Click += button_Requests_Click;
            // 
            // labelExit
            // 
            labelExit.AutoSize = true;
            labelExit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            labelExit.ForeColor = Color.FromArgb(0, 192, 0);
            labelExit.Location = new Point(614, -8);
            labelExit.Name = "labelExit";
            labelExit.Size = new Size(42, 46);
            labelExit.TabIndex = 28;
            labelExit.Text = "X";
            labelExit.Click += labelExit_Click;
            labelExit.MouseEnter += labelExit_MouseEnter;
            labelExit.MouseLeave += labelExit_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(650, 400);
            Controls.Add(labelExit);
            Controls.Add(label_logout);
            Controls.Add(button_Artists);
            Controls.Add(button_Users);
            Controls.Add(label5_exit);
            Controls.Add(button_Requests);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_logout;
        private Button button_Artists;
        private Button button_Users;
        private Label label5_exit;
        private Button button_Requests;
        private Label labelExit;
    }
}