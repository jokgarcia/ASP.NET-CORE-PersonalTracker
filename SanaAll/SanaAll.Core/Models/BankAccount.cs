using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanaAll.Core.Models
{
    public class BankAccount
    {
        public BankAccount()
        {
            BankAcctId = Guid.NewGuid();
        }

        [Key]
        public Guid BankAcctId { get; set; }
        public string CardType { get; set; }
        public string CreditCardType { get; set; }
        public string BankName { get; set; }
        public string AccountNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CVV { get; set; }
        public string OTP { get; set; }
        public string Website { get; set; }
        public string ContactNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
