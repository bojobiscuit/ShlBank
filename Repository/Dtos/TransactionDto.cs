using System;

namespace Repository.Dtos
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? BankerId { get; set; }
        public string BankerUserName { get; set; }
        public int? GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDecision { get; set; }
    }
}
