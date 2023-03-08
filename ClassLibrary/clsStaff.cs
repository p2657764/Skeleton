using System;

namespace ClassLibrary
{
    public class ClsStaff
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Wage { get; set; }
        public bool UpdateCatalogue { get; set; }
    }
}