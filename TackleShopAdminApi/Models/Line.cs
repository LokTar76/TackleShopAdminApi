using System;
using System.Collections.Generic;

#nullable disable

namespace TackleShopAdminApi.Models
{
    public partial class Line
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string Length { get; set; }
        public decimal Price { get; set; }
        public string Perating { get; set; }
        public string Strength { get; set; }
        public string SpoolLength { get; set; }
        public string Color { get; set; }
        public string Diameter { get; set; }
        public int Inventory { get; set; }
        public string ItemTypeForShipping { get; set; }
        public string ImagePath { get; set; }
        public int LineId { get; set; }
    }
}
