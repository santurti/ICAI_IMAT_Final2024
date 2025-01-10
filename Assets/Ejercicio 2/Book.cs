public class Book
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PageCount { get; set; }

    public Book(int id, string title, string author, string genre, int pageCount)
    {
        ID = id;
        Title = title;
        Author = author;
        Genre = genre;
        PageCount = pageCount;
    }
}

public class KidBook: Book
{
    public int RecomendedAge { get; set; }
    public KidBook(int recomendedAge, int id, string title, string author, string genre, int pageCount) : base(id, title, author, genre, pageCount)
    {
        RecomendedAge = recomendedAge;
    }
}

public class AdultBook : Book
{
    public string ComplexityLevel { get; set; }
    public AdultBook(string complexityLevel, int id, string title, string author, string genre, int pageCount) : base(id, title, author, genre, pageCount)
    {
        ComplexityLevel = complexityLevel;
    }
}