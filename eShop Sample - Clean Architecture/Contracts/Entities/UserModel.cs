using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public class UserModel : IEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
