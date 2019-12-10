namespace OOP3_Final_Pizza_Maker.Pizzas
{
    /// <summary>
    /// A factory object used for creating pizzas.
    /// </summary>
    public static class PizzaFactory
    {
        /// <summary>
        /// Creates a new pizza object.
        /// </summary>
        /// <param name="size">The size of the pizza.</param>
        /// <returns>A new pizza object.</returns>
        public static Pizza CreatePizza(PizzaSize size)
        {
            Pizza pizza = null;

            switch (size)
            {
                case PizzaSize.Large:
                    pizza = new Large();
                    break;
                case PizzaSize.Medium:
                    pizza = new Medium();
                    break;
                case PizzaSize.Small:
                    pizza = new Small();
                    break;
            }

            return pizza;
        }
    }
}
