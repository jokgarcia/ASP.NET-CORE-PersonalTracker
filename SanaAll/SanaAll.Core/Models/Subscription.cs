using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanaAll.Core.Models
{
    public class Subscription
    {
        public Subscription()
        {
            SubscriptionId = Guid.NewGuid();
        }

        [Key]
        public Guid SubscriptionId { get; set; }
        public string SubscriptionName { get; set; }
        public string AccountNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Decimal Price { get; set; }
        public string Website { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }

        //Navigational Properties
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
