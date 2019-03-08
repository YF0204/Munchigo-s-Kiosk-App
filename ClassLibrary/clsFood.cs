using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsFood
    {
        // private data members
        private int mFoodID;
        private string mFoodName;
        private string mFoodType;
        private decimal mSellPrice;

        // public properties
        public int FoodID
        {
            get
            {
                return mFoodID;
            }
            set
            {
                mFoodID = value;
            }
        }

        public string FoodName
        {
            get
            {
                return mFoodName;
            }
            set
            {
                mFoodName = value;
            }
        }

        public string FoodType
        {
            get
            {
                return mFoodType;
            }
            set
            {
                mFoodType = value;
            }
        }

        public decimal SellPrice
        {
            get
            {
                return mSellPrice;
            }
            set
            {
                mSellPrice = value;
            }
        }

        // find method
        public bool Find(int FoodID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FoodID", FoodID);
            DB.Execute("sproc_tblFood_FilterByFoodID");
            if (DB.Count == 1)
            {
                // copy data
                mFoodID = Convert.ToInt32(DB.DataTable.Rows[0]["FoodID"]);
                mFoodName = Convert.ToString(DB.DataTable.Rows[0]["FoodName"]);
                mFoodType = Convert.ToString(DB.DataTable.Rows[0]["FoodType"]);
                mSellPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["SellPrice"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
