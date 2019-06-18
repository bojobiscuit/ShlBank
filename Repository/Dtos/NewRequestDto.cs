using System;

namespace Repository.Dtos
{
    public class NewRequestDto
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public bool IsValid()
        {
            if (UserId <= 1)
                return false;

            if (Description == null)
                return false;

            if (Amount == 0)
                return false;

            return true;
        }
    }
}
