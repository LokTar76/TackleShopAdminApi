using System;
using System.Collections.Generic;

#nullable disable

namespace TackleShopAdminApi.Models
{
    public partial class Reel
    {
        public string Brand { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string ReelType { get; set; }
        public decimal Price { get; set; }
        public string DragPower { get; set; }
        public string GearRatio { get; set; }
        public string Bearings { get; set; }
        public string ReelWeight { get; set; }
        public string RetrievePerCrank { get; set; }
        public string BraidCapacity { get; set; }
        public string MonoCapacity { get; set; }
        public string DiameterCapacity { get; set; }
        public string ItemTypeForShipping { get; set; }
        public string ImagePath { get; set; }
        public int Inventory { get; set; }
        public int ReelId { get; set; }
    }
}
