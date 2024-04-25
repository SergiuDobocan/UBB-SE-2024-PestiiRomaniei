namespace ISS
{
    partial class RegistrationForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox_emailR = new TextBox();
            labelEmailR = new Label();
            label = new Label();
            textBox_userR = new TextBox();
            label3 = new Label();
            textBox_passwordR = new TextBox();
            label4 = new Label();
            textBox_passwordCR = new TextBox();
            Button_loginA = new Guna.UI2.WinForms.Guna2Button();
            Button_register = new Guna.UI2.WinForms.Guna2Button();
            label_clear = new Label();
            label_exit = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 22.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(219, 53);
            label1.TabIndex = 1;
            label1.Text = "Registration";
            // 
            // textBox_emailR
            // 
            textBox_emailR.BackColor = Color.Gray;
            textBox_emailR.BorderStyle = BorderStyle.FixedSingle;
            textBox_emailR.Font = new Font("Segoe UI", 13.8F);
            textBox_emailR.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_emailR.Location = new Point(294, 88);
            textBox_emailR.Name = "textBox_emailR";
            textBox_emailR.Size = new Size(200, 38);
            textBox_emailR.TabIndex = 11;
            // 
            // labelEmailR
            // 
            labelEmailR.AutoSize = true;
            labelEmailR.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            labelEmailR.ForeColor = Color.FromArgb(0, 192, 0);
            labelEmailR.Location = new Point(132, 85);
            labelEmailR.Name = "labelEmailR";
            labelEmailR.Size = new Size(156, 37);
            labelEmailR.TabIndex = 12;
            labelEmailR.Text = "Enter email";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label.ForeColor = Color.FromArgb(0, 192, 0);
            label.Location = new Point(81, 138);
            label.Name = "label";
            label.Size = new Size(207, 37);
            label.TabIndex = 14;
            label.Text = "Enter username";
            // 
            // textBox_userR
            // 
            textBox_userR.BackColor = Color.Gray;
            textBox_userR.BorderStyle = BorderStyle.FixedSingle;
            textBox_userR.Font = new Font("Segoe UI", 13.8F);
            textBox_userR.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_userR.Location = new Point(294, 141);
            textBox_userR.Name = "textBox_userR";
            textBox_userR.Size = new Size(200, 38);
            textBox_userR.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(81, 195);
            label3.Name = "label3";
            label3.Size = new Size(199, 37);
            label3.TabIndex = 16;
            label3.Text = "Enter password";
            // 
            // textBox_passwordR
            // 
            textBox_passwordR.BackColor = Color.Gray;
            textBox_passwordR.BorderStyle = BorderStyle.FixedSingle;
            textBox_passwordR.Font = new Font("Segoe UI", 13.8F);
            textBox_passwordR.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_passwordR.Location = new Point(294, 195);
            textBox_passwordR.Name = "textBox_passwordR";
            textBox_passwordR.Size = new Size(200, 38);
            textBox_passwordR.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(45, 249);
            label4.Name = "label4";
            label4.Size = new Size(235, 37);
            label4.TabIndex = 18;
            label4.Text = "Confirm password";
            // 
            // textBox_passwordCR
            // 
            textBox_passwordCR.BackColor = Color.Gray;
            textBox_passwordCR.BorderStyle = BorderStyle.FixedSingle;
            textBox_passwordCR.Font = new Font("Segoe UI", 13.8F);
            textBox_passwordCR.ForeColor = Color.FromArgb(0, 192, 0);
            textBox_passwordCR.Location = new Point(294, 248);
            textBox_passwordCR.Name = "textBox_passwordCR";
            textBox_passwordCR.Size = new Size(200, 38);
            textBox_passwordCR.TabIndex = 17;
            // 
            // Button_loginA
            // 
            Button_loginA.BorderRadius = 18;
            Button_loginA.CustomBorderColor = Color.FromArgb(0, 192, 0);
            Button_loginA.CustomizableEdges = customizableEdges1;
            Button_loginA.DisabledState.BorderColor = Color.DarkGray;
            Button_loginA.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_loginA.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_loginA.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_loginA.FillColor = Color.Gray;
            Button_loginA.Font = new Font("Segoe UI", 12F);
            Button_loginA.ForeColor = Color.FromArgb(0, 192, 0);
            Button_loginA.Location = new Point(31, 308);
            Button_loginA.Name = "Button_loginA";
            Button_loginA.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Button_loginA.Size = new Size(218, 68);
            Button_loginA.TabIndex = 19;
            Button_loginA.Text = "HAVE AN ACCOUNT? LOG IN";
            Button_loginA.Click += Button_loginA_Click;
            // 
            // Button_register
            // 
            Button_register.BorderRadius = 18;
            Button_register.CustomBorderColor = Color.FromArgb(0, 192, 0);
            Button_register.CustomizableEdges = customizableEdges3;
            Button_register.DisabledState.BorderColor = Color.DarkGray;
            Button_register.DisabledState.CustomBorderColor = Color.DarkGray;
            Button_register.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Button_register.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Button_register.FillColor = Color.Gray;
            Button_register.Font = new Font("Segoe UI", 12F);
            Button_register.ForeColor = Color.FromArgb(0, 192, 0);
            Button_register.Location = new Point(294, 320);
            Button_register.Name = "Button_register";
            Button_register.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Button_register.Size = new Size(183, 42);
            Button_register.TabIndex = 20;
            Button_register.Text = "REGISTER NOW";
            Button_register.Click += Button_register_Click;
            // 
            // label_clear
            // 
            label_clear.AutoSize = true;
            label_clear.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            label_clear.ForeColor = Color.FromArgb(0, 192, 0);
            label_clear.Location = new Point(519, 321);
            label_clear.Name = "label_clear";
            label_clear.Size = new Size(89, 41);
            label_clear.TabIndex = 21;
            label_clear.Text = "Clear";
            label_clear.Click += label_clear_Click;
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label_exit.ForeColor = Color.FromArgb(0, 192, 0);
            label_exit.Location = new Point(608, -2);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(42, 46);
            label_exit.TabIndex = 22;
            label_exit.Text = "X";
            label_exit.Click += label_exit_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(650, 400);
            Controls.Add(label_exit);
            Controls.Add(label_clear);
            Controls.Add(Button_register);
            Controls.Add(Button_loginA);
            Controls.Add(label4);
            Controls.Add(textBox_passwordCR);
            Controls.Add(label3);
            Controls.Add(textBox_passwordR);
            Controls.Add(label);
            Controls.Add(textBox_userR);
            Controls.Add(labelEmailR);
            Controls.Add(textBox_emailR);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox_emailR;
        private Label labelEmailR;
        private Label label;
        private TextBox textBox_userR;
        private Label label3;
        private TextBox textBox_passwordR;
        private Label label4;
        private TextBox textBox_passwordCR;
        private Guna.UI2.WinForms.Guna2Button Button_loginA;
        private Guna.UI2.WinForms.Guna2Button Button_register;
        private Label label_clear;
        private Label label_exit;
    }
}