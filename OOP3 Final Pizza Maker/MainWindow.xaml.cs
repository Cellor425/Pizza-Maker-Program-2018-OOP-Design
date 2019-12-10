using System.Windows;
using OOP3_Final_Pizza_Maker.Pizzas;
using System.Collections.Generic;
using OOP3_Final_Pizza_Maker.Ingredients;

namespace OOP3_Final_Pizza_Maker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The pizza being used to test the program.
        /// </summary>
        Pizza pizza = null;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates the pizza(Template).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatePizza_Click(object sender, RoutedEventArgs e)
        {
            this.pizza = PizzaFactory.CreatePizza(PizzaSize.Medium);
            this.PizzaLbl.Text = this.pizza.ToString();
            this.PriceLbl.Content = string.Format("Price: {0:C}", this.pizza.CalculatePrice());
        }

        /// <summary>
        /// Adds the ingredients(Factory).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIngredientBtn_Click(object sender, RoutedEventArgs e)
        {
            this.pizza.AddIngredient(IngredientFactory.CreateIngredient(IngredientList.ThinCrust));
            this.pizza.AddIngredient(IngredientFactory.CreateIngredient(IngredientList.Marinara));
            this.pizza.AddIngredient(IngredientFactory.CreateIngredient(IngredientList.Mozzarella));
            this.pizza.AddIngredient(IngredientFactory.CreateIngredient(IngredientList.Pepperoni));

            // This should throw exceptions
            // this.pizza.AddIngredient(IngredientFactory.CreateIngredient(IngredientList.ThickCrust));
            // this.pizza.AddIngredient(IngredientFactory.CreateIngredient(IngredientList.BBQ));

            this.PizzaLbl.Text = this.pizza.ToString();
            this.PriceLbl.Content = string.Format("Price: {0:C}", this.pizza.CalculatePrice());
        }

        /// <summary>
        /// Processes the pizza(State).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.pizza.PizzaState.GetType() == typeof(Unfinished))
            {
                this.pizza.PizzaState.Process(this.pizza, PizzaStates.Cooked);
            }
            else if (this.pizza.PizzaState.GetType() == typeof(Cooked))
            {
                this.pizza.PizzaState.Process(this.pizza, PizzaStates.Final);
            }
            else if (this.pizza.PizzaState.GetType() == typeof(Final))
            {
                // this should throw exception
                // this.pizza.PizzaState.Process(this.pizza, PizzaStates.TakeNBake);
            }

            this.PizzaLbl.Text = this.pizza.ToString();
            this.PriceLbl.Content = string.Format("Price: {0:C}", this.pizza.CalculatePrice());
        }
    }
}
