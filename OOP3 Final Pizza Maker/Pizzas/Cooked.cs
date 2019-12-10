using System;

namespace OOP3_Final_Pizza_Maker.Pizzas
{
    /// <summary>
    /// An abstract class for a cooked pizza.
    /// </summary>
    public class Cooked : IPizzaState
    {
        /// <summary>
        /// Processes the pizza and changes it's state.
        /// </summary>
        /// <param name="pizza">The pizza being processed.</param>
        /// <param name="state">The pizza state being processed too.</param>
        public void Process(Pizza pizza, PizzaStates state)
        {
            // It can only be changed to final as you cannot uncook something.
            if (state != PizzaStates.Final)
            {
                throw new Exception("Cannot change pizza state to non final object. Finalize the pizza or start over.");
            }
            else
            {
                pizza.PizzaState = new Final();
            }
        }
    }
}
