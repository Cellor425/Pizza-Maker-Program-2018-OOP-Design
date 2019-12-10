using OOP3_Final_Pizza_Maker.Ingredients;
using System;
using System.Collections.Generic;

namespace OOP3_Final_Pizza_Maker.Pizzas
{
    /// <summary>
    /// A pizza that is made by the user.
    /// </summary>
    public abstract class Pizza
    {
        /// <summary>
        /// A list of ingridients for the pizza.
        /// </summary>
        private List<IIngredient> ingredients = new List<IIngredient>();

        /// <summary>
        /// Gets or sets the state of the pizza.
        /// </summary>
        public IPizzaState PizzaState { get; set; }

        /// <summary>
        /// Gets a list of ingridients as an enumerable for the pizza.
        /// </summary>
        public List<IIngredient> Ingredients
        {
            get
            {
                return this.ingredients;
            }
        }

        /// <summary>
        /// An override of the deafult string display for the pizza.
        /// </summary>
        /// <returns>A string describing the pizza.</returns>
        public override string ToString()
        {
            string returnStr = string.Format("({0}) {1} Pizza:\nIngredients:\n", this.PizzaState.GetType().Name, this.GetType().Name);
            this.ingredients.ForEach((i) => returnStr += i.GetType().Name + "\n");

            return returnStr;
        }

        /// <summary>
        /// Adds an ingredient to the pizza.
        /// </summary>
        /// <param name="ingredient">The ingredient being added.</param>
        public void AddIngredient(IIngredient ingredient)
        {
            // If it is crust or sauce ...
            if (ingredient.Type == IngredientType.Sauce)
            {
                // Check if there is a sauce already in the ingredients ...
                this.ingredients.ForEach((i) =>
                {
                    if (i.Type == IngredientType.Sauce)
                    {
                        throw new Exception("There is already a crust ingredient on this pizza. Cannot add another.");
                    }
                });

                // Add the ingredient if no exception is passed ...
                this.ingredients.Add(ingredient);
            }
            else if (ingredient.Type == IngredientType.Crust)
            {
                // Check if there is a crust already in the ingredients ...
                this.ingredients.ForEach((i) =>
                {
                    if (i.Type == IngredientType.Crust)
                    {
                        throw new Exception("There is already a crust ingredient on this pizza. Cannot add another.");
                    }
                });

                // Add the ingredient if no exception is passed ...
                this.ingredients.Add(ingredient);
            }
            else
            {
                // Add it to the list ...
                this.ingredients.Add(ingredient);
            }
        }

        /// <summary>
        /// Calculates the full price of the pizza.
        /// </summary>
        /// <returns>The full price.</returns>
        public abstract decimal CalculatePrice();

        /// <summary>
        /// Calculates the price of the sauce.
        /// </summary>
        /// <returns>The sauce price.</returns>
        public abstract decimal CalculateSauce();

        /// <summary>
        /// Calculates the price of the cheese.
        /// </summary>
        /// <returns>The cheese price.</returns>
        public abstract decimal CalculateCheese();

        /// <summary>
        /// Calcuclates the price of the meat.
        /// </summary>
        /// <returns>The meat price.</returns>
        public abstract decimal CalculateMeat();

        /// <summary>
        /// Calculates the price of the crust.
        /// </summary>
        /// <returns>The crust price.</returns>
        public abstract decimal CalculateCrust();
    }
}
