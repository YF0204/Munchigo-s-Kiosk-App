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
    public partial class AddFood : Form
    {
        public AddFood()
        {
            InitializeComponent();
        }

        void Add()
        {
            clsFoodCollection Foods = new clsFoodCollection();
            Foods.ThisFood.FoodID = -1;
            if (Foods.ThisFood.FoodID == -1)
            {
                Foods.ThisFood.FoodName = textBox1.Text;
                Foods.ThisFood.FoodType = textBox3.Text;
                Foods.ThisFood.SellPrice = Convert.ToDecimal(textBox2.Text);
                Foods.Add();
            }
            else
            {
                lblError.Text = "There were problems with the data entered.";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
