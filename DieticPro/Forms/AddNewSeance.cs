using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DieticPro.Forms
{
    public partial class AddNewSeance : Form
    {
        public AddNewSeance()
        {
            InitializeComponent();
        }

        public int cid;

      

        internal void ShowDialog(string p)
        {
            cid = Convert.ToInt32(p);
            this.ShowDialog();
        }

        private void AddNewSeance_Load(object sender, EventArgs e)
        {
        //dataGridView1.DataSource = DieticPro.ShowCustomerBrief(cid);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                new DieticPro().AddNewSeance(textBox1.Text, cid);
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen randevu tarihini geçerli gg.aa.yyyy formatında giriniz!");
            }

            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
