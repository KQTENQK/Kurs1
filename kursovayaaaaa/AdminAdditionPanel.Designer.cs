namespace kursovayaaaaa
{
    partial class AdminAdditionPanel
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
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputUserType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.ForeColor = System.Drawing.Color.DimGray;
            this.buttonSignUp.Location = new System.Drawing.Point(337, 302);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(100, 23);
            this.buttonSignUp.TabIndex = 39;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(316, 113);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(138, 68);
            this.titleLabel.TabIndex = 38;
            this.titleLabel.Text = "Sign Up";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(254, 239);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 18);
            this.password.TabIndex = 37;
            this.password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(254, 213);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 18);
            this.Username.TabIndex = 36;
            this.Username.Text = "Username";
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(337, 239);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(100, 20);
            this.inputPassword.TabIndex = 35;
            // 
            // inputUsername
            // 
            this.inputUsername.AccessibleDescription = "username";
            this.inputUsername.AccessibleName = "username";
            this.inputUsername.Location = new System.Drawing.Point(337, 213);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(100, 20);
            this.inputUsername.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "User Type";
            // 
            // inputUserType
            // 
            this.inputUserType.Location = new System.Drawing.Point(337, 265);
            this.inputUserType.Name = "inputUserType";
            this.inputUserType.Size = new System.Drawing.Size(100, 20);
            this.inputUserType.TabIndex = 40;
            // 
            // AdminAdditionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputUserType);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Name = "AdminAdditionPanel";
            this.Text = "AdminAdditionPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputUserType;
    }
}