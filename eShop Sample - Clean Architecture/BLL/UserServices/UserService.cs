using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Entities;
using Contracts.Services;

namespace BLL.UserServices
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public LayerResult<UserModel> GetById(int Id)
        {
            var userResult = userRepository.GetById(Id);
            if (userResult.Result == null && userResult.IsSuccess)
            {
                userResult.AddError(null, "Nie ma użytkownika o tym ID", LayerErrorType.Error);
            }
            return userResult;
        }

        public LayerResult<UserModel> Login(string login, string password)
        {
            try
            {
                var loginData = new LoginUserModel()
                {
                    Login = login,
                    Password = password
                };
                var userResult = userRepository.GetUserByLoginAndPassword(loginData);

                if (userResult.Result == null && userResult.IsSuccess)
                {
                    userResult.AddError(null, "Błędne dane logowania", LayerErrorType.Error);
                }
                return userResult;
            }
            catch(Exception ex)
            {
                var result = new LayerResult<UserModel>(null);
                result.AddError(ex, "Błąd wewnętrzny", LayerErrorType.Critical);
                return result;
            }
        }
    }
}
