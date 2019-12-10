using OOP3_Final_Pizza_Maker.Ingredients;

namespace OOP3_Final_Pizza_Maker.Pizzas
{
    /// <summary>
    /// A small pizza object.
    /// </summary>
    public class Small : Pizza
    {
        /// <summary>
        /// Initializes a new instance of the Small class.
        /// </summary>
        /// <param name="state">The pizza state of the pizza.</param>
        public Small()
        {
            this.PizzaState = new Unfinished();
        }

        /// <summary>
        /// Calculates the full price of the pizza.
        /// </summary>
        /// <returns>The full price.</returns>
        public override decimal CalculatePrice()
        {
            return this.CalculateCheese() + this.CalculateCrust() + this.CalculateMeat() + this.CalculateSauce() + 2.00m;
        }

        /// <summary>
        /// Calculates the price of the sauce.
        /// </summary>
        /// <returns>The sauce price.</returns>
        public override decimal CalculateSauce()
        {
            decimal price = 0.0m;

            // Get the price of the crust objects ...
            this.Ingredients.ForEach((i) => {
                if (i.Type == IngredientType.Sauce)
                {
                    price += i.GetPrice;
                }
            });

            return (price * 0.80m);
        }

        /// <summary>
        /// Calculates the price of the cheese.
        /// </summary>
        /// <returns>The cheese price.</returns>
        public override decimal CalculateCheese()
        {
            decimal price = 0.0m;

            // Get the price of the crust objects ...
            this.Ingredients.ForEach((i) => {
                if (i.Type == IngredientType.Cheese)
                {
                    price += i.GetPrice;
                }
            });

            return (price * 0.80m);
        }

        /// <summary>
        /// Calcuclates the price of the meat.
        /// </summary>
        /// <returns>The meat price.</returns>
        public override decimal CalculateMeat()
        {
            decimal price = 0.0m;

            // Get the price of the crust objects ...
            this.Ingredients.ForEach((i) => {
                if (i.Type == IngredientType.Meat)
                {
                    price += i.GetPrice;
                }
            });

            return (price * 0.60m);
        }

        /// <summary>
        /// Calculates the price of the crust.
        /// </summary>
        /// <returns>The crust price.</returns>
        public override decimal CalculateCrust()
        {
            decimal price = 0.0m;

            // Get the price of the crust objects ...
            this.Ingredients.ForEach((i) => {
                if (i.Type == IngredientType.Crust)
                {
                    price += i.GetPrice;
                }
            });

            return (price * 0.80m);
        }
    }
}
