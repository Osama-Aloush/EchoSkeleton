using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public string Order_Description { get; set; }
        public bool Delivery_Status { get; set; }
        public int Item_Quantity { get; set; }
        public string Delivery_Address { get; set; }
        public string Order_ID { get; set; }
        public int Order_Total { get; set; }
        public DateTime Order_Date { get; set; }
    }
}