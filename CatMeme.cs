public class CatMeme
{
    public string Title { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public int UserId { get; set; }
    public DateTime PostDate { get; set; }
    public string LongName
    {
        get
        {
            return $"{Title} - {Description}";
        }
    }
}