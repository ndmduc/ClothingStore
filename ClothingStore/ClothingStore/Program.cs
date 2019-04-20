using ClothingStore.Function;
using ClothingStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClothesFactory clothesFactory = new ClothesFactory();
                IClothes shirt = null;
                // User make choice.

                Console.WriteLine("Please choose clothing you want to trading:");
                Console.WriteLine("1: TShirt, 2: DShirt");

                switch (int.Parse(Console.ReadLine().ToString()))
                {
                    case 1:
                        shirt = clothesFactory.GetClothes(ClothesType.TShirt);
                        break;
                    case 2:
                        shirt = clothesFactory.GetClothes(ClothesType.TShirt);
                        break;
                    default:

                        break;
                }

                // Execute action.
                Console.WriteLine("Please choose action you want to trading:");
                Console.WriteLine("1: Sell, 2: Buy");
                var tradetype = int.Parse(Console.ReadLine().ToString());
                
                // User make a number to trade.
                Console.WriteLine("Please choose number of item you want to trading:");
                var tradeNo = int.Parse(Console.ReadLine().ToString());

                switch (tradetype)
                {
                    case 1:
                        Console.WriteLine( shirt.Trade(TradeType.Sell, tradeNo));
                        break;
                    case 2:
                        Console.WriteLine(shirt.Trade(TradeType.Buy, tradeNo));
                        break;
                    default:

                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.Read();
        }
    }
}
