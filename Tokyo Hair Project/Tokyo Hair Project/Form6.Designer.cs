namespace Tokyo_Hair_Project
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLowLev = new System.Windows.Forms.Label();
            this.lclClubLev = new System.Windows.Forms.Label();
            this.lblUppDeck = new System.Windows.Forms.Label();
            this.lblLowRemain = new System.Windows.Forms.Label();
            this.lblClubRemain = new System.Windows.Forms.Label();
            this.lblUppRemain = new System.Windows.Forms.Label();
            this.gbGuestLookup = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtConNumber = new System.Windows.Forms.TextBox();
            this.lblConNumber = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbGuestLookup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLowLev);
            this.groupBox1.Controls.Add(this.lclClubLev);
            this.groupBox1.Controls.Add(this.lblUppDeck);
            this.groupBox1.Controls.Add(this.lblLowRemain);
            this.groupBox1.Controls.Add(this.lblClubRemain);
            this.groupBox1.Controls.Add(this.lblUppRemain);
            this.groupBox1.Location = new System.Drawing.Point(1, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seats Remaining";
            // 
            // lblLowLev
            // 
            this.lblLowLev.AutoSize = true;
            this.lblLowLev.Location = new System.Drawing.Point(42, 40);
            this.lblLowLev.Name = "lblLowLev";
            this.lblLowLev.Size = new System.Drawing.Size(193, 36);
            this.lblLowLev.TabIndex = 8;
            this.lblLowLev.Text = "Lower Level:";
            // 
            // lclClubLev
            // 
            this.lclClubLev.AutoSize = true;
            this.lclClubLev.Location = new System.Drawing.Point(286, 40);
            this.lclClubLev.Name = "lclClubLev";
            this.lclClubLev.Size = new System.Drawing.Size(172, 36);
            this.lclClubLev.TabIndex = 3;
            this.lclClubLev.Text = "Club Level:";
            // 
            // lblUppDeck
            // 
            this.lblUppDeck.AutoSize = true;
            this.lblUppDeck.Location = new System.Drawing.Point(490, 40);
            this.lblUppDeck.Name = "lblUppDeck";
            this.lblUppDeck.Size = new System.Drawing.Size(190, 36);
            this.lblUppDeck.TabIndex = 4;
            this.lblUppDeck.Text = "Upper Deck:";
            // 
            // lblLowRemain
            // 
            this.lblLowRemain.AutoSize = true;
            this.lblLowRemain.Location = new System.Drawing.Point(86, 132);
            this.lblLowRemain.Name = "lblLowRemain";
            this.lblLowRemain.Size = new System.Drawing.Size(98, 36);
            this.lblLowRemain.TabIndex = 5;
            this.lblLowRemain.Text = "label4";
            this.lblLowRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClubRemain
            // 
            this.lblClubRemain.AutoSize = true;
            this.lblClubRemain.Location = new System.Drawing.Point(318, 132);
            this.lblClubRemain.Name = "lblClubRemain";
            this.lblClubRemain.Size = new System.Drawing.Size(98, 36);
            this.lblClubRemain.TabIndex = 6;
            this.lblClubRemain.Text = "label5";
            this.lblClubRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUppRemain
            // 
            this.lblUppRemain.AutoSize = true;
            this.lblUppRemain.Location = new System.Drawing.Point(530, 132);
            this.lblUppRemain.Name = "lblUppRemain";
            this.lblUppRemain.Size = new System.Drawing.Size(98, 36);
            this.lblUppRemain.TabIndex = 7;
            this.lblUppRemain.Text = "label6";
            this.lblUppRemain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUppRemain.Click += new System.EventHandler(this.lblUppRemain_Click);
            // 
            // gbGuestLookup
            // 
            this.gbGuestLookup.Controls.Add(this.btnFind);
            this.gbGuestLookup.Controls.Add(this.txtConNumber);
            this.gbGuestLookup.Controls.Add(this.lblConNumber);
            this.gbGuestLookup.Location = new System.Drawing.Point(745, 432);
            this.gbGuestLookup.Name = "gbGuestLookup";
            this.gbGuestLookup.Size = new System.Drawing.Size(808, 212);
            this.gbGuestLookup.TabIndex = 1;
            this.gbGuestLookup.TabStop = false;
            this.gbGuestLookup.Text = "Guest Lookup";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(279, 132);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(206, 55);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtConNumber
            // 
            this.txtConNumber.Location = new System.Drawing.Point(459, 64);
            this.txtConNumber.Name = "txtConNumber";
            this.txtConNumber.Size = new System.Drawing.Size(263, 44);
            this.txtConNumber.TabIndex = 9;
            // 
            // lblConNumber
            // 
            this.lblConNumber.AutoSize = true;
            this.lblConNumber.Location = new System.Drawing.Point(34, 72);
            this.lblConNumber.Name = "lblConNumber";
            this.lblConNumber.Size = new System.Drawing.Size(327, 36);
            this.lblConNumber.TabIndex = 8;
            this.lblConNumber.Text = "Confirmation Number:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSales.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSales.Location = new System.Drawing.Point(27, 12);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(98, 36);
            this.lblTotalSales.TabIndex = 2;
            this.lblTotalSales.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1356, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(179, 75);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Email,
            this.Cost,
            this.purchCode,
            this.LL,
            this.CL,
            this.UD});
            this.dataGridView1.Location = new System.Drawing.Point(5, 650);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1552, 619);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Names
            // 
            this.Names.HeaderText = "Customer";
            this.Names.MinimumWidth = 10;
            this.Names.Name = "Names";
            this.Names.Width = 200;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 10;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Total Cost";
            this.Cost.MinimumWidth = 10;
            this.Cost.Name = "Cost";
            this.Cost.Width = 200;
            // 
            // purchCode
            // 
            this.purchCode.HeaderText = "Confirmation Code";
            this.purchCode.MinimumWidth = 10;
            this.purchCode.Name = "purchCode";
            this.purchCode.Width = 200;
            // 
            // LL
            // 
            this.LL.HeaderText = "Lower Level";
            this.LL.MinimumWidth = 10;
            this.LL.Name = "LL";
            this.LL.Width = 200;
            // 
            // CL
            // 
            this.CL.HeaderText = "Club Level";
            this.CL.MinimumWidth = 10;
            this.CL.Name = "CL";
            this.CL.Width = 200;
            // 
            // UD
            // 
            this.UD.HeaderText = "Upper Deck";
            this.UD.MinimumWidth = 10;
            this.UD.Name = "UD";
            this.UD.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1557, 1269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 1269);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.gbGuestLookup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbGuestLookup.ResumeLayout(false);
            this.gbGuestLookup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLowLev;
        private System.Windows.Forms.Label lclClubLev;
        private System.Windows.Forms.Label lblUppDeck;
        private System.Windows.Forms.Label lblLowRemain;
        private System.Windows.Forms.Label lblClubRemain;
        private System.Windows.Forms.Label lblUppRemain;
        private System.Windows.Forms.GroupBox gbGuestLookup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtConNumber;
        private System.Windows.Forms.Label lblConNumber;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn UD;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}