using System;

namespace ClassLibrary
{
    public class clsOrder
    { 
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderPlacedDate { get; set; }
        public bool OrderVerification { get; set; }
        public int ProductQuantity { get; set; }
        public int UnitPrice { get; set; }
        public DateTime ShippingDate { get; set; }
        public bool Active { get; set; }
    }
}