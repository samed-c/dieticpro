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
    public partial class ShowSeance : Form
    {
           public int cid;

        public ShowSeance()
        {
            InitializeComponent();
        }

        internal void ShowDialog(string p)
        {
  
            DieticPro GetUnary = new DieticPro();
            label1.Text = GetUnary.GetUnaryData("SEANCES.SID", p);
            label3.Text = GetUnary.GetUnaryData("SEANCES.SDATE", p);
            label5.Text = GetUnary.GetUnaryData("(SELECT * FROM PROC_PARTICIPATION(SEANCES.FULFILL))", p);
            label7.Text = GetUnary.GetUnaryData("SEANCES.WEIGHT", p);
            label9.Text = GetUnary.GetUnaryData("SEANCES.HEIGHT", p);
            label11.Text = GetUnary.GetUnaryData("SEANCES.ROUND", p);
            label13.Text = GetUnary.GetUnaryData("SEANCES.ANALYSIS", p);
            label15.Text = GetUnary.GetUnaryData("SEANCES.NOTE", p);
            this.ShowDialog();
        }

        private void ShowSeance_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
