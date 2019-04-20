namespace ClothingStore.Model
{
    /// <summary>
    /// BuyTrading implementation for ITrade
    /// </summary>
    public class BuyTrading : ITrade
    {
        /// <summary>
        /// Result string.
        /// </summary>
        private string notify = @"You have buy {0} item of this one with rate {1}";

        /// <summary>
        /// Execute action.
        /// </summary>
        /// <param name="rate">Sell or Buy rate</param>
        /// <param name="number">NUmber of sell or buy</param>
        /// <returns>Result string</returns>
        public string Execute(int rate, int number)
        {
            return string.Format(notify, number, rate);
        }
    }
}
