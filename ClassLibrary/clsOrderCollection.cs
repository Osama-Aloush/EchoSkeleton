using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //Private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //Private data member for ThisOrder
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection() {
            //Data connection obj
            clsDataConnection DB = new clsDataConnection();

            //Execute Stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");

            PopulateArray(DB);
        }

        public List<clsOrder> OrderList { 
            
            get
            {
                //return private data
                return mOrderList;
            }

            set {
                //set tthe private data
                mOrderList = value;
            }
        
        }
        public int Count {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            
            set
            {
                //We shall worry about this later
            }
        }
        public clsOrder ThisOrder {
            get {
                //return the private data
                return mThisOrder;
            }

            set {
                //set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //Add the new record to the database based on the values of ThisOrder
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedures
            DB.AddParameter("@Order_Description",mThisOrder.Order_Description);
            DB.AddParameter("@Order_Date", mThisOrder.Order_Date);
            DB.AddParameter("@Delivery_Status", mThisOrder.Delivery_Status);
            DB.AddParameter("@Item_Quantity", mThisOrder.Item_Quantity);
            DB.AddParameter("@Delivery_Address", mThisOrder.Delivery_Address);
            //Execute the stored procedure
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //Update existing records based of the values of ThisOrder
            //Connect to the database.....
            clsDataConnection DB = new clsDataConnection();

            //Set the parameters for the stored procedures
            DB.AddParameter("@Order_Description", mThisOrder.Order_Description);
            DB.AddParameter("@Order_Date", mThisOrder.Order_Date);
            DB.AddParameter("@Delivery_Status", mThisOrder.Delivery_Status);
            DB.AddParameter("@Item_Quantity", mThisOrder.Item_Quantity);
            DB.AddParameter("@Delivery_Address", mThisOrder.Delivery_Address);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //Update existing records based of the values of ThisOrder
            //Connect to the database.....
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@Order_ID",mThisOrder.Order_ID);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByStreetType(string StreetType)
        {
            //Connect to the database...
            clsDataConnection DB = new clsDataConnection();
            //Send the parameter to the database
            DB.AddParameter("@Delivery_Address", mThisOrder.Delivery_Address);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByStreetType");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB) {
            //Variable for the index
            Int32 Index = 0;
            //Variable to store the record count
            Int32 RecordCount;
            //Get the count for the records
            RecordCount = DB.Count;
            //CLear the private arraylist
            mOrderList = new List<clsOrder>();

            //While there are records to process
            while (Index < RecordCount) {
                //Create a blank address
                clsOrder AnOrder = new clsOrder();
                //Read in the fields from the current record
                AnOrder.Delivery_Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Delivery_Status"]);
                AnOrder.Order_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Order_ID"]);
                AnOrder.Order_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Order_Date"]);
                AnOrder.Order_Description = Convert.ToString(DB.DataTable.Rows[Index]["Order_Description"]);
                AnOrder.Delivery_Address = Convert.ToString(DB.DataTable.Rows[Index]["Delivery_Address"]);
                AnOrder.Item_Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Item_Quantity"]);

                //Add the record to the private data member
                mOrderList.Add(AnOrder);
                //Point at the next record
                Index++;
            }

        }
    }
}