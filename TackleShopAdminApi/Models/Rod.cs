using System;
using System.Collections.Generic;

#nullable disable

namespace TackleShopAdminApi.Models
{
    public partial class Rod
    {
        public string Brand { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public string RodType { get; set; }
        public decimal Price { get; set; }
        public string LineWeight { get; set; }
        public string Perating { get; set; }
        public string Pieces { get; set; }
        public string Length { get; set; }
        public string RodGuides { get; set; }
        public string CastWeight { get; set; }
        public string RodGrips { get; set; }
        public string RodButtAssembly { get; set; }
        public int Inventory { get; set; }
        public string ItemTypeForShipping { get; set; }
        public string ImagePath { get; set; }
        public int RodId { get; set; }
    }
}
