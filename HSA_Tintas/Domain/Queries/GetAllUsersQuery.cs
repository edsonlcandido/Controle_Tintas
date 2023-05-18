using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Queries
{
    internal class GetAllUsersQuery
    {
        public GetAllUsersQuery() { }
        public IEnumerable<Models.UserModel> Execute()
        {
            //get all users from database using UserRepository
            var users = UserRepository.GetAll().Result;
            return users;
        }
    }
}
