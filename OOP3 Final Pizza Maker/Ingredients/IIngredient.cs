namespace OOP3_Final_Pizza_Maker.Ingredients
{
    /// <summary>
    /// An interface for all pizza ingredients.
    /// </summary>
    public interface IIngredient
    {
        /// <summary>
        /// Get the price of the ingredient.
        /// </summary>
        decimal GetPrice { get; }

        /// <summary>
        /// Get the type of the ingredient.
        /// </summary>
        IngredientType Type { get; }
    }
}
