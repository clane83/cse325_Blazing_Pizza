namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<List<PizzaSpecial>> GetPizzasAsync()
    {
        return Task.FromResult(new List<PizzaSpecial>
        {
            new PizzaSpecial
            {
                Id = 1,
                Name = "Pepperoni",
                Description = "Classic pepperoni pizza",
                BasePrice = 10.99m,
                Vegetarian = false,
                Vegan = false
            },

            new PizzaSpecial
            {
                Id = 2,
                Name = "Veggie",
                Description = "Loaded with fresh vegetables",
                BasePrice = 11.99m,
                Vegetarian = true,
                Vegan = false
            },

            new PizzaSpecial
            {
                Id = 3,
                Name = "Vegan Special",
                Description = "Plant-based ingredients and vegan cheese",
                BasePrice = 12.99m,
                Vegetarian = true,
                Vegan = true
            }
        });
    }
}