using System;
using Repository.Dtos;
using Repository.Interfaces;
using Api.Interfaces;
using Api.ViewModels;

namespace Api.Implementations
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBankRepository _bankRepository;

        public BankAccountService(IUserRepository userRepository, IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public BankAccountVM GetBankAccountVM(int userId)
        {
            UserAccountDto userAccount = _userRepository.GetUserAccount(userId);
            if (userAccount != null)
                return null;

            var recentTransactions = _bankRepository.GetLastRequests(userId, 25);
            var pendingRequests = _bankRepository.GetPendingRequests(userId);

            BankAccountVM bankAccount = new BankAccountVM()
            {
                User = userAccount,
                RecentTransactionOptions = recentTransactions,
                PendingRequestOptions = pendingRequests
            };

            return bankAccount;
        }

        public int? AddPurchase(NewPurchaseDto purchase)
        {
            if (IsValid(purchase))
            {
                int? transactionId = _bankRepository.AddBankTransaction(purchase);
                return transactionId;
            }
            return null;
        }

        public void ToggleFree500(int userId)
        {
            _bankRepository.ToggleFree500(userId);
        }

        public void ToggleShlTraining(int userId)
        {
            _bankRepository.ToggleShlTraining(userId);
        }

        private bool IsValid(NewPurchaseDto purchase)
        {
            // TODO: Implement

            throw new NotImplementedException();
        }
    }
}
