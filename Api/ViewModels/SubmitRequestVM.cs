using System.Collections.Generic;
using Repository.Dtos;

namespace Api.ViewModels
{
    public class SubmitRequestVM
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool IsBanker { get; set; }
        public List<string> SubmittedNames { get; set; }
        public List<string> ErrorNames { get; set; }
        public List<UserAccountDto> MatchingUsers { get; set; }
        public GroupRequestDto Request { get; set; }
        public int? SubmittedRequestId { get; set; }
    }
}
