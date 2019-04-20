using ClothingStore.Option;
using System.Collections.Generic;

namespace ClothingStore.Model
{
    /// <summary>
    /// SellTrading implementation for ITrade
    /// </summary>
    public class SellTrading : ITrade
    {
        /// <summary>
        /// Result string.
        /// </summary>
        private string notify = @"You have sell {0} item of this one with rate {1}";

        /// <summary>
        /// Execute action.
        /// </summary>
        /// <param name="rate">Sell or Buy rate</param>
        /// <param name="number">NUmber of sell or buy</param>
        /// <returns>Result string</returns>
        public string Execute(int rate, int number, List<IOption> options)
        {
            return string.Format(notify, number, rate) + "\r\n" + OptionUtility.PrintOption(options);
        }
    }
}
