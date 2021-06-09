namespace kursovayaaaaa
{
    partial class UserPanel
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
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.listBoxTickets = new System.Windows.Forms.ListBox();
            this.listBoxFlights = new System.Windows.Forms.ListBox();
            this.buttonSearchWay = new System.Windows.Forms.Button();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.Location = new System.Drawing.Point(605, 392);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(140, 30);
            this.buttonBuyTicket.TabIndex = 10;
            this.buttonBuyTicket.Text = "Buy";
            this.buttonBuyTicket.UseVisualStyleBackColor = true;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // listBoxTickets
            // 
            this.listBoxTickets.FormattingEnabled = true;
            this.listBoxTickets.Location = new System.Drawing.Point(474, 29);
            this.listBoxTickets.Name = "listBoxTickets";
            this.listBoxTickets.Size = new System.Drawing.Size(271, 342);
            this.listBoxTickets.TabIndex = 9;
            // 
            // listBoxFlights
            // 
            this.listBoxFlights.FormattingEnabled = true;
            this.listBoxFlights.Location = new System.Drawing.Point(56, 29);
            this.listBoxFlights.Name = "listBoxFlights";
            this.listBoxFlights.Size = new System.Drawing.Size(382, 342);
            this.listBoxFlights.TabIndex = 6;
            this.listBoxFlights.SelectedIndexChanged += new System.EventHandler(this.listBoxFlights_SelectedIndexChanged);
            // 
            // buttonSearchWay
            // 
            this.buttonSearchWay.Location = new System.Drawing.Point(298, 398);
            this.buttonSearchWay.Name = "buttonSearchWay";
            this.buttonSearchWay.Size = new System.Drawing.Size(140, 30);
            this.buttonSearchWay.TabIndex = 7;
            this.buttonSearchWay.Text = "Search";
            this.buttonSearchWay.UseVisualStyleBackColor = true;
            this.buttonSearchWay.Click += new System.EventHandler(this.buttonSearchWay_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.AccessibleDescription = "username";
            this.inputSearch.AccessibleName = "username";
            this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.inputSearch.Location = new System.Drawing.Point(56, 399);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(236, 27);
            this.inputSearch.TabIndex = 21;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.buttonBuyTicket);
            this.Controls.Add(this.listBoxTickets);
            this.Controls.Add(this.buttonSearchWay);
            this.Controls.Add(this.listBoxFlights);
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPanel_FormClosed);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBuyTicket;
        private System.Windows.Forms.ListBox listBoxTickets;
        private System.Windows.Forms.ListBox listBoxFlights;
        private System.Windows.Forms.Button buttonSearchWay;
        private System.Windows.Forms.TextBox inputSearch;
    }
}