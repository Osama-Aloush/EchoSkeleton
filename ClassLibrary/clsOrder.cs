using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        private Int32 mItem_Quantity;
        private Int32 mOrder_Total;
        private DateTime mOrder_Date;
        private String mDelivery_Address;
        private Int32 mOrder_ID;
        private String mOrder_Description;
        private Boolean mDelivery_Status;

        public string Order_Description {
            get {
                return mOrder_Description;
            }
            set {
                mOrder_Description = value;
            }
        }
        public bool Delivery_Status {
            get {
                return mDelivery_Status;
            }
            set {
                mDelivery_Status = value;
            }
        }

        public Int32 Item_Quantity {
            get {

                //Sends data out to the property
                return mItem_Quantity;
            
            } set {

                //Allows the data into the property
                mItem_Quantity = value;
            
            } 
        
        }

        public string Delivery_Address {
            get {
                return mDelivery_Address;
            }
            set {
                mDelivery_Address = value;
            }
        }
        public int Order_ID {
            get {
                return mOrder_ID;
            }

            set {
                mOrder_ID = value;
            }
        }
        public int Order_Total {
            get {
                return mOrder_Total;
            }
            set {
                mOrder_Total = value;
            }
        }
        public DateTime Order_Date {
            get {
                return mOrder_Date;
            }
            set {
                mOrder_Date = value;
            }
        }

        public bool Find(Int32 OrderID)
        {
            //Creating data connection
            clsDataConnection DB = new clsDataConnection();
            //Add parameter is the parameters to be searched
            DB.AddParameter("@OrderID", OrderID);
            //Execute stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");

            if (DB.Count == 1)
            {
                //Copy data from database
                mItem_Quantity = Convert.ToInt32(DB.DataTable.Rows[0]["Item_Quantity"]);
                mOrder_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_ID"]);
                mOrder_Description = Convert.ToString(DB.DataTable.Rows[0]["Order_Description"]);
                mOrder_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Order_Date"]);
                mDelivery_Status = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivery_Status"]);
                mDelivery_Address = Convert.ToString(DB.DataTable.Rows[0]["Delivery_Address"]);
                mOrder_Total = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Total"]);

                //Return true if everything works
                return true;
            }

            else {
                //Return false if there is a problem
                return false;
            }
        }
    }
}