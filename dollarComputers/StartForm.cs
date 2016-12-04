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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;

            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            SelectForm SelectForm = new SelectForm();
            
            // show the next form
            SelectForm.Show();

            // hide this one
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            ProductInfoForm ProductInfoForm = new ProductInfoForm();

            // show the next form
            ProductInfoForm.Show();

            // hide this one
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
