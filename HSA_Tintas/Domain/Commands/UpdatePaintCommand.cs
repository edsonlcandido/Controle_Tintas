using Controle_Tintas.Domain.Models;
using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Commands
{
    //UpdatePaint class similar to update paint to use
    internal class UpdatePaintCommand
    {
        public UpdatePaintCommand()
        {
        }
        //exectute method to update paint
        public async Task Execute(PaintModel paintModel)
        {
            //use PaintRepository to update paint
            await PaintRepository.Update(paintModel);
        }
    }
}
