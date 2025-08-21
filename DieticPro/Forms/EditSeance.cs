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
    public partial class EditSeance : Form
    {

        public int cid;

        public EditSeance()
        {
            InitializeComponent();
        }


        internal void ShowDialog(string p)
        {
            cid = Convert.ToInt32(p);
            this.ShowDialog();
  
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new DieticPro().EditSeanceDetails(Convert.ToString(cid), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bilgileri doğru formatta giriniz.");
            }
        }

        private void EditSeance_Load(object sender, EventArgs e)
        {
        //dataGridView1.DataSource = DieticPro.ShowSeanceDet(cid);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
