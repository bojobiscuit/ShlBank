using System.Collections.Generic;
using Repository.Dtos;

namespace Repository.Interfaces
{
    public interface IBankRepository
    {
        TransactionDto GetTransaction(int id);
        GroupRequestDto GetRequest(int id);

        List<TransactionOptionDto> GetLastRequests(int userId, int count);
        List<RequestOptionDto> GetPendingRequests();
        List<RequestOptionDto> GetPendingRequests(int userId);
        List<RequestOptionDto> GetLastCompletedRequests(int count);
        List<TeamDto> GetTeams();
        List<UserAccountDto> GetMatchingUsers(List<string> submittedNames);

        int? SubmitRequest(GroupRequestDto request);
        int? AddBankTransaction(NewPurchaseDto purchase);

        void ToggleFree500(int userId);
        void ToggleShlTraining(int userId);
    }
}
