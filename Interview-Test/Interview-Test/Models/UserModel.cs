using System.ComponentModel.DataAnnotations;

namespace Interview_Test.Models;

public class UserModel
{
    public string Id { get; set; }
    public string Username { get; set; }
    [Required]
    public UserProfileModel UserProfile { get; set; }
    [Required]
    public ICollection<UserRoleMappingModel> UserRoleMappings { get; set; }
}

public class User
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? Age { get; set; }
    public List<Role> Roles { get; set; }
    public List<string> Permissions { get; set; }
}
public class Role
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
}