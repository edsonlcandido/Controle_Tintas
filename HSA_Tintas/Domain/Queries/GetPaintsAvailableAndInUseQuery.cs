using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Queries
{
    //create a class similar to this for GetPaintsByStatusQuery named GetPaintsAvailableAndInUseQuery
    internal class GetPaintsAvailableAndInUseQuery
    {
        public GetPaintsAvailableAndInUseQuery() { }
        public IEnumerable<Models.PaintModel> Execute()
        {
            //get all paints from database using PaintRepository
            var paints = PaintRepository.GetAll().Result;
            //filter paints by status
            paints = paints.Where(p => p.Status == "Disponivel".ToUpper() || p.Status == "Em uso".ToUpper());
            return paints;
        }
    }
}
