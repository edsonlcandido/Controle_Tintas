using Controle_Tintas.Domain.Models;
using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Commands
{
    internal class UpdatePaintToLeftoverCommand
    {
        public UpdatePaintToLeftoverCommand()
        {
        }
        //exectute method to update paint
        public async void Execute(PaintModel paintModel)
        {
            paintModel.Status = "SOBRA";
            //use PaintRepository to update paint
            await PaintRepository.Update(paintModel);
        }
    }
}
