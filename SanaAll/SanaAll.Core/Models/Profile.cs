using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SanaAll.Core.Models
{
    public class Profile
    {
        public Profile()
        {
            ProfileId = Guid.NewGuid();
        }

        [Key]
        public Guid ProfileId { get; set; }
        
        public string IDType { get; set; }
        public string IDNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Website { get; set; }
        public string ContactNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
        public string Note { get; set; }

        //Navigational Properties
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
