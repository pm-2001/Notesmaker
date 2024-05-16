using Microsoft.AspNetCore.Identity;

namespace authpr.Models;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

}
