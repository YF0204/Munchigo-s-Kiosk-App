using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // private data members
        private int mCustomerID;
        private string mName;
        private string mPhoneNo;
        private string mAddress;
        private string mTown;
        private string mPostCode;
        private string mEmailAddress;

        // public properties
        public int CustomerID
        {
            get 
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                return mPhoneNo;
            }
            set
            {
                mPhoneNo = value;
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public string Town
        {
            get
            {
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }

        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }

        // public find method
        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                // copy data
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
