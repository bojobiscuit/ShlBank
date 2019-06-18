using System;
using System.Collections.Generic;

namespace Repository.Dtos
{
    public class GroupRequestDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int BankerId { get; set; }
        public string UserName { get; set; }
        public string BankerName { get; set; }
        public string Title { get; set; }
        public List<RequestDto> PendingTransactions { get; set; }
    }
}
