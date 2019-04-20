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
        /// Sell rate property.
        /// </summary>
        public int SellRate { get => 20; }

        /// <summary>
        /// Buy rate property.
        /// </summary>
        public int BuyRate { get => 8; }

        /// <summary>
        /// List of property.
        /// </summary>
        public List<IOption> Options { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public DShirt()
        {
            this.Options = new List<IOption>();
            this.Options.Add(new Color());
            this.Options.Add(new Size());
        }

        /// <summary>
        /// Trading action.
        /// </summary>
        /// <param name="tradeType">Trading type sell or buy</param>
        /// <param name="number">Number of trading action.</param>
        /// <returns>Result of trading</returns>
        public string Trade(TradeType tradeType, int number)
        {
            switch (tradeType)
            {
                case TradeType.Sell:
                    trade = new SellTrading();
                    return trade.Execute(SellRate, number);
                case TradeType.Buy:
                    trade = new BuyTrading();
                    return trade.Execute(BuyRate, number);
                default:
                    return "Trade type is invalid";
            }
        }
    }
}
