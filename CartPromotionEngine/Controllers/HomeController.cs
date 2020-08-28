using CartPromotionEngine.Models;
using CartPromotionEngine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CartPromotionEngine.Controllers
{
    public class HomeController : ApiController
    {
       // public HomeController()
        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(SKUModel sku)
        {
            ApplyPromotion promotion = new ApplyPromotion();//Add unity for DI
            var result = promotion.GetCartPrice(sku);
            return Ok(result);
        }
    }
}
