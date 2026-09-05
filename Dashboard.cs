using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer button clicked");
        }
        

        private void btnplans_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plans button clicked");
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee button clicked");
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoices button clicked");
        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Monthly Report button clicked");
        }
    }
    }

