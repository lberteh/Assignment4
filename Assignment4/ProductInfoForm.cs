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
using System.IO;
using System.Xml.Serialization;
using Assignment4.Models;

namespace Assignment4
{
    public partial class ProductInfoForm : Form
    {
        // class variables
        public SelectForm previousForm;
        
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            if (Program.product.model != null)
            {
                populateTextBoxes();
            }        
        }

        // populate textboxes with data from product object
        private void populateTextBoxes()
        {
            txtProdID.Text = Program.product.productID.ToString();
            txtCondition.Text = Program.product.condition;          
            txtCost.Text = ((decimal)Program.product.cost).ToString("C2");
            txtPlatform.Text = Program.product.platform;
            txtManufacturer.Text = Program.product.manufacturer;
            txtOS.Text = Program.product.OS;
            txtModel.Text = Program.product.model;
            txtMemory.Text = Program.product.RAM_size;
            txtLCDSize.Text = Program.product.screensize;
            txtHDD.Text = Program.product.HDD_size;
            txtCPUBrand.Text = Program.product.CPU_brand;
            txtCPUNumber.Text = Program.product.CPU_number;
            txtCPUType.Text = Program.product.CPU_type;
            txtCPUSpeed.Text = Program.product.CPU_speed;
            txtGPU.Text = Program.product.GPU_Type;
            txtWebCam.Text = Program.product.webcam;
            btnNext.Enabled = true;
        }

        // save user selection to xml file with savefiledialog
        private void SaveFile(object sender, EventArgs e)
        {         
            saveFileDialog.Filter = "Xml Files (*.xml)|*.xml";
            saveFileDialog.Title = "Save your selection";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = Program.product.manufacturer + "-" + Program.product.model;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveSelection(Program.product, saveFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }     
                
            }
        }

        // save to xml
        private void SaveSelection(object IClass, string filename)
        {
            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer((IClass.GetType()));
                writer = new StreamWriter(filename);
                xmlSerializer.Serialize(writer, IClass);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
                writer = null;
            }
        }

        // open file
        public void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Title = "Open Saved Selection";
            openFileDialog.Filter = "Xml Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {                    
                    string path = openFileDialog.FileName;                   
                    Program.product = LoadSelection<Product>(path);
                    populateTextBoxes();

                }
                catch
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // load xml file
        private T LoadSelection<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        // end app
        private void ExitApp(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Application will terminate!", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // back to previous form
        private void ReturnToSelectForm(object sender, EventArgs e)
        {
            Program.product = null;       
            this.Close();
            previousForm.ClearForm();
            previousForm.Show();
        }

        // go to the next form
        private void btnNext_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.previousForm = this;
            this.Hide();
            orderForm.Show();
        }
    }
}
