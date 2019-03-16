using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Models
{
    public class UserModel
    {
        public static IList<UserModel> Users = new List<UserModel>
        {
            new UserModel { Id = 1, Username = "User1", FirstName = "User", LastName = "1", Title = "Mr."},
            new UserModel { Id = 2, Username = "User2", FirstName = "User", LastName = "2", Title = "Mr."},
            new UserModel { Id = 3, Username = "User3", FirstName = "User", LastName = "3", Title = "Miss"},
            new UserModel { Id = 4, Username = "User4", FirstName = "User", LastName = "4", Title = "Miss"},
            new UserModel { Id = 5, Username = "User5", FirstName = "User", LastName = "5", Title = "Mr."},
            new UserModel { Id = 6, Username = "User7", FirstName = "User", LastName = "6", Title = "Mr."},
            new UserModel { Id = 7, Username = "User7", FirstName = "User", LastName = "7", Title = "Mr."},
            new UserModel { Id = 8, Username = "User8", FirstName = "User", LastName = "8", Title = "Mr."},
            new UserModel { Id = 9, Username = "User9", FirstName = "User", LastName = "9", Title = "Mr."},
            new UserModel { Id = 10, Username = "User10", FirstName = "User", LastName = "10", Title = "Mr."}
        };

        public static int IdSequence = 10;

        public int Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }
    }
}

