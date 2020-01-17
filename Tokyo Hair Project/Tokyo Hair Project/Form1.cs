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
    public partial class login : Form
    {
        String[] ticketTotals = File.ReadAllLines("ticket totals.txt");
        readonly String[] customers = File.ReadAllLines("customers.txt");
        DataMover dat = new DataMover();
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dat.OpenAccountCreation();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dat.SetName(txtUserName.Text);
            dat.SetPassword(txtPassword.Text);

            //CHANGE TO EMAIL FOR LOGIN ID!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            var ids = from names in customers
                      let patron = names.Split(',')
                      let ID = patron[0]
                      let age = patron[1]
                      let email = patron[2]
                      let passwords = patron[3]
                      select new { ID, age, email, passwords };

            foreach (var names in ids)
            {
                if (dat.GetName() == names.ID)
                {
                    if (dat.GetPassword() == names.passwords)
                    {
                        //dat.PlayHello();
                        dat.SetEmail(names.email);
                        tickets tix = new tickets();
                        tix.dat = dat;
                        SoldOutChecker();
                        if (true == dat.GetSoldOut1())
                        {
                            tix.lblLowerLevel.Text = "Lower Level all Sold Out";
                            tix.lblLowerLevel.ForeColor = Color.Red;
                            tix.cbLowerLevel.Visible = false;
                        }
                        if (true == dat.GetSoldOut2())
                        {
                            tix.lblClubLevel.Text = "Club Level all Sold Out";
                            tix.lblClubLevel.ForeColor = Color.Red;
                            tix.cbClubLevel.Visible = false;
                        }
                        if (true == dat.GetSoldOut3())
                        {
                            tix.lblUpperDeck.Text = "Upper Deck all Sold Out";
                            tix.lblUpperDeck.ForeColor = Color.Red;
                            tix.cbUpperDeck.Visible = false;
                        }
                        tix.ShowDialog();
                        this.Close();
                    }
                    else
                    {                       
                        MessageBox.Show("Incorrect password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect login ID");
                }
            }
        }

        private void btnAdminCheck_Click(object sender, EventArgs e)
        {
            string loginID = txtUserName.Text;
            string password = txtPassword.Text;

            if (loginID == "admin")
            {
                if(password == "BACS287")
                {
                    Admin adm = new Admin();
                    adm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect admin password.");
                }
            }
            else
            {
                MessageBox.Show("Administrative ID incorrect.");
            }
        }
        public void SoldOutChecker()
        {
            double llSeats = 0;
            double clSeats = 0;
            double udSeats = 0;

            var getSeatsQuery = from name in ticketTotals
                                let seatTotal = name.Split(',')
                                let ll = seatTotal[0]
                                let cl = seatTotal[1]
                                let ud = seatTotal[2]
                                let sales = seatTotal[3]
                                select new { ll, cl, ud, sales };

            foreach (var total in getSeatsQuery)
            {
                llSeats += double.Parse(total.ll);
                clSeats += double.Parse(total.cl);
                udSeats += double.Parse(total.ud);

            }

            double llTotal = 0;
            double clTotal = 0;
            double udTotal = 0;

            llTotal = 50 - llSeats;
            clTotal = 75 - clSeats;
            udTotal = 200 - udSeats;

            if (llTotal <= 0)
            {
                dat.SetSoldOut1(true);
            }
            if (clTotal <= 0)
            {
                dat.SetSoldOut2(true);
            }
            if (udTotal <= 0)
            {
                dat.SetSoldOut3(true);
            }

        }
    }
}
