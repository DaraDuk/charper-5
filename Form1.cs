using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Population
{
    public partial class Form1 : Form
    {
        private object txtNumberToday;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void tbnProjectStudent_Click(object sender, EventArgs e)
        {
            decimal NumberToday = Convert.ToDecimal(txtNumber.Text);
            decimal AnnualRate = Convert.ToDecimal(txtAnnualgrowth.Text);
            decimal Numberofyears = Convert.ToInt32(txtNumberofyears.Text);
            

            for (int i = 0; i <Numberofyears; i++)
            {
                NumberToday = NumberToday + (NumberToday * AnnualRate);
            }
            decimal projected = Math.Round(NumberToday);
            txtProjected.Text = projected.ToString("c");
            txtNumber.Focus();
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

