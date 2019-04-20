using System;
using System.Collections.Generic;
using ClothingStore.Option;

namespace ClothingStore.Model
{
    /// <summary>
    /// TShirt one implementation of IClothes.
    /// </summary>
    public class DShirt : IClothes
    {
        /// <summary>
        /// ITrade property.
        /// </summary>
        private ITrade trade;


        /// <summary>
        /// Sell rate
        /// </summary>
        private int sellRate = 20;

        /// <summary>
        /// Buy rate.
        /// </summary>
        private int buyRate = 8;

        /// <summary>
        /// OPtions
        /// </summary>
        private List<IOption> options;

        /// <summary>
        /// Sell rate property.
        /// </summary>
        public int SellRate
        {
            get
            {
                return this.sellRate;
            }
        }

        /// <summary>
        /// Buy rate property.
        /// </summary>
        public int BuyRate
        {
            get
            {
                return this.buyRate;
            }
        }

        /// <summary>
        /// List of property.
        /// </summary>
        public List<IOption> Options
        {
            get
            {
                return this.options;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DShirt()
        {
            this.options = new List<IOption>();
            var color = new Color
            {
                Options = new List<Property>
                {
                    new Property { Description ="", Value = "Blue"},
                    new Property { Description ="", Value = "Red"}
                }
            };

            var size = new Size
            {
                Options = new List<Property>
                {
                    new Property { Description ="", Value = 39},
                    new Property { Description ="", Value = 40}
                }
            };

            this.Options.Add(color);
            this.Options.Add(size);
        }

        /// <summary>
        /// Trading action.
        /// </summary>
        /// <param name="tradeType">Trading type sell or buy</param>
        /// <param name="number">Number of trading action.</param>
        /// <returns>Result of trading</returns>
        public string Trade(TradeType tradeType, int number, List<IOption> options)
        {
            switch (tradeType)
            {
                case TradeType.Sell:
                    trade = new SellTrading();
                    return trade.Execute(SellRate, number, options);
                case TradeType.Buy:
                    trade = new BuyTrading();
                    return trade.Execute(BuyRate, number, options);
                default:
                    return "Trade type is invalid";
            }
        }

        /// <summary>
        /// Adjust sell rate.
        /// </summary>
        /// <param name="rate">Sell rate</param>
        public void SetSellRate(int rate)
        {
            this.sellRate = rate;
        }

        /// <summary>
        /// Adjust buy rate.
        /// </summary>
        /// <param name="rate">buy rate</param>
        public void SetBuyRate(int rate)
        {
            this.buyRate = rate;
        }

        /// <summary>
        /// Set list options for clothes
        /// </summary>
        /// <param name="options">Options list</param>
        public void SetOption(List<IOption> options)
        {
            this.options = options;
        }
    }
}
