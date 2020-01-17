using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tokyo_Hair_Project
{

    public partial class tickets : Form
    {

        //DataMover data = new DataMover();
        public DataMover dat { get; set; }

        public tickets()
        {
            /*int lowerRed = dat.GetLowerRed();
            int clubRed = dat.GetClubRed();
            int upperRed = dat.GetUpperRed();
            string lowLBL = dat.GetLowerlbl();
            string clubLBL = dat.GetClublbl();
            string upperLBL = dat.GetUpperlbl();

            if (lowerRed == 1)
            {
                ForeColor = Color.Red;
                lblLowerLevel.Text = lowLBL;
                cbLowerLevel.Visible = false;
            }
            if (clubRed == 1)
            {
                ForeColor = Color.Red;
                lblClubLevel.Text = clubLBL;
                cbClubLevel.Visible = false;
            }
            if (upperRed == 1)
            {
                ForeColor = Color.Red;
                lblUpperDeck.Text = upperLBL;
                cbUpperDeck.Visible = false;
            }*/

            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            dat.SetPurchLower(int.Parse(cbLowerLevel.Text));
            dat.SetPurchClub(int.Parse(cbClubLevel.Text));
            dat.SetPurchUpper(int.Parse(cbUpperDeck.Text));
            OpenConfirm();
        }
        public void OpenConfirm()
        {
            confirm con = new confirm();
            con.dat = dat;
            con.lblTotalCost.Text = "Total: " + (dat.GetPrintTotal());
            con.ShowDialog();
            this.Close();
        }

        private void CbLowerLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbClubLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void cbUpperDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void ClearPage()
        {
            cbUpperDeck.Text = "0";
            cbLowerLevel.Text = "0";
            cbClubLevel.Text = "0";
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            int tixPurchLower = int.Parse(cbLowerLevel.Text);
            int tixPurchClub = int.Parse(cbClubLevel.Text);
            int tixPurchUpper = int.Parse(cbUpperDeck.Text);

            dat.SetPurchLower(tixPurchLower);
            dat.SetPurchClub(tixPurchClub);
            dat.SetPurchUpper(tixPurchUpper);

            dat.PurchaseTickets();

            btnTotal.Text = "Total Cost\r\n" + (dat.printTotal);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPage();
        }
    }
}
