using System;

namespace Repository.Dtos
{
    public class NewPurchaseDto
    {
        public int CreatorId { get; set; }
        public int BankerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public bool IsValid()
        {
            if (Amount == 0)
                return false;

            if (CreatorId <= 1 || BankerId <= 1)
                return false;

            if (Title == null || Description == null)
                return false;

            return true;
        }
    }
}
