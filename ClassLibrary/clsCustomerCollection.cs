using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the customer list
        private List<clsCustomer> mAllCustomers = new List<clsCustomer>();
        // private data membet thiscustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }

            set
            {
                mThisCustomer = value;
            }
        }

        //public class constructor
        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            // get the count of records
            Int32 RecordCount = DB.Count;
            // set index
            Int32 Index = 0;
            // while loop
            while (Index < RecordCount)
            {
                // create class instance
                clsCustomer ACustomer = new clsCustomer();
                // get data
                ACustomer.Name = DB.DataTable.Rows[Index]["Name"].ToString();
                ACustomer.PhoneNo = DB.DataTable.Rows[Index]["PhoneNo"].ToString();
                ACustomer.Address = DB.DataTable.Rows[Index]["Address"].ToString();
                ACustomer.Town = DB.DataTable.Rows[Index]["Town"].ToString();
                ACustomer.PostCode = DB.DataTable.Rows[Index]["PostCode"].ToString();
                ACustomer.EmailAddress = DB.DataTable.Rows[Index]["EmailAddress"].ToString();
                // add record
                mAllCustomers.Add(ACustomer);
                // increment index
                Index++;
            }
        }

        // public count property
        public int Count
        {
            get
            {
                return mAllCustomers.Count;
            }
            set
            {

            }
        }

        //public property for allcustomers
        public List<clsCustomer> CustomersList
        {
            get
            {
                return mAllCustomers;
            }
            set
            {
                mAllCustomers = value;
            }
        }
    }
}