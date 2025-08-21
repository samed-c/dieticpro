using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DieticPro.Forms
{

    public partial class AddNewCustomer : Form
    {
        public AddNewCustomer()
        {
            InitializeComponent();
        }



        private void TBsurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBbirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BTNCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                new DieticPro().AddNewCustomer(TBname.Text, TBsurname.Text, TBbirth.Text, TBcompany.Text, TBaddress.Text, Convert.ToInt64(TBtelephone.Text), Convert.ToInt64(TBmobile.Text));
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen müşteri bilgilerini doğru formatta giriniz. ");
            }

        }

    

        private void TBname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
