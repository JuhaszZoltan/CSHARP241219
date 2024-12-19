namespace CSHARP241219;

internal class Author
{
    public Guid GUID { get; set; }
    public string SurName { get; set; }
    public string FirstName { get; set; }

    public override string ToString() =>
        $"{FirstName} {SurName}";

    public Author(string fullName)
    {
        GUID = Guid.NewGuid();
        var nps = fullName.Split(' ');
        FirstName = nps[0];
        SurName = nps[1];
    }
}
