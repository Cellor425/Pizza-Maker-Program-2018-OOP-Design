namespace OOP3_Final_Pizza_Maker.Pizzas
{
    /// <summary>
    /// A class that is a take and bake pizza.
    /// </summary>
    public class TakeNBake : IPizzaState
    {
        /// <summary>
        /// Processes the pizza and changes it's state.
        /// </summary>
        /// <param name="pizza">The pizza being processed.</param>
        /// <param name="state">The pizza state being processed too.</param>
        public void Process(Pizza pizza, PizzaStates state)
        {
            // Check what state it will be changed to ...
            if (state == PizzaStates.Cooked)
            {
                pizza.PizzaState = new Cooked();
            }
            else if (state == PizzaStates.Final)
            {
                pizza.PizzaState = new Final();
            }
        }
    }
}
