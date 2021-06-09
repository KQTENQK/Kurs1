namespace kursovayaaaaa
{
    partial class Register
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.ForeColor = System.Drawing.Color.Gray;
            this.buttonSignUp.Location = new System.Drawing.Point(349, 302);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(100, 23);
            this.buttonSignUp.TabIndex = 26;
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
            this.titleLabel.Location = new System.Drawing.Point(328, 106);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(138, 68);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "AviaSales";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(266, 232);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 18);
            this.password.TabIndex = 24;
            this.password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(266, 206);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(77, 18);
            this.Username.TabIndex = 23;
            this.Username.Text = "Username";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.ForeColor = System.Drawing.Color.Gray;
            this.buttonLogIn.Location = new System.Drawing.Point(349, 273);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(100, 23);
            this.buttonLogIn.TabIndex = 22;
            this.buttonLogIn.Text = "Sign In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.White;
            this.inputPassword.Location = new System.Drawing.Point(349, 232);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(100, 20);
            this.inputPassword.TabIndex = 21;
            // 
            // inputUsername
            // 
            this.inputUsername.AccessibleDescription = "username";
            this.inputUsername.AccessibleName = "username";
            this.inputUsername.BackColor = System.Drawing.Color.White;
            this.inputUsername.Location = new System.Drawing.Point(349, 206);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(100, 20);
            this.inputUsername.TabIndex = 13;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Name = "Register";
            this.Text = "AviaSales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.TextBox inputUsername;
    }
}

