namespace OOP3_Final_Pizza_Maker.Pizzas
{
    /// <summary>
    /// A class for an unfishied pizza.
    /// </summary>
    public class Unfinished : IPizzaState
    {
        /// <summary>
        /// Processes the pizza and changes it's state.
        /// </summary>
        /// <param name="pizza">The pizza being processed.</param>
        /// <param name="state">The pizza state being processed too.</param>
        public void Process(Pizza pizza, PizzaStates state)
        {
            if (state == PizzaStates.TakeNBake)
            {
                pizza.PizzaState = new TakeNBake();
            }
            else if (state == PizzaStates.Cooked)
            {
                pizza.PizzaState = new Cooked();
            }
        }
    }
}
