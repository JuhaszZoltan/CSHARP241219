namespace CSHARP241219;

internal class Book
{
    private int year;

    public long ISBN { get; set; }
    public List<Author> Authors { get; set; }
    public string Title { get; set; }
    public int Year
    {
        get => year;
        set
        {
            if (value < 2007 || value > DateTime.Today.Year)
                throw new Exception("invalid year");
            year = value;
        }
    }
    public string Language { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; }

    public override string ToString() =>
        $"\tID: ISBN{ISBN}\n" +
        $"\tTitle: {Title}\n" +
        $"\tAuthor{(Authors.Count == 1 ? "" : "s")}: " +
            $"{string.Join(", ", Authors)}\n";

    public Book(string title, params string[] authorNames)
    {
        ISBN = long.Parse(
            $"{Random.Shared.Next(10000, 100000)}" +
            $"{Random.Shared.Next(10000, 100000)}");

        Title = title;

        List<Author> tempAuts = [];
        foreach (var an in authorNames) tempAuts.Add(new(an));
        Authors = tempAuts;
    }
}
