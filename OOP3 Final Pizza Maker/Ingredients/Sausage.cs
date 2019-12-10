namespace OOP3_Final_Pizza_Maker.Ingredients
{
    /// <summary>
    /// A sausage meat object.
    /// </summary>
    public class Sausage : IIngredient
    {
        /// <summary>
        /// The type of ingredient.
        /// </summary>
        private IngredientType type = IngredientType.Meat;

        /// <summary>
        /// The price of the ingredient.
        /// </summary>
        private decimal price = 1.49m;

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
