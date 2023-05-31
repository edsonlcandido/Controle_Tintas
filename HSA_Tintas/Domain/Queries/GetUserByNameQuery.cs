using Controle_Tintas.Data.Repositories;
using Controle_Tintas.Domain.Models;

namespace Controle_Tintas.Domain.Queries
{
    //create a class to GetUserByNameQuery
    internal class GetUserByNameQuery
    {
        public GetUserByNameQuery() { }
        public UserModel Execute(string name)
        {
            //get user by name from database using UserRepository
            UserModel user = UserRepository.GetByName(name).Result;
            return user;
        }
    }
}
