using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 	App name = Dollar Computers
    Author's name = Dilpreet Singh
    Student	ID = 200306382
    App	Creation Date = 03/12/2016
    App description = This program IS configure and order computer system
 */


namespace dollarComputers
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            OrderForm OrderForm = new OrderForm();

            // show the next form
            OrderForm.Show();

            // hide this one
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties
           // openFileDialog.InitialDirectory = GetCurrentDirectory();
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";

            // Open the Dialog Box by using ShowDialog()
            DialogResult result = openFileDialog.ShowDialog();

          
        }
    }
}
