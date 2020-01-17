using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tokyo_Hair_Project
{
    public partial class confirm : Form
    {
        public DataMover dat = new DataMover();


        public confirm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            bool isValidNumber = true;
            try
            {
                dat.SetCardNumber(long.Parse(txtCardNumber.Text));
            }
            catch
            {
                //dat.PlaySassyNo();
                MessageBox.Show("Invalid age format, please enter numbers only." + "\r\n" + "Try again please!");
                isValidNumber = false;
            }
            if (isValidNumber == false)
            {
                txtCardNumber.Text = "";
            }
            bool isValidCSV = true;
            try
            {
                dat.SetCSV(int.Parse(txtCSV.Text));
            }
            catch
            {
                //dat.PlaySassyNo();
                MessageBox.Show("Invalid card code format, please enter numbers only." + "\r\n" + "Try again please!");
                isValidCSV = false;
            }
            if (isValidCSV ==false)
            {
                txtCSV.Text = "";
            }
            dat.SetCardName(txtCardName.Text);
            if (isValidNumber == true && isValidCSV == true)
            {
                dat.CheckCardData();
            }
            else
            {
                tickets tix = new tickets();
                tix.OpenConfirm();
            }
        }

        private void LblTotalCost_Click(object sender, EventArgs e)
        {

        }
    }
}
