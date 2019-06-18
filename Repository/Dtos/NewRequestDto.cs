using System;

namespace Repository.Dtos
{
    public class NewRequestDto
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
