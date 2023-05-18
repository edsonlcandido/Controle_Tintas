using Controle_Tintas.Data.Repositories;
using Controle_Tintas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Tintas.Domain.Queries
{
    internal class GetUserByIdQuery
    {
        public GetUserByIdQuery() { }
        public UserModel Execute(int id)
        {
            //get user by id from database using UserRepository
            UserModel user = UserRepository.GetById(id).Result;
            return user;
        }
    }
}
