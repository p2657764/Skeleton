using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int StockNo { get; set; }
        public int UnitPrice { get; set; }
        public string StockColour { get; set; }
        public string StockName { get; set; }
    }
}