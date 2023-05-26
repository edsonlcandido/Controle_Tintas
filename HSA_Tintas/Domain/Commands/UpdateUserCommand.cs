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
        public async Task Execute(Models.UserModel user)
        {
            //update user in database using UserRepository
            await Data.Repositories.UserRepository.Update(user);
        }
    }
}
