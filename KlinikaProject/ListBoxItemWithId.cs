public class ListBoxItemWithId
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ListBoxItemWithId(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public override string ToString()
    {
        return Name; // GÖRÜNƏN BUDUR!
    }
}
