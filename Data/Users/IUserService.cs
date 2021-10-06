using RecipeBook.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBook.Data.Users
{
    public interface IUserService
    {
        public Task Login(User user);

        public Task PasswordReset(User user);

        public Task Register(User user);
    }
}
