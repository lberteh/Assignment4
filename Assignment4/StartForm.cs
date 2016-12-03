/*
 * App: Assignment 4 - Dollar Computer 
 * Author: Lucas Berté Schoenardie
 * Student #: 200322197
 * App Creation Date: 12/02/2016
 * App Description: Computer store (select and purchase a computer/laptop)
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

namespace Assignment4
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        // go to select computer form
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.previousForm = this;

            this.Hide();
            selectForm.Show();
        }

        // end app
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Application will terminate!", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // open product info form and the open file dialog 
        private void btnOpenSaved_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = selectForm;

            this.Hide();
            productInfoForm.Show();
            productInfoForm.OpenFile(btnOpenSaved, e);
                       
        }
    }
}
