namespace OOP3_Final_Pizza_Maker.Ingredients
{
    /// <summary>
    /// An ingredient factory class to produce ingredients for the pizza.
    /// </summary>
    public static class IngredientFactory
    {
        /// <summary>
        /// Creates a new ingredient for the pizza.
        /// </summary>
        /// <param name="ingredient">The ingredient type being made.</param>
        /// <returns>A pizza ingredient.</returns>
        public static IIngredient CreateIngredient(IngredientList ingredient)
        {
            IIngredient topping = null;

            switch (ingredient)
            {
                case IngredientList.BBQ:
                    topping = new BBQ();
                    break;
                case IngredientList.Marinara:
                    topping = new Marinara();
                    break;
                case IngredientList.Mozzarella:
                    topping = new Mozzarella();
                    break;
                case IngredientList.Gouda:
                    topping = new Gouda();
                    break;
                case IngredientList.Sausage:
                    topping = new Sausage();
                    break;
                case IngredientList.Pepperoni:
                    topping = new Pepperoni();
                    break;
                case IngredientList.ThickCrust:
                    topping = new ThickCrust();
                    break;
                case IngredientList.ThinCrust:
                    topping = new ThinCrust();
                    break;
            }

            return topping;
        }
    }
}
