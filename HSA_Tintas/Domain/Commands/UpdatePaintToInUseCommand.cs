using Controle_Tintas.Domain.Models;
using Controle_Tintas.Data.Repositories;
using Controle_Tintas.Domain.Queries;

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
            PaintModel paintModelBeforeUpdate;
            paintModelBeforeUpdate = new GetPaintByIdQuery().Execute(paintModel.Id);
            //veirfy if quanity of paintModelBeforeUpdate is greater than paintModel
            if (paintModelBeforeUpdate.CanQty > paintModel.CanQty)
            {
                PaintModel paintModelNew = paintModel;
                //use PaintRepository to update paint
                paintModelNew.Status = "EM USO";
                await new CreatePaintCommand().Execute(paintModelNew);
                //update paintModelBeforeUpdate.CanQty
                paintModelBeforeUpdate.CanQty = paintModelBeforeUpdate.CanQty - paintModelNew.CanQty;
                await PaintRepository.Update(paintModelBeforeUpdate);
            }
            else if(paintModelBeforeUpdate.CanQty == paintModel.CanQty)
            {
                paintModel.Status = "EM USO";
                //use PaintRepository to update paint
                await PaintRepository.Update(paintModel);
            }
            else
            {
                //throw a error that quantity of paintModelBeforeUpdate is less than paintModel
                throw new Exception("Quantidade de tinta a ser usada é maior que a quantidade de tinta disponível");
            }


        }
    }
}
