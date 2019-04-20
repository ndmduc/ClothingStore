using ClothingStore.Option;
using System.Collections.Generic;

namespace ClothingStore.Model
{
    /// <summary>
    /// Inteface for clothes.
    /// </summary>
    public interface IClothes
    {
        /// <summary>
        /// Sell rate
        /// </summary>
        int SellRate { get; }

        /// <summary>
        /// Buy rate
        /// </summary>
        int BuyRate { get; }

        /// <summary>
        /// Properties of clothes.
        /// </summary>
        List<IOption> Options { get;  }

        /// <summary>
        /// Adjust sell rate.
        /// </summary>
        /// <param name="rate">Sell rate</param>
        void SetSellRate(int rate);

        /// <summary>
        /// Adjust buy rate.
        /// </summary>
        /// <param name="rate">buy rate</param>
        void SetBuyRate(int rate);

        /// <summary>
        /// Set list options for clothes
        /// </summary>
        /// <param name="options">Options list</param>
        void SetOption(List<IOption> options);

        /// <summary>
        /// Trading action.
        /// </summary>
        /// <param name="tradeType">Trading type sell or buy</param>
        /// <param name="number">Number of trading action.</param>
        /// <returns>Result of trading</returns>
        string Trade(TradeType tradeType, int number, List<IOption> options);
    }
}
