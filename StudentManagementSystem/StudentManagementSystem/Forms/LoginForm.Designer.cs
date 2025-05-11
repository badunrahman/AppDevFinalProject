namespace StudentManagementSystem
{
    partial class loginPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPageForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.incorrectInfoLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.createAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.noAccountInfoLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.frenchButton = new System.Windows.Forms.Button();
            this.lightModeButton = new System.Windows.Forms.Button();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(114, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(225, 63);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Student Management System";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginBox.Controls.Add(this.incorrectInfoLabel);
            this.loginBox.Controls.Add(this.logInButton);
            this.loginBox.Controls.Add(this.createAccountLinkLabel);
            this.loginBox.Controls.Add(this.noAccountInfoLabel);
            this.loginBox.Controls.Add(this.passwordTextBox);
            this.loginBox.Controls.Add(this.usernameTextBox);
            this.loginBox.Controls.Add(this.loginLabel);
            this.loginBox.Location = new System.Drawing.Point(28, 75);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(403, 206);
            this.loginBox.TabIndex = 1;
            this.loginBox.TabStop = false;
            // 
            // incorrectInfoLabel
            // 
            this.incorrectInfoLabel.BackColor = System.Drawing.Color.White;
            this.incorrectInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectInfoLabel.Location = new System.Drawing.Point(88, 39);
            this.incorrectInfoLabel.Name = "incorrectInfoLabel";
            this.incorrectInfoLabel.Size = new System.Drawing.Size(223, 39);
            this.incorrectInfoLabel.TabIndex = 8;
            this.incorrectInfoLabel.Text = "Incorrect username or password! Try Again!";
            this.incorrectInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.incorrectInfoLabel.Visible = false;
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(236, 164);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 36);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // createAccountLinkLabel
            // 
            this.createAccountLinkLabel.AutoSize = true;
            this.createAccountLinkLabel.Location = new System.Drawing.Point(115, 187);
            this.createAccountLinkLabel.Name = "createAccountLinkLabel";
            this.createAccountLinkLabel.Size = new System.Drawing.Size(95, 13);
            this.createAccountLinkLabel.TabIndex = 6;
            this.createAccountLinkLabel.TabStop = true;
            this.createAccountLinkLabel.Text = "Create an account";
            // 
            // noAccountInfoLabel
            // 
            this.noAccountInfoLabel.AutoSize = true;
            this.noAccountInfoLabel.Location = new System.Drawing.Point(88, 164);
            this.noAccountInfoLabel.Name = "noAccountInfoLabel";
            this.noAccountInfoLabel.Size = new System.Drawing.Size(122, 13);
            this.noAccountInfoLabel.TabIndex = 5;
            this.noAccountInfoLabel.Text = "Don\'t have an account?";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(91, 128);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(220, 22);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(91, 90);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(220, 22);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Text = "Enter your username:";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(149, 16);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(100, 23);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frenchButton
            // 
            this.frenchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frenchButton.BackgroundImage")));
            this.frenchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frenchButton.ForeColor = System.Drawing.Color.Silver;
            this.frenchButton.Location = new System.Drawing.Point(360, 12);
            this.frenchButton.Name = "frenchButton";
            this.frenchButton.Size = new System.Drawing.Size(31, 30);
            this.frenchButton.TabIndex = 2;
            this.frenchButton.UseVisualStyleBackColor = true;
            this.frenchButton.Click += new System.EventHandler(this.frenchButton_Click);
            // 
            // lightModeButton
            // 
            this.lightModeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lightModeButton.BackgroundImage")));
            this.lightModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lightModeButton.ForeColor = System.Drawing.Color.Silver;
            this.lightModeButton.Location = new System.Drawing.Point(400, 12);
            this.lightModeButton.Name = "lightModeButton";
            this.lightModeButton.Size = new System.Drawing.Size(31, 30);
            this.lightModeButton.TabIndex = 3;
            this.lightModeButton.UseVisualStyleBackColor = true;
//            this.lightModeButton.Click += new System.EventHandler(this.lightModeButton_Click);
            // 
            // loginPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(453, 300);
            this.Controls.Add(this.lightModeButton);
            this.Controls.Add(this.frenchButton);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "loginPageForm";
            this.Text = " ";
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.LinkLabel createAccountLinkLabel;
        private System.Windows.Forms.Label noAccountInfoLabel;
        private System.Windows.Forms.Button frenchButton;
        private System.Windows.Forms.Button lightModeButton;
        private System.Windows.Forms.Label incorrectInfoLabel;
    }
}

