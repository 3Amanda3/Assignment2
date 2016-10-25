/*
 * Amanda schepp
 * using string format to display an avarge
 * assignment 2, prgram 2
 * Mr.Hardman
 * October 24
 */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class frmAssignment2 : Form
    {
        public frmAssignment2()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
         
  
            double mark1 = Convert.ToDouble(txtGrade1.Text);
            double mark2 = Convert.ToDouble(txtGrade2.Text);
            double mark3 = Convert.ToDouble(txtGrade3.Text);
            double mark4 = Convert.ToDouble(txtGrade4.Text);
            double mark5 = Convert.ToDouble(txtGrade5.Text);

            
            double grades = mark1 + mark2 + mark3 + mark4 + mark5;
            double average = grades / 5;

          

            lblDisplay.Text = String.Format("{0,20}{1,10}\n{2,20}{3,10}\n{4,20}{5,10}\n{6,20}{7,10}\n{8,20}{9,10}\n{10,20}{11,10}",
               "Mark 1: ", mark1 , "Mark 2: ", mark2 , "Mark 3: ", mark3 , "Mark 4: ", mark4 , "Mark 5: ", mark5 ," Your Avarage is: ", average );

        
            
        }
    }
}
