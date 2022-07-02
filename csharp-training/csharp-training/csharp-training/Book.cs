namespace CSharpTraining;

public class Book
{
    public string Title { get; set; }
    public decimal Price { get; set; }

    public Book(string title, decimal price)
    {
        Title = title;
        Price = price;
    }
}