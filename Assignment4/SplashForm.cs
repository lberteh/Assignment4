﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        // go to next form
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();

            this.Hide();
            startForm.Show();        
        }
    }
}
