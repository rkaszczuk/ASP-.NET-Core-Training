using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Services
{
    public interface IUserRepository : IRepository<UserModel>
    {
        LayerResult<UserModel> GetUserByLoginAndPassword(LoginUserModel loginUserModel);
    }
}
