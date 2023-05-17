using Controle_Tintas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Tintas.Domain.Commands
{
    internal class CreateUserCommand
    {
        public CreateUserCommand() { }
        public async Task Execute(UserModel user)
        {
            //add user to database using UserRepository
            await Data.Repositories.UserRepository.Add(user);
        }
    }
}
