using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartPromotionEngine.Models
{
    public class PromotionModel
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Unit { get; set; }
        public int PromoPrice { get; set; }
    }
}