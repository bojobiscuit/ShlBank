using System.Collections.Generic;
using Repository.Dtos;

namespace Api.ViewModels
{
    public class BankAccountVM
    {
        public UserAccountDto User { get; set; }
        public List<TransactionOptionDto> RecentTransactionOptions { get; set; }
        public List<RequestOptionDto> PendingRequestOptions { get; set; }
    }
}
