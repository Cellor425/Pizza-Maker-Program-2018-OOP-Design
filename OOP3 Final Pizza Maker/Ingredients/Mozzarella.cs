namespace OOP3_Final_Pizza_Maker.Ingredients
{
    /// <summary>
    /// A mozzarella cheese object.
    /// </summary>
    public class Mozzarella : IIngredient
    {
        /// <summary>
        /// The type of ingredient.
        /// </summary>
        private IngredientType type = IngredientType.Cheese;

        /// <summary>
        /// The price of the ingredient.
        /// </summary>
        private decimal price = 0.40m;

        /// <summary>
        /// Gets the price of the ingredient.
        /// </summary>
        public decimal GetPrice
        {
            get
            {
                return this.price;
            }
        }

        /// <summary>
        /// Gets the type of ingredient.
        /// </summary>
        public IngredientType Type
        {
            get
            {
                return this.type;
            }
        }
    }
}
