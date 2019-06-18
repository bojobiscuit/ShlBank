using System;

namespace Repository.Dtos
{
    public class NewPurchaseDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BankerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
