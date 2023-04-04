namespace MyFirstBlazorApp.Data
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            // Call your data access technology here
            var pizzas = new[]
            {
        new Pizza { Name = "Margherita", Description = "Tomato sauce, mozzarella, and basil", BasePrice = 9 },
        new Pizza { Name = "Pepperoni", Description = "Tomato sauce, mozzarella, and pepperoni", BasePrice = 11 },
        new Pizza { Name = "Hawaiian", Description = "Tomato sauce, mozzarella, ham, and pineapple", BasePrice = 12 },
    };

            return Task.FromResult(pizzas);
        }

    }
}
