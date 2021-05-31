using System;
using System.Collections.Generic;

#nullable disable

namespace TackleShopAdminApi.Models
{
    public partial class Combo
    {
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public int Inventory { get; set; }
        public string ItemTypeForShipping { get; set; }
        public string ImagePath { get; set; }
        public string Reel { get; set; }
        public string Rod { get; set; }
        public int ComboId { get; set; }
    }
}
