using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DieticPro;

using DieticPro.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace DieticPro
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void formatgrid2()
        {
            this.dataGridView1.Columns[0].HeaderText = "AD";
            this.dataGridView1.Columns[1].HeaderText = "SOYAD";
            this.dataGridView1.Columns[2].HeaderText = "SEANS";
            this.dataGridView1.Columns[3].HeaderText = "KATILIM";
            this.dataGridView1.Columns[4].HeaderText = "#SEANS-NO";
        }

        private void formatgrid1()
        {
            this.dataGridView1.Columns[0].HeaderText = "AD";
            this.dataGridView1.Columns[1].HeaderText = "SOYAD";
            this.dataGridView1.Columns[2].HeaderText = "KAYITTARİHİ";
            this.dataGridView1.Columns[3].HeaderText = "#MÜŞTERİ-NO";
        }
        public void formstatus(int level)
        {

            if (level == 1)
            {
                button7.Visible = false;
                button4.Visible = false;
                groupBox3.Visible = true;
            }
            else
            {
                button7.Visible = true;
                button4.Visible = true;

                groupBox3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formstatus(0);
            new AddNewCustomer().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new DieticPro().ShowAllCustomers();      
        }



        private void button2_Click(object sender, EventArgs e)
        {
            formstatus(0);
                this.dataGridView1.DataSource = new DieticPro().ShowAllCustomers();
                label1.Text = "TÜM MÜŞTERİLER";
                formatgrid1();
             }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                formstatus(0);
                new AddNewSeance().ShowDialog(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            }
        }

        private void BTNabout_Click(object sender, EventArgs e)
        {
                new About().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            formstatus(1);
            this.dataGridView1.DataSource = new DieticPro().ShowDailySeances(DateTime.Now.ToShortDateString());
            label1.Text = "BUGÜN GERÇEKLEŞTİRİLECEK SEANS RADEVULARI";
            formatgrid2();
        }




 
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                formstatus(0);
                new EditSeance().ShowDialog(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    formstatus(0);
                    new DieticPro().SeanceFulfilled(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    this.dataGridView1.DataSource = new DieticPro().ShowAllCustomers();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
      
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                formstatus(1);
                this.dataGridView1.DataSource = new DieticPro().ShowAllSeances(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                label1.Text = "MÜŞTERİNİN RANDEVULARI";
                formatgrid2();
            }
          
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                formstatus(0);
                new ShowSeance().ShowDialog(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

    }
}
