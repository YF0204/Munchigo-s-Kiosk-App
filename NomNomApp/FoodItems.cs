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
    public partial class FoodItems : Form
    {
        public FoodItems()
        {
            InitializeComponent();
        }

        void DisplayFoods()
        {
            clsFoodCollection Foods = new clsFoodCollection();
            listBox1.DataSource = Foods.FoodList;
            listBox1.DisplayMember = "FoodName";
            listBox1.ValueMember = "FoodID";
        }

        private void FoodItems_Load(object sender, EventArgs e)
        {
            DisplayFoods();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFood Add = new AddFood();
            Add.Show();
        }
    }

}
