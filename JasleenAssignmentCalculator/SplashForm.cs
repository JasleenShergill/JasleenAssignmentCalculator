﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasleenAssignmentCalculator
{
    public partial class SplashForm : Form
    {
        public CalculatorForm CalculatorForm
        {
            get
            {
                return Program.calculatorForm;
            }

        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the main constructor for the SplashForm
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.CalculatorForm.Show();

            this.Hide();

            SplashFormTimer.Enabled = false; // turn timer off
        }
   }
}
