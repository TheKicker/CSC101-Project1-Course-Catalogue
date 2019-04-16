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

        //***************************************
        //
        //  Created by Cavan Lemasters
        //  March 6-9th 2017
        //  CSC 101 First Proj
        //
        //***************************************

namespace GC_Major_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form 1 Code for the continue and the close buttons //

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            // Hides current window, opens the second window
            this.Hide();

            // Show the second window
            Form2 Form2 = new Form2();
            Form2.ShowDialog();

            //Close first form
            this.Close();
            
        }

        private void CloseButton1_Click(object sender, EventArgs e)
        {
            // Closes the application from main form
            this.Close();
        }
    }
}
