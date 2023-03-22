namespace ClassLibrary
{
    public class clsOrder
    {
        public string OrderDescription { get; set; }
        public int OrderTotal { get; set; }
        public bool HasDiscount { get; set; }
        public int DiscountAmount { get; set; }
    }
}