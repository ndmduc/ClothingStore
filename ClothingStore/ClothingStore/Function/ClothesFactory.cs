using ClothingStore.Model;

namespace ClothingStore.Function
{
    /// <summary>
    /// For create clothes include TShirt or DShirt
    /// </summary>
    public class ClothesFactory
    {
        /// <summary>
        /// Create clothes item.
        /// </summary>
        /// <param name="clothes">Clothes type.</param>
        /// <returns>CLothes item.</returns>
        public IClothes GetClothes(ClothesType clothes)
        {
            switch (clothes)
            {
                case ClothesType.TShirt:
                    return new TShirt();
                case ClothesType.DShirt:
                    return new DShirt();
                default:
                    return null;
            }
        }
    }
}
