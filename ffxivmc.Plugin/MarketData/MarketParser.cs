using ffxivmc.Plugin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffxivmc.Plugin.MarketData
{
    class MarketParser
    {
        public static void ParseOrderList(byte[] buffer)
        {
            //https://docs.google.com/document/d/1qMwunzN1P5D8xpA920k5GhMADwFXam7zzKL76YnqUvg/edit?usp=sharing

            MarketOrderList list = new MarketOrderList();

            //skip over 32 byte header
            int index = 32;
            //each data packet only has 10 orders
            for (int i = 0; i < 10; i++)
            {
                var order = new MarketOrder();

                //skip over first 8 bytes of order
                index += 32;

                order.Price = BitConverter.ToInt32(buffer, index);
                index += 4;

                //something?
                index += 4;
                order.Quantity = BitConverter.ToInt32(buffer, index);
                index += 4;

                order.Item = BitConverter.ToInt32(buffer, index);
                index += 4;

                if (order.Item == 0) break;

                //skip extra junk
                index += (7 * 4);


                order.Retainer = Encoding.ASCII.GetString(buffer, index, 32).Trim('\0');

                index += 32;

                order.HQ = BitConverter.ToInt16(buffer, index) != 0;
                index += 2;

                order.MarketCode = BitConverter.ToInt16(buffer, index);
                index += 2;

                order.Total = order.Quantity * order.Price;

                list.Add(order);

                LogPublisher.WriteLine(order.ToString());

            }

            //LogPublisher.WriteLine("parsed list");
            //LogPublisher.WriteLine(list.ToJSON().ToString());
            H.Post(Endpoints.MarketOrders(), list.ToJSON());
        }

    }
}
