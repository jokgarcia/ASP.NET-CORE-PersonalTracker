using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SanaAll.Core.Models
{
    public class User
    {
        public User()
        {
            UserId = Guid.NewGuid();
        }

        [Key]
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        [ForeignKey("UserId")]
        public ICollection<Profile> Profiles { get; set; }
    }
}
