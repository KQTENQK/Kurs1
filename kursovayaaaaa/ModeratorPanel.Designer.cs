namespace kursovayaaaaa
{
    partial class ModeratorPanel
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
            this.listBoxFlights = new System.Windows.Forms.ListBox();
            this.buttonAddFlight = new System.Windows.Forms.Button();
            this.buttonRemoveFlight = new System.Windows.Forms.Button();
            this.listBoxTickets = new System.Windows.Forms.ListBox();
            this.buttonAddTicket = new System.Windows.Forms.Button();
            this.buttonRemoveTicket = new System.Windows.Forms.Button();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxFlights
            // 
            this.listBoxFlights.FormattingEnabled = true;
            this.listBoxFlights.Location = new System.Drawing.Point(53, 30);
            this.listBoxFlights.Name = "listBoxFlights";
            this.listBoxFlights.Size = new System.Drawing.Size(298, 342);
            this.listBoxFlights.TabIndex = 0;
            this.listBoxFlights.SelectedIndexChanged += new System.EventHandler(this.listBoxFlights_SelectedIndexChanged);
            // 
            // buttonAddFlight
            // 
            this.buttonAddFlight.Location = new System.Drawing.Point(53, 393);
            this.buttonAddFlight.Name = "buttonAddFlight";
            this.buttonAddFlight.Size = new System.Drawing.Size(140, 30);
            this.buttonAddFlight.TabIndex = 1;
            this.buttonAddFlight.Text = "Add";
            this.buttonAddFlight.UseVisualStyleBackColor = true;
            this.buttonAddFlight.Click += new System.EventHandler(this.buttonAddFlight_Click);
            // 
            // buttonRemoveFlight
            // 
            this.buttonRemoveFlight.Location = new System.Drawing.Point(211, 393);
            this.buttonRemoveFlight.Name = "buttonRemoveFlight";
            this.buttonRemoveFlight.Size = new System.Drawing.Size(140, 30);
            this.buttonRemoveFlight.TabIndex = 2;
            this.buttonRemoveFlight.Text = "Remove";
            this.buttonRemoveFlight.UseVisualStyleBackColor = true;
            this.buttonRemoveFlight.Click += new System.EventHandler(this.buttonRemoveFlight_Click);
            // 
            // listBoxTickets
            // 
            this.listBoxTickets.FormattingEnabled = true;
            this.listBoxTickets.Location = new System.Drawing.Point(391, 30);
            this.listBoxTickets.Name = "listBoxTickets";
            this.listBoxTickets.Size = new System.Drawing.Size(351, 342);
            this.listBoxTickets.TabIndex = 3;
            // 
            // buttonAddTicket
            // 
            this.buttonAddTicket.Location = new System.Drawing.Point(576, 393);
            this.buttonAddTicket.Name = "buttonAddTicket";
            this.buttonAddTicket.Size = new System.Drawing.Size(80, 30);
            this.buttonAddTicket.TabIndex = 4;
            this.buttonAddTicket.Text = "Add";
            this.buttonAddTicket.UseVisualStyleBackColor = true;
            this.buttonAddTicket.Click += new System.EventHandler(this.buttonAddTicket_Click);
            // 
            // buttonRemoveTicket
            // 
            this.buttonRemoveTicket.Location = new System.Drawing.Point(662, 393);
            this.buttonRemoveTicket.Name = "buttonRemoveTicket";
            this.buttonRemoveTicket.Size = new System.Drawing.Size(80, 30);
            this.buttonRemoveTicket.TabIndex = 5;
            this.buttonRemoveTicket.Text = "Remove";
            this.buttonRemoveTicket.UseVisualStyleBackColor = true;
            this.buttonRemoveTicket.Click += new System.EventHandler(this.buttonRemoveTicket_Click);
            // 
            // inputPrice
            // 
            this.inputPrice.AccessibleDescription = "username";
            this.inputPrice.AccessibleName = "username";
            this.inputPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.inputPrice.Location = new System.Drawing.Point(391, 394);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(167, 29);
            this.inputPrice.TabIndex = 21;
            this.inputPrice.Text = "Price";
            this.inputPrice.Click += new System.EventHandler(this.inputPrice_Click);
            // 
            // ModeratorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.buttonRemoveTicket);
            this.Controls.Add(this.buttonAddTicket);
            this.Controls.Add(this.listBoxTickets);
            this.Controls.Add(this.buttonRemoveFlight);
            this.Controls.Add(this.buttonAddFlight);
            this.Controls.Add(this.listBoxFlights);
            this.Name = "ModeratorPanel";
            this.Text = "ModeratorPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModeratorPanel_FormClosed);
            this.Load += new System.EventHandler(this.ModeratorPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFlights;
        private System.Windows.Forms.Button buttonAddFlight;
        private System.Windows.Forms.Button buttonRemoveFlight;
        private System.Windows.Forms.ListBox listBoxTickets;
        private System.Windows.Forms.Button buttonAddTicket;
        private System.Windows.Forms.Button buttonRemoveTicket;
        private System.Windows.Forms.TextBox inputPrice;
    }
}