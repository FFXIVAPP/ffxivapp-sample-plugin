
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ffxivmc.Plugin.Utilities;

namespace ffxivmc.Plugin.MarketData
{
    class MarketOrderList
    {
        public long Timestamp { get; set; }
        public List<MarketOrder> List { get; set; }
        public int ItemId { get; set; }
        public String server { get; set; }

        public MarketOrderList()
        {
            Timestamp = MCTask.UnixTimeNow();
            List = new List<MarketOrder>();
        }

        public void Add(MarketOrder Order)
        {
            List.Add(Order);
        }
        
        public JObject ToJSON()
        {
            JObject OrderList = new JObject();
            OrderList["timestamp"] = Timestamp;
            JArray JOrders = new JArray();
            foreach (var Order in List)
                JOrders.Add(Order.ToJSON());
            OrderList["orders"] = JOrders;

            if (List.Count > 0)
            {
                OrderList["itemID"] = List[0].Item;
            }

            OrderList["server"] = server;

            return OrderList;
        }
    }
}
