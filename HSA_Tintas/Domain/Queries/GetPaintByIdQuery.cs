using Controle_Tintas.Data.Repositories;
using Controle_Tintas.Domain.Models;

namespace Controle_Tintas.Domain.Queries
{
    internal class GetPaintByIdQuery
    {
        public GetPaintByIdQuery() { }
        public PaintModel Execute(int id)
        {
            //get paint by id from database using PaintRepository
            PaintModel paint = PaintRepository.GetById(id).Result;
            return paint;
        }
    }
}
