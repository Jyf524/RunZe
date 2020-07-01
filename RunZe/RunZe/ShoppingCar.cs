using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunZe
{
        public static class ShoppingCar
        {
            public static List<ShoppingItem> ShoppingList = new List<ShoppingItem>() { };
        }
        public class ShoppingItem
        {
            public string ShoppingCartID { get; set; }
            public string CommodityID { get; set; }
            public string CommodityImage { get; set; }
            public string CommodityName { get; set; }
            public int OrderNumber { get; set; }
            public decimal VIPPrice { get; set; }
            public decimal Subtotal { get; set; }
            //public DateTime ATime { get; set; }
        }

}