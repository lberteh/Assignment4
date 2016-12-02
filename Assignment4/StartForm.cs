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

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.previousForm = this;

            this.Hide();
            selectForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
