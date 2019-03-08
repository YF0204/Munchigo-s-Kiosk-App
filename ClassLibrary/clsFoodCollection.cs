using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsFoodCollection
    {
        // private data member for the food list items
        private List<clsFood> mFoods = new List<clsFood>();
        // private data member ThisFood
        clsFood mThisFood = new clsFood();

        // public property ThisFood
        public clsFood ThisFood
        {
            get
            {
                return mThisFood;
            }
            set
            {
                mThisFood = value;
            }
        }

        // public class constructor
        public clsFoodCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblFood_SelectAll");
            // get the count
            Int32 RecordCount = DB.Count;
            // set index
            Int32 Index = 0;
            // while loop
            while (Index < RecordCount)
            {
                // create class instance
                clsFood Food = new clsFood();
                // get data
                Food.FoodID = Convert.ToInt32(DB.DataTable.Rows[Index]["FoodID"]);
                Food.FoodName = Convert.ToString(DB.DataTable.Rows[Index]["FoodName"]);
                Food.FoodType = Convert.ToString(DB.DataTable.Rows[Index]["FoodType"]);
                Food.SellPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["SellPrice"]);
                // add record
                mFoods.Add(Food);
                // increment index
                Index++;
            }
        }

        // public property for all foods
        public List<clsFood> FoodList
        {
            get
            {
                return mFoods;
            }
            set
            {
                mFoods = value;
            }
        }

        // public count property
        public int Count
        {
            get
            {
                return mFoods.Count;
            }
            set
            {
                // later
            }
        }

        // public add method
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FoodName", mThisFood.FoodName);
            DB.AddParameter("@FoodType", mThisFood.FoodType);
            DB.AddParameter("@SellPrice", mThisFood.SellPrice);
            return DB.Execute("sproc_tblFood_Insert");
        }

        
    }
}
