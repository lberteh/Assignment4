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
    public partial class OrderForm : Form
    {
        // class variables 
        public ProductInfoForm previousForm; 

        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            populateTextBoxes();
        }

        // populate textboxes with data from product object 
        private void populateTextBoxes()
        {
            txtCondition.Text = Program.product.condition;
            txtPlatform.Text = Program.product.platform;
            txtManufacturer.Text = Program.product.manufacturer;
            txtModel.Text = Program.product.model;
            txtLCDSize.Text = Program.product.screensize;
            txtMemory.Text = Program.product.RAM_size;
            txtCPUBrand.Text = Program.product.CPU_brand;
            txtCPUType.Text = Program.product.CPU_type;
            txtCPUNumber.Text = Program.product.CPU_number;
            txtCPUSpeed.Text = Program.product.CPU_speed;
            txtHDD.Text = Program.product.HDD_size;
            txtGPUType.Text = Program.product.GPU_Type;
            txtWebCam.Text = Program.product.webcam;
            txtOS.Text = Program.product.OS;
            txtPrice.Text = ((decimal)Program.product.cost).ToString("C2");
            txtSalesTax.Text = ((decimal)Program.product.cost * 0.13m).ToString("C2");

            decimal total = ((decimal)Program.product.cost) + ((decimal)Program.product.cost*0.13m);
            txtTotal.Text = total.ToString("C2");

            if (Program.product.platform == "Laptop")
                pBoxComputer.Image = Properties.Resources.laptop;
            else
                pBoxComputer.Image = Properties.Resources.desktop;
        }

        // exit app
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Application will terminate!", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // return to previous form
        private void Back(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        // display about box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        // display printing message
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your selection is being printed...", "Printing");
        }

        // end app
        private void btnFinish_Click(object sender, EventArgs e)
        {
            string message = "Thank  you  for  choosing  Dollar  Computer!\n\nYour  order  will  be  proccessed  in  7-10  days.";

            DialogResult result = MessageBox.Show(message, "Dollar Computer");
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
