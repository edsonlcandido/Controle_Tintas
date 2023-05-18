using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Commands
{
    internal class DeleteUserCommand
    {
        public DeleteUserCommand()
        {
        }
        public async Task Execute(int Id)
        {
            //delete user from database using UserRepository
            await UserRepository.Delete(Id);
        }
    }
}