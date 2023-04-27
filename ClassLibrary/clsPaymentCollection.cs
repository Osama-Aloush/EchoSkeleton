using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    public class clsPaymentCollection
    {

        //private data memeber thisPayment
        clsPayment mThisPayment = new clsPayment();
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
        public clsPayment ThisPayment
        {
            get
            {
                return mThisPayment;
            }
            set
            {
                mThisPayment = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@NameAdded", mThisPayment.NameAdded);
            DB.AddParameter("@CardAdded", mThisPayment.CardAdded);
            DB.AddParameter("@CVVAdded", mThisPayment.CVVAdded);
            DB.AddParameter("@IDAdded", mThisPayment.IDAdded);
            DB.AddParameter("AmountAdded", mThisPayment.AmountAdded);
            DB.AddParameter("@Active", mThisPayment.Active);

            return DB.Execute("sproc_tblPayment_Instert");



        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@NameAdded", mThisPayment.NameAdded);
            DB.AddParameter("@CardAdded", mThisPayment.CardAdded);
            DB.AddParameter("@CVVAdded", mThisPayment.CVVAdded);
            DB.AddParameter("@IDAdded", mThisPayment.IDAdded);
            DB.AddParameter("AmountAdded", mThisPayment.AmountAdded);
            DB.AddParameter("@Active", mThisPayment.Active);

            DB.Execute("sproc_tblPayment_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@NameAdded", mThisPayment.NameAdded);
            

            DB.Execute("sproc_tblPayment_Instert");



        }

    }
}