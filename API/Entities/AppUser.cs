
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AppUser
    {
        //use [Key] if primarykey not Id
        public int Id { get; set; }
        public string UserName { get; set; } 

        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt {get; set;}

    }
}