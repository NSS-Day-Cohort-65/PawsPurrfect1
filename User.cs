public class User
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string UserName { get; set; }
    public override string ToString()
    {
        return Name;
    }
}