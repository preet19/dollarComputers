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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("programmer’s name= Dilpreet Singh,version of  the program=1.00 "+
                "website and contact number= website.com, 705-796-7880");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
