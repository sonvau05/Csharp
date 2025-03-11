public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author) => (Title, Author) = (title, author);
    public override string ToString() => $"{Title} by {Author}";
}