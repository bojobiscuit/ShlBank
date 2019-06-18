using System.Collections.Generic;
using Repository.Dtos;
using Repository.Interfaces;

namespace Repository.Implementations
{
    public class BankRepository : IBankRepository
    {
        public int? AddBankTransaction(NewPurchaseDto purchase)
        {
            throw new System.NotImplementedException();
        }

        public List<RequestOptionDto> GetLastCompletedRequests(int count)
        {
            throw new System.NotImplementedException();
        }

        public List<TransactionOptionDto> GetLastRequests(int userId, int count)
        {
            throw new System.NotImplementedException();
        }

        public List<UserAccountDto> GetMatchingUsers(List<string> submittedNames)
        {
            throw new System.NotImplementedException();
        }

        public List<RequestOptionDto> GetPendingRequests()
        {
            throw new System.NotImplementedException();
        }

        public List<RequestOptionDto> GetPendingRequests(int userId)
        {
            throw new System.NotImplementedException();
        }

        public GroupRequestDto GetRequest(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<TeamDto> GetTeams()
        {
            throw new System.NotImplementedException();
        }

        public TransactionDto GetTransaction(int id)
        {
            throw new System.NotImplementedException();
        }

        public int? SubmitRequest(NewGroupRequestDto request)
        {
            throw new System.NotImplementedException();
        }

        public void ToggleFree500(int userId)
        {
            throw new System.NotImplementedException();
        }

        public void ToggleShlTraining(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}
