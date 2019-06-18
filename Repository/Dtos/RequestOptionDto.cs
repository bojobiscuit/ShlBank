using System;

namespace Repository.Dtos
{
    public class RequestOptionDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public int CreatorId { get; set; }
        public string CreatorUserName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
