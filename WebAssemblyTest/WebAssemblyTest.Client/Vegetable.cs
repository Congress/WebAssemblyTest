﻿using System.Text.Json;

namespace WebAssemblyTest
{
    public class Vegetable
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; } // e.g., Root, Leafy, etc.
        public decimal Weight { get; set; } // In kg
        public bool IsOrganic { get; set; } // Organic or not

       
    }
}
