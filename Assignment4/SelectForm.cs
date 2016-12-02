using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Assignment4.Models;

namespace Assignment4
{
    public partial class SelectForm : Form
    {
        // class variables

        public StartForm previousForm; 

        public SelectForm()
        {
            InitializeComponent();
        }

        public void ClearForm()
        {
            btnNext.Enabled = false;
            dataGridViewComputerList.ClearSelection();
            txtSelection.Text = "";
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computerStoreDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.computerStoreDataSet.products);
            Program.productList = (from product in Program.db.products select product).ToList(); // store all products in th products table in a list
            btnNext.Enabled = false;
            dataGridViewComputerList.ClearSelection();
            txtSelection.Text = "";
        }

        // close the app
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // select a product
        private void RowClicked(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex != -1)
            {
                dataGridViewComputerList.Rows[e.RowIndex].Selected = true;
                int ID = Convert.ToInt32(dataGridViewComputerList.Rows[e.RowIndex].Cells[0].Value);


                Program.product = Program.productList.ElementAt(ID - 1); // product = product from the products list specified by it's position in the list 

                txtSelection.Text = Program.product.ToString(); // display selection
            }
            
        }

        // go to the next form
        private void btnNext_Click(object sender, EventArgs e)
        {
            // instantiate next form
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.previousForm = this;

            // hide this form and show next form
            this.Hide();
            productInfoForm.Show();
        }

        // enable next button
        private void txtSelection_TextChanged(object sender, EventArgs e)
        {
            if(btnNext.Enabled == false)
            {
                btnNext.Enabled = true;
            }
        }
    }
}
