namespace OOP3_Final_Pizza_Maker.Pizzas
{
    public interface IPizzaState
    {
        /// <summary>
        /// Processes the pizza and changes it's state.
        /// </summary>
        /// <param name="pizza">The pizza being processed.</param>
        /// <param name="state">The pizza state being processed too.</param>
        void Process(Pizza pizza, PizzaStates state);
    }
}
