namespace OOP3_Final_Pizza_Maker.Pizzas
{
    /// <summary>
    /// A final pizza state ready for pickup.
    /// </summary>
    public class Final : IPizzaState
    {
        /// <summary>
        /// Processes the pizza and changes it's state.
        /// </summary>
        /// <param name="pizza">The pizza being processed.</param>
        /// <param name="state">The pizza state being processed too.</param>
        public void Process(Pizza pizza, PizzaStates state)
        {
            // Final pizza state, cannot be changed.
        }
    }
}
