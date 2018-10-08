using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.UserServices
{
    public interface IUserService
    {
        LayerResult<UserModel> Login(string login, string password);
        LayerResult<UserModel> GetById(int Id);
    }
}
