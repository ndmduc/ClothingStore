using ClothingStore.Option;
using System.Collections.Generic;

namespace ClothingStore.Model
{
    /// <summary>
    /// Interface for trading: sell or buy.
    /// </summary>
    public interface ITrade
    {
        /// <summary>
        /// Execute action.
        /// </summary>
        /// <param name="rate">Sell or Buy rate</param>
        /// <param name="number">NUmber of sell or buy</param>
        /// <returns>Result string</returns>
        string Execute(int rate, int number, List<IOption> options);
    }
}
