using System;
using System.Collections.Generic;

#nullable disable

namespace TackleShopAdminApi.Models
{
    public partial class Lure
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Weight { get; set; }
        public string Length { get; set; }
        public string PlasticsLength { get; set; }
        public string Buoyancy { get; set; }
        public string Hooks { get; set; }
        public int? QuantityPerPacket { get; set; }
        public int Inventory { get; set; }
        public string ItemTypeForShipping { get; set; }
        public string ImagePath { get; set; }
        public int LureId { get; set; }
    }
}
