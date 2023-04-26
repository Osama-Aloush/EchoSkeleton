using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //Private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        public clsOrderCollection() {
            //Variable for the index
            Int32 Index = 0;
            //Varible to store the record count
            Int32 RecordCount = 0;
            //Obj for data collection
            clsDataConnection DB = new clsDataConnection();
            //Executing the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //Get the count of records
            RecordCount = DB.Count;
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
        public clsOrder ThisOrder { get; set; }
    }
}