using CartPromotionEngine.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartPromotionEngine.Services
{
    public class ApplyPromotion
    {

        public int GetCartPrice(SKUModel sku)
        {
            int total = 0;
            IList<PromotionModel> promotion = new List<PromotionModel>();
            IList<SKUPriceModel> SKUPrice = new List<SKUPriceModel>();
            PromotionModel pModel = new PromotionModel();
            SKUPriceModel sModel = new SKUPriceModel();

            for (int i = 0; i < pModel.Item.Length; i++)
            {
                var unit = from u in promotion
                           where u.Item.Equals(pModel.Item)
                           select u.Unit;
                var PromoPrice = from p in promotion
                                 where p.Item.Equals(pModel.Item)
                                 select p.PromoPrice;
                var UnitPrice = from up in SKUPrice
                                where up.Item.Equals(pModel.Item)
                                select up.UnitPrice;
                switch (pModel.Item)
                {

                    case "A":
                        total += (sku.A / unit.FirstOrDefault()) * PromoPrice.FirstOrDefault() + (sku.A % unit.FirstOrDefault()) * UnitPrice.FirstOrDefault();
                        break;
                    case "B":
                        total += (sku.B / pModel.Unit) * PromoPrice.FirstOrDefault() + (sku.B % unit.FirstOrDefault()) * UnitPrice.FirstOrDefault();
                        break;
                    case "CD":
                        if (sku.C > sku.D)
                            total += sku.D * PromoPrice.FirstOrDefault() + (sku.C - sku.D) * SKUPrice.Single(c => c.Item.Equals("C")).UnitPrice;
                        else
                            total += sku.C * PromoPrice.FirstOrDefault() + (sku.D - sku.C) * SKUPrice.Single(d => d.Item.Equals("D")).UnitPrice;
                        break;
                }

            }
            return total;
        }
    }
}
