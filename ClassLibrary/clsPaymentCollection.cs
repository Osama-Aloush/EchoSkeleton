using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsPaymentCollection
    {
        public clsPaymentCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stores procedure
            DB.Execute("sproc_tblPayment_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are record to process
            while (Index < RecordCount)
            {
                clsPayment AnPayment = new clsPayment();
                AnPayment.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnPayment.NameAdded = Convert.ToString(DB.DataTable.Rows[Index]["NameAdded"]);
                AnPayment.CardAdded = Convert.ToString(DB.DataTable.Rows[Index]["CardAdded"]);
                AnPayment.CVVAdded = Convert.ToString(DB.DataTable.Rows[Index]["CVVAdded"]);
                AnPayment.IDAdded = Convert.ToString(DB.DataTable.Rows[Index]["IDAdded"]);
                //add the record to the private data member
                mPaymentList.Add(AnPayment);
                //point to the next record
                Index++;
            }
            

        }
        List<clsPayment> mPaymentList = new List<clsPayment>();
        public List<clsPayment> PaymentList
        {
            get
            {
                return mPaymentList;
            }
            set
            {
                mPaymentList = value;
            }
        }

        public int Count
        {
            get
            {
                return mPaymentList.Count;
            }
            set
            {

            }
        }
        public clsPayment ThisPayment { get; set; }
    }


}