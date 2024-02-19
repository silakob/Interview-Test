using Interview_Test.Models;
using System.Data;

namespace Interview_Test.Repositories;

public static class Data
{
    public static List<UserModel> Users =>
    [
        new UserModel
        {
            Id = "user02",
            Username = "Bob.M.Jackson",
            UserProfile = new UserProfileModel
            {
                FirstName = "Bob",
                LastName = "Jackson",
                Age = 28
            },
            UserRoleMappings = new List<UserRoleMappingModel>
            {
                new()
                {
                    UserId = "user02",
                    RoleId = 3,
                    User = new UserModel
                    {
                        Id = "user01",
                        Username = "John.D.Smith",
                        UserProfile = new UserProfileModel
                        {
                            FirstName = "John",
                            LastName = "Smith",
                            Age = 28
                        }
                    },
                    Role = new()
                    {
                        RoleId = 3,
                        RoleName = "document operation",
                        Permissions =
                        [
                            "3-01-printing-label",
                            "2-04-packing-report",
                            "1-04-picking-report"
                        ]
                    }
                }
            }
        },
        new UserModel
        {
            Id = "user01",
            Username = "John.D.Smith",
            UserProfile = new UserProfileModel
            {
                FirstName = "John",
                LastName = "Smith",
                Age = null
            },
            UserRoleMappings = new List<UserRoleMappingModel>
            {
                new()
                {
                    UserId = "user01",
                    RoleId = 1,
                    User = new UserModel
                    {
                        Id = "user01",
                        Username = "John.D.Smith",
                        UserProfile = new UserProfileModel
                        {
                            FirstName = "John",
                            LastName = "Smith",
                            Age = null
                        }
                    },
                    Role = new()
                    {
                        RoleId = 1,
                        RoleName = "pick operation",
                        Permissions =
                        [
                            "3-01-printing-label",
                            "1-04-picking-report",
                            "1-01-picking-info",
                            "1-03-picking-confirm",
                            "1-02-picking-start"
                        ]
                    }
                },
                new()
                {
                    UserId = "user01",
                    RoleId = 2,
                    User = new UserModel
                    {
                        Id = "user01",
                        Username = "John.D.Smith",
                        UserProfile = new UserProfileModel
                        {
                            FirstName = "John",
                            LastName = "Smith",
                            Age = null
                        }
                    },
                    Role = new()
                    {
                        RoleId = 2,
                        RoleName = "pack operation",
                        Permissions =
                        [
                            "2-03-packing-confirm",
                            "2-04-packing-report",
                            "1-04-picking-report",
                            "2-02-packing-start",
                            "3-01-printing-label",
                            "2-01-packing-info"
                        ]
                    }
                },
                new()
                {
                    UserId = "user01",
                    RoleId = 3,
                    User = new UserModel
                    {
                        Id = "user01",
                        Username = "John.D.Smith",
                        UserProfile = new UserProfileModel
                        {
                            FirstName = "John",
                            LastName = "Smith",
                            Age = null
                        }
                    },
                    Role = new()
                    {
                        RoleId = 3,
                        RoleName = "document operation",
                        Permissions =
                        [
                            "3-01-printing-label",
                            "2-04-packing-report",
                            "1-04-picking-report"
                        ]
                    }
                }
            }
        }
    ];

    public static List<User> _users =>
    [
       new User
        {
            Id = "user01",
            Username = "John.D.Smith",
            FirstName = "John",
            LastName = "Smith",
           Age = null,
            Roles = new List<Role>
            {
            new Role { RoleId = 1, RoleName = "pick operation" },
            new Role { RoleId = 2, RoleName = "pack operation" },
            new Role { RoleId = 3, RoleName = "document operation" }
            },
            Permissions = [
                "1-01-picking-info",
                "1-02-picking-start",
                "1-03-picking-confirm",
                "1-04-picking-report",
                "2-01-packing-info",
                "2-02-packing-start",
                "2-03-packing-confirm",
                "2-04-packing-report",
                "3-01-printing-label"
            ]
        },
        new User
        {
           Id = "user02",
            Username = "Bob.M.Jackson",
            FirstName = "Bob",
            LastName = "Jackson",
            Age = 28,
            Roles = new List<Role>
            {
            new Role { RoleId = 3, RoleName = "document operation" }
            },
            Permissions = [
                "1-04-picking-report",
                "2-04-packing-report",
                "3-01-printing-label"
            ]
        }
    ];
}