using Repository.Dtos;
using Api.ViewModels;

namespace Api.Interfaces
{
    public interface IBankAccountService
    {
        BankAccountVM GetBankAccountVM(int userId);
        int? AddPurchase(NewPurchaseDto purchase);
        void ToggleFree500(int userId);
        void ToggleShlTraining(int userId);
    }
}
