using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace BLL.Models;

public class User
{
    public int Id { get; set; }
   
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public int Role { get; set; }
}
