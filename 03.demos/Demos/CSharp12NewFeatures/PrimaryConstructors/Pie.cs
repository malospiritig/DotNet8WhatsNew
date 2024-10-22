
public class Pie(int id, string name, decimal price, IEnumerable<string> ingredients)
{

    public Pie(int id, string name, decimal price) : this(id, name, price, Enumerable.Empty<string>()) { }

    public int Id => id;
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = Math.Round(price, 2);
    public void DisplayIngredients()
    {
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine(ingredient);
        }
    }
}

