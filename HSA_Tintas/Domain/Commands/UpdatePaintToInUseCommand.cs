using Controle_Tintas.Domain.Models;
using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Commands
{
    //UpdatePaintToUseCommand class similar to CreatePaintCommand
    internal class UpdatePaintToInUseCommand
    {
        public UpdatePaintToInUseCommand()
        {
        }
        //exectute method to update paint
        public async void Execute(PaintModel paintModel)
        {
            paintModel.Status = "EM USO";
            //use PaintRepository to update paint
            await PaintRepository.Update(paintModel);
        }
    }
}
