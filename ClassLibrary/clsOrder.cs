using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        private Int32 mItem_Quantity;
        private Int32 mOrder_Total;
        private DateTime mOrder_Date;
        private String mDelivery_Address;
        private String mOrder_ID;
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
        public string Order_ID {
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

        public bool Find(int itemNo)
        {
            mItem_Quantity = 8;
            mOrder_Date = Convert.ToDateTime("24/02/2004");
            mOrder_ID = "O-1";
            mDelivery_Status = true;
            mOrder_Total = 25;
            mDelivery_Address = "Test Street";
            //Always return true
            return true;
        }
    }
}