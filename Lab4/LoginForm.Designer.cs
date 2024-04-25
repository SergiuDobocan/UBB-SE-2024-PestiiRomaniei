namespace ISS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3_login = new Label();
            Button_login = new Guna.UI2.WinForms.Guna2Button();
            label4_clear = new Label();
            label5_exit = new Label();
            textBox_email = new TextBox();
            textBox_password = new TextBox();
            label1 = new Label();
            label3 = new Label();
            Button_loginA = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label3_login
            // 
            label3_login.AutoSize = true;
            label3_login.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label3_login.ForeColor = Color.FromArgb(0, 192, 0);
            label3_login.Location = new Point(269, 9);
            label3_login.Name = "label3_login";
            label3_login.Size = new Size(110, 46);
            label3_login.TabIndex = 3;
            label3_login.Text = "Login";
            // 
            // Button_login
            // 
            Button_login.BorderRadius = 18;
            Button_login.CustomBorderColor = Color.FromArgb(0, 192, 0);
            Button_login.CustomizableEdges = customizableEdges1;
            Button_login.DisabledState.BorderColor = Color.DarkGray;
            Button_login.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_login.FillColor = Color.Gray;
            Button_login.Font = new Font("Segoe UI", 12F);
            Button_login.ForeColor = Color.FromArgb(0, 192, 0);
            Button_login.Location = new Point(353, 226);
            Button_login.Name = "Button_login";
            Button_login.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_login.Size = new Size(156, 42);
            Button_login.TabIndex = 6;
            Button_login.Text = "LOGIN";
            Button_login.Click += Button_login_Click;
            // 
            // label4_clear
            // 
            label4_clear.AutoSize = true;
            label4_clear.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            label4_clear.ForeColor = Color.FromArgb(0, 192, 0);
            label4_clear.Location = new Point(171, 227);
            label4_clear.Name = "label4_clear";
            label4_clear.Size = new Size(89, 41);
            label4_clear.TabIndex = 7;
            label4_clear.Text = "Clear";
            label4_clear.Click += label4_Click;
            label4_clear.MouseEnter += label4_clear_MouseEnter;
            label4_clear.MouseLeave += label4_clear_MouseLeave;
            // 
            // label5_exit
            // 
            label5_exit.AutoSize = true;
            label5_exit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label5_exit.ForeColor = Color.FromArgb(0, 192, 0);
            label5_exit.Location = new Point(612, -8);
            label5_exit.Name = "label5_exit";
            label5_exit.Size = new Size(42, 46);
            label5_exit.TabIndex = 8;
            label5_exit.Text = "X";
            label5_exit.Click += label5_exit_Click;
            label5_exit.MouseEnter += label5_exit_MouseEnter;
            label5_exit.MouseLeave += label5_exit_MouseLeave;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.Gray;
            textBox_email.BorderStyle = BorderStyle.FixedSingle;
            textBox_email.Font = new Font("Segoe UI", 13.8F);
            textBox_email.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_email.Location = new Point(280, 91);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(200, 38);
            textBox_email.TabIndex = 10;
            //textBox_email.TextChanged += textBox_user_TextChanged;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.Gray;
            textBox_password.BorderStyle = BorderStyle.FixedSingle;
            textBox_password.Font = new Font("Segoe UI", 13.8F);
            textBox_password.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_password.Location = new Point(280, 152);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(200, 38);
            textBox_password.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(188, 88);
            label1.Name = "label1";
            label1.Size = new Size(86, 37);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(144, 150);
            label3.Name = "label3";
            label3.Size = new Size(130, 37);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // Button_loginA
            // 
            Button_loginA.BorderRadius = 18;
            Button_loginA.CustomBorderColor = Color.FromArgb(0, 192, 0);
            Button_loginA.CustomizableEdges = customizableEdges3;
            Button_loginA.DisabledState.BorderColor = Color.DarkGray;
            Button_loginA.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_loginA.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_loginA.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_loginA.FillColor = Color.Gray;
            Button_loginA.Font = new Font("Segoe UI", 12F);
            Button_loginA.ForeColor = Color.FromArgb(0, 192, 0);
            Button_loginA.Location = new Point(188, 305);
            Button_loginA.Name = "Button_loginA";
            Button_loginA.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_loginA.Size = new Size(287, 63);
            Button_loginA.TabIndex = 20;
            Button_loginA.Text = "DON'T HAVE AN ACCOUNT? REGISTER";
            Button_loginA.Click += Button_loginA_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(650, 400);
            Controls.Add(Button_loginA);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_email);
            Controls.Add(label5_exit);
            Controls.Add(label4_clear);
            Controls.Add(Button_login);
            Controls.Add(label3_login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3_login;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private Label label4_clear;
        private Label label5_exit;
        private TextBox textBox_email;
        private TextBox textBox_password;
        private Label label1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button Button_loginA;
    }
}