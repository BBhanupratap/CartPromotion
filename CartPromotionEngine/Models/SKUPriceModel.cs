using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartPromotionEngine.Models
{
    public class SKUPriceModel
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int UnitPrice { get; set; }
    }
}