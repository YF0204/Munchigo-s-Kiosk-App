using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace NomNomApp
{
    public partial class CustomerDB : Form
    {
        void DisplayCustomers()
        {
            clsCustomerCollection Customers = new clsCustomerCollection();
            listBox1.DataSource = Customers.CustomersList;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "CustomerID";
        }
        public CustomerDB()
        {
            InitializeComponent();
        }

        private void CustomerDB_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }
    }
}
