using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffxivmc.Plugin.MarketData
{
    class MarketOrder
    {
        public int Item { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public bool HQ { get; set; }
        public int Total { get; set; }
        public int MarketCode { get; set; }
        public string Retainer { get; set; }

        public string MarketName
        {
            get
            {
                switch (MarketCode)
                {
                    case 65536:
                        return "Limsa";
                    case 131072:
                        return "Gridania";
                    case 196608:
                        return "Ul'Dah";
                    case 262144:
                        return "Foundation";
                    default:
                        return "Unknown Market";
                }
            }
        }

        override public string ToString()
        {
            return String.Format("Item: {0} Price: {1} Quantity: {2} HQ: {3} Total: {4} Retainer: {5}",
                Item, Price, Quantity, HQ, Total, Retainer);
        }

        public JObject ToJSON()
        {
            JObject Order = new JObject();

            Order["item"] = Item;
            Order["price"] = Price;
            Order["quantity"] = Quantity;
            Order["hq"] = HQ;
            Order["total"] = Total;
            Order["marketcode"] = MarketCode;
            Order["retainer"] = Retainer;

            return Order;
        }
    }

}
