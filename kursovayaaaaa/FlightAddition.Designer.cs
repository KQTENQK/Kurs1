namespace kursovayaaaaa
{
    partial class FlightAddition
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
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.inputArrivalPoint = new System.Windows.Forms.TextBox();
            this.inputDeparturePoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(60, 106);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 18);
            this.password.TabIndex = 31;
            this.password.Text = "Arrival Point";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(60, 78);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(111, 18);
            this.Username.TabIndex = 30;
            this.Username.Text = "Departure Point";
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.Color.Gray;
            this.buttonAdd.Location = new System.Drawing.Point(186, 181);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // inputArrivalPoint
            // 
            this.inputArrivalPoint.Location = new System.Drawing.Point(186, 105);
            this.inputArrivalPoint.Name = "inputArrivalPoint";
            this.inputArrivalPoint.Size = new System.Drawing.Size(100, 20);
            this.inputArrivalPoint.TabIndex = 28;
            // 
            // inputDeparturePoint
            // 
            this.inputDeparturePoint.AccessibleDescription = "username";
            this.inputDeparturePoint.AccessibleName = "username";
            this.inputDeparturePoint.Location = new System.Drawing.Point(186, 79);
            this.inputDeparturePoint.Name = "inputDeparturePoint";
            this.inputDeparturePoint.Size = new System.Drawing.Size(100, 20);
            this.inputDeparturePoint.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Date time";
            // 
            // inputDateTime
            // 
            this.inputDateTime.Location = new System.Drawing.Point(186, 131);
            this.inputDateTime.Name = "inputDateTime";
            this.inputDateTime.Size = new System.Drawing.Size(100, 20);
            this.inputDateTime.TabIndex = 33;
            // 
            // FlightAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputDateTime);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.inputArrivalPoint);
            this.Controls.Add(this.inputDeparturePoint);
            this.Name = "FlightAddition";
            this.Text = "FlightAddition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox inputArrivalPoint;
        private System.Windows.Forms.TextBox inputDeparturePoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDateTime;
    }
}