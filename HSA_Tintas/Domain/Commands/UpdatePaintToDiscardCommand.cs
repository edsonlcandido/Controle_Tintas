using Controle_Tintas.Domain.Models;
using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Commands
{
    //UpdatePaintToDiscard class similar to update paint to use
    internal class UpdatePaintToDiscardCommand
    {
        public UpdatePaintToDiscardCommand()
        {
        }
        //exectute method to update paint
        public async void Execute(PaintModel paintModel)
        {
            paintModel.Status = "DESCARTADA";
            //use PaintRepository to update paint
            await PaintRepository.Update(paintModel);
        }
    }
}
