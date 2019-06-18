using Api.ViewModels;

namespace Api.Interfaces
{
    public interface IBankService
    {
        BankVM GetBankVM(int userId);
    }
}
