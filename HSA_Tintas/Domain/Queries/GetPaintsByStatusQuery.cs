using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Queries
{
    //creata a class GetPaintsByStatusQuery similar to GetAllPaintsQuery
    internal class GetPaintsByStatusQuery
    {
        public GetPaintsByStatusQuery() { }
        public IEnumerable<Models.PaintModel> Execute(string status)
        {
            //get all paints from database using PaintRepository
            var paints = PaintRepository.GetAll().Result;
            //filter paints by status
            paints = paints.Where(p => p.Status == status).OrderBy(p => p.ExpirationDate);
            return paints;
        }
    }
}
