using Contracts.Entities;
using Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class UserRepository : Repository<UserModel>, IUserRepository
    {
        public UserRepository()
        {
            Table = new List<UserModel>()
            {
                new UserModel(){ Id = 1, Login = "Admin", Password = "admin123", Name="Admin"},
                new UserModel(){ Id = 2, Login = "rkaszczuk", Password = "kaszczuk123", Name="Rafał Kaszczuk"},
                new UserModel(){ Id = 3, Login = "testclient", Password = "test123", Name="Testowy klient"},

            };
        }
        public LayerResult<UserModel> GetUserByLoginAndPassword(LoginUserModel loginUserModel)
        {
            return new LayerResult<UserModel>(Table.Single(x => x.Login == loginUserModel.Login && x.Password == loginUserModel.Password));
        }
    }
}
