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
using System.Data.SqlClient;

namespace Tokyo_Hair_Project
{
    public partial class Admin : Form
    {
        //DataGridView dataGridView1 = new DataGridView();
        String[] customers = File.ReadAllLines("Customer Data.txt");
        public Admin()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {

            double llTotalSeats = 0;
            double clTotalSeats = 0;
            double udTotalSeats = 0;
            double TotalSales = 0;
            //Query of customers array that contains the file data.
            var datagridQuery = from name in customers
                                let getdata = name.Split(',')
                                let getname = getdata[0]
                                let useremail = getdata[1]
                                let gettotalcost = getdata[5]
                                let getConfirm = getdata[6]
                                let ll = getdata[2]
                                let cl = getdata[3]
                                let ud = getdata[4]
                                let sales = getdata[5]
                                select new { useremail, getname, gettotalcost, getConfirm, ll, cl, ud, sales };
            // create a loop to add daat into data grid.  Also, use loop to compute total seats and total sales.
            foreach (var name in datagridQuery)
            {
                //load data into data grid

                dataGridView1.Rows.Add(name.getname, name.useremail, name.gettotalcost, name.getConfirm, name.ll, name.cl, name.ud);

                //computer total seats purchased
                llTotalSeats += double.Parse(name.ll);
                clTotalSeats += double.Parse(name.cl);
                udTotalSeats += double.Parse(name.ud);
                TotalSales += double.Parse(name.sales);
            }

            //display total seats remaining and total sales.
            lblLowRemain.Text = (200 - llTotalSeats).ToString();
            lblClubRemain.Text = (75 - clTotalSeats).ToString();
            lblUppRemain.Text = (200 - udTotalSeats).ToString();
            lblTotalSales.Text = TotalSales.ToString("c2");

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string confirmNum = txtConNumber.Text;

            var searchNameQuery = from name in customers
                                  let seatTotal = name.Split(',')
                                  let searchName = seatTotal[0].ToUpper()
                                  let amtCharged = seatTotal[5]

                                  let confirm = seatTotal[6]
                                  select new { searchName, amtCharged, confirm };

            foreach (var result in searchNameQuery)
            {
                if (confirmNum == result.confirm)
                {
                    MessageBox.Show("Found Confirmation number: " + result.confirm + "\n" + "Name:  " + result.searchName + "\n" + "Total Charge: $" + result.amtCharged + "\n", "Confirmation found");

                }

            }
            //highlights row.
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[3].Value.ToString().Equals(confirmNum))
                    {
                        row.Selected = true;
                        break;
                    }


                }
            }
            catch
            {
                MessageBox.Show("Confirmation number does not exist!", "number not found");
            }
        }
    

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUppRemain_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
