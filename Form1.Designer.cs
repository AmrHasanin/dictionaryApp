namespace DIgitalDictionary
{
    partial class Form1
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
            panel1 = new Panel();
            SignUpButton = new Button();
            LoginButton = new Button();
            SignUpPanel = new Panel();
            label5 = new Label();
            NameBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            SubmitSignUpButton = new Button();
            SignUpPassword = new TextBox();
            SIngUpUsername = new TextBox();
            LoginPanel = new Panel();
            SubmitLoginButton = new Button();
            LoginPassword = new TextBox();
            LoginUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SignUpPanel.SuspendLayout();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(SignUpButton);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 450);
            panel1.TabIndex = 0;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.DeepSkyBlue;
            SignUpButton.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpButton.ForeColor = SystemColors.ButtonHighlight;
            SignUpButton.Location = new Point(3, 142);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(140, 69);
            SignUpButton.TabIndex = 1;
            SignUpButton.Text = "SIGNUP";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DeepSkyBlue;
            LoginButton.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.ButtonHighlight;
            LoginButton.Location = new Point(3, 51);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(140, 71);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignUpPanel
            // 
            SignUpPanel.BackColor = SystemColors.ActiveCaptionText;
            SignUpPanel.Controls.Add(label5);
            SignUpPanel.Controls.Add(NameBox);
            SignUpPanel.Controls.Add(label4);
            SignUpPanel.Controls.Add(label3);
            SignUpPanel.Controls.Add(SubmitSignUpButton);
            SignUpPanel.Controls.Add(SignUpPassword);
            SignUpPanel.Controls.Add(SIngUpUsername);
            SignUpPanel.Location = new Point(149, 0);
            SignUpPanel.Name = "SignUpPanel";
            SignUpPanel.Size = new Size(658, 450);
            SignUpPanel.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(170, 54);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 6;
            label5.Text = "Name";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(283, 51);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(235, 31);
            NameBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(166, 194);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(162, 125);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // SubmitSignUpButton
            // 
            SubmitSignUpButton.BackColor = Color.DeepSkyBlue;
            SubmitSignUpButton.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitSignUpButton.ForeColor = SystemColors.ControlLightLight;
            SubmitSignUpButton.Location = new Point(283, 266);
            SubmitSignUpButton.Name = "SubmitSignUpButton";
            SubmitSignUpButton.Size = new Size(190, 81);
            SubmitSignUpButton.TabIndex = 2;
            SubmitSignUpButton.Text = "SIGNUP";
            SubmitSignUpButton.UseVisualStyleBackColor = false;
            SubmitSignUpButton.Click += SubmitSignUpButton_Click;
            // 
            // SignUpPassword
            // 
            SignUpPassword.Location = new Point(283, 191);
            SignUpPassword.Name = "SignUpPassword";
            SignUpPassword.Size = new Size(235, 31);
            SignUpPassword.TabIndex = 1;
            // 
            // SIngUpUsername
            // 
            SIngUpUsername.Location = new Point(283, 122);
            SIngUpUsername.Name = "SIngUpUsername";
            SIngUpUsername.Size = new Size(235, 31);
            SIngUpUsername.TabIndex = 0;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = SystemColors.ActiveCaptionText;
            LoginPanel.Controls.Add(SubmitLoginButton);
            LoginPanel.Controls.Add(LoginPassword);
            LoginPanel.Controls.Add(LoginUserName);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Location = new Point(149, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(647, 450);
            LoginPanel.TabIndex = 2;
            // 
            // SubmitLoginButton
            // 
            SubmitLoginButton.BackColor = Color.DeepSkyBlue;
            SubmitLoginButton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitLoginButton.ForeColor = SystemColors.ButtonHighlight;
            SubmitLoginButton.Location = new Point(267, 293);
            SubmitLoginButton.Name = "SubmitLoginButton";
            SubmitLoginButton.Size = new Size(187, 71);
            SubmitLoginButton.TabIndex = 4;
            SubmitLoginButton.Text = "Login";
            SubmitLoginButton.UseVisualStyleBackColor = false;
            SubmitLoginButton.Click += SubmitLoginButton_Click;
            // 
            // LoginPassword
            // 
            LoginPassword.Location = new Point(267, 217);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.Size = new Size(248, 31);
            LoginPassword.TabIndex = 3;
            // 
            // LoginUserName
            // 
            LoginUserName.Location = new Point(267, 128);
            LoginUserName.Name = "LoginUserName";
            LoginUserName.Size = new Size(248, 31);
            LoginUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(149, 223);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(149, 128);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(SignUpPanel);
            Controls.Add(LoginPanel);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            SignUpPanel.ResumeLayout(false);
            SignUpPanel.PerformLayout();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button SignUpButton;
        private Button LoginButton;
        private Panel SignUpPanel;
        private Panel LoginPanel;
        private TextBox LoginUserName;
        private Label label2;
        private Label label1;
        private Button SubmitLoginButton;
        private TextBox LoginPassword;
        private Button SubmitSignUpButton;
        private TextBox SignUpPassword;
        private TextBox SIngUpUsername;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox NameBox;
    }
}
