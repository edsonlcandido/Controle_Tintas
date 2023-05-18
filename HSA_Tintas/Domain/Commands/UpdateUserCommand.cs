using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Tintas.Domain.Commands
{
    internal class UpdateUserCommand
    {
        public UpdateUserCommand() { }
        public void Execute(Models.UserModel user)
        {
            //update user in database using UserRepository
            Data.Repositories.UserRepository.Update(user);
        }
    }
}
