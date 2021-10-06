using Microsoft.Azure.Cosmos;
using RecipeBook.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using User = RecipeBook.Models.User.User;

namespace RecipeBook.Data.Users
{
    public class UserService : IUserService
    {
        private Container _container;

        public UserService(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public Task Login(User user)
        {
            throw new NotImplementedException();
        }

        public Task PasswordReset(User user)
        {
            throw new NotImplementedException();
        }

        public Task Register(User user)
        {
            throw new NotImplementedException();
        }
    }
}
