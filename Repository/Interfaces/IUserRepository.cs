using System.Collections.Generic;
using Repository.Dtos;

namespace Repository.Interfaces
{
    public interface IUserRepository
    {
        UserAccountDto GetUserAccount(int id);
    }
}
