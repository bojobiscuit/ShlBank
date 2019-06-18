using Api.ViewModels;

namespace Api.Interfaces
{
    public interface ISubmitRequestService
    {
        SubmitRequestVM GetRequest(int userId);
        SubmitRequestVM GetUsersForRequest(int userId, SubmitRequestVM submitRequest);
        SubmitRequestVM SubmitRequest(int userId, SubmitRequestVM submitRequest);
    }
}
