using Controle_Tintas.Data.Repositories;

namespace Controle_Tintas.Domain.Queries
{
    //create a class similar to this for GetAllPaintsQueryByStatus
    internal class GetAllPaintsQuery
    {
        public GetAllPaintsQuery() { }
        public IEnumerable<Models.PaintModel> Execute()
        {
            //get all paints from database using PaintRepository
            var paints = PaintRepository.GetAll().Result;
            return paints;
        }
    }
}
