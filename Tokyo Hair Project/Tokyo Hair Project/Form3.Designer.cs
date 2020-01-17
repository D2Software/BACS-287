namespace Tokyo_Hair_Project
{
    partial class tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tickets));
            this.lblLowerLevel = new System.Windows.Forms.Label();
            this.lblClubLevel = new System.Windows.Forms.Label();
            this.lblUpperDeck = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.cbUpperDeck = new System.Windows.Forms.ComboBox();
            this.cbClubLevel = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.cbLowerLevel = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLowerLevel
            // 
            this.lblLowerLevel.AutoSize = true;
            this.lblLowerLevel.Location = new System.Drawing.Point(29, 127);
            this.lblLowerLevel.Name = "lblLowerLevel";
            this.lblLowerLevel.Size = new System.Drawing.Size(417, 41);
            this.lblLowerLevel.TabIndex = 0;
            this.lblLowerLevel.Text = "Lower Level: $125.00";
            // 
            // lblClubLevel
            // 
            this.lblClubLevel.AutoSize = true;
            this.lblClubLevel.Location = new System.Drawing.Point(89, 218);
            this.lblClubLevel.Name = "lblClubLevel";
            this.lblClubLevel.Size = new System.Drawing.Size(357, 41);
            this.lblClubLevel.TabIndex = 1;
            this.lblClubLevel.Text = "Club Level: $75.00";
            // 
            // lblUpperDeck
            // 
            this.lblUpperDeck.AutoSize = true;
            this.lblUpperDeck.Location = new System.Drawing.Point(67, 306);
            this.lblUpperDeck.Name = "lblUpperDeck";
            this.lblUpperDeck.Size = new System.Drawing.Size(379, 41);
            this.lblUpperDeck.TabIndex = 2;
            this.lblUpperDeck.Text = "Upper Deck: $50.00";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTotal);
            this.groupBox1.Controls.Add(this.cbUpperDeck);
            this.groupBox1.Controls.Add(this.cbClubLevel);
            this.groupBox1.Controls.Add(this.btnBuy);
            this.groupBox1.Controls.Add(this.cbLowerLevel);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblLowerLevel);
            this.groupBox1.Controls.Add(this.lblUpperDeck);
            this.groupBox1.Controls.Add(this.lblClubLevel);
            this.groupBox1.Location = new System.Drawing.Point(485, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 504);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket selection";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(434, 365);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(223, 99);
            this.btnTotal.TabIndex = 11;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cbUpperDeck
            // 
            this.cbUpperDeck.FormattingEnabled = true;
            this.cbUpperDeck.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbUpperDeck.Location = new System.Drawing.Point(468, 298);
            this.cbUpperDeck.Name = "cbUpperDeck";
            this.cbUpperDeck.Size = new System.Drawing.Size(189, 49);
            this.cbUpperDeck.TabIndex = 10;
            this.cbUpperDeck.Text = "0";
            this.cbUpperDeck.SelectedIndexChanged += new System.EventHandler(this.cbUpperDeck_SelectedIndexChanged);
            // 
            // cbClubLevel
            // 
            this.cbClubLevel.FormattingEnabled = true;
            this.cbClubLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbClubLevel.Location = new System.Drawing.Point(468, 210);
            this.cbClubLevel.Name = "cbClubLevel";
            this.cbClubLevel.Size = new System.Drawing.Size(189, 49);
            this.cbClubLevel.TabIndex = 9;
            this.cbClubLevel.Text = "0";
            this.cbClubLevel.SelectedIndexChanged += new System.EventHandler(this.cbClubLevel_SelectedIndexChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(124, 365);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(223, 99);
            this.btnBuy.TabIndex = 8;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // cbLowerLevel
            // 
            this.cbLowerLevel.FormattingEnabled = true;
            this.cbLowerLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbLowerLevel.Location = new System.Drawing.Point(468, 119);
            this.cbLowerLevel.Name = "cbLowerLevel";
            this.cbLowerLevel.Size = new System.Drawing.Size(189, 49);
            this.cbLowerLevel.TabIndex = 5;
            this.cbLowerLevel.Text = "0";
            this.cbLowerLevel.SelectedIndexChanged += new System.EventHandler(this.CbLowerLevel_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(478, 60);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(179, 41);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(223, 99);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1659, 847);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 847);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tickets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblLowerLevel;
        public System.Windows.Forms.Label lblClubLevel;
        public System.Windows.Forms.Label lblUpperDeck;
        public System.Windows.Forms.ComboBox cbLowerLevel;
        public System.Windows.Forms.ComboBox cbUpperDeck;
        public System.Windows.Forms.ComboBox cbClubLevel;
    }
}