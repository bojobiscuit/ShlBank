using Repository.Interfaces;
using Api.Interfaces;
using Api.ViewModels;

namespace Api.Implementations
{
    public class BankService : IBankService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBankRepository _bankRepository;

        public BankService(IUserRepository userRepository, IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public BankVM GetBankVM(int userId)
        {
            var userAccount = _userRepository.GetUserAccount(userId);
            if (userAccount == null)
                return null;

            var teams = _bankRepository.GetTeams();
            var pendingRequests = _bankRepository.GetPendingRequests();
            var completedRequests = _bankRepository.GetLastCompletedRequests(25);

            BankVM bankVM = new BankVM()
            {
                UserId = userAccount.Id,
                IsBanker = userAccount.IsBanker,
                Teams = teams,
                PendingRequestOptions = pendingRequests,
                CompletedRequestOptions = completedRequests
            };
            
            return bankVM;
        }
    }
}
