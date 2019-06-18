using System;
using System.Collections.Generic;

namespace Repository.Dtos
{
    public class GroupRequestDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateDecision { get; set; }

        public List<RequestDto> PendingTransactions { get; set; }
    }
}
