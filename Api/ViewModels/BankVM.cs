using System.Collections.Generic;
using Repository.Dtos;

namespace Api.ViewModels
{
    public class BankVM
    {
        public int UserId { get; set; }
        public bool IsBanker { get; set; }
        public List<TeamDto> Teams { get; set; }
        public List<RequestOptionDto> PendingRequestOptions { get; set; }
        public List<RequestOptionDto> CompletedRequestOptions { get; set; }
    }
}
