using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Tokyo_Hair_Project
{
    public partial class accountCreation : Form
    {

        DataMover dat = new DataMover();

        public accountCreation()
        {
            InitializeComponent();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            try
            {
                dat.SetAge(int.Parse(txtAge.Text));
            }
            catch
            {
                MessageBox.Show("Invalid age format, please enter numbers only.");
                isValid = false;
            }
            if (isValid)
            {
                dat.AcccountCreation();
            }
        }
    }
}
