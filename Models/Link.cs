

using System.ComponentModel.DataAnnotations;

public class Link
{
    [Key]
    public int Id { get; set; }
    public string ShortCut { get; set; }
    public string Url { get; set; }
}