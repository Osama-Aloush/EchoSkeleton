using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string NameAdded { get; set; }
        public string CardAdded { get; set; }
        public string CVVAdded { get; set; }
        public string IDAdded { get; set; }
        public string AmountAdded { get; set; }
    }

}