using Controle_Tintas.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Tintas.Domain.Queries
{
    internal class GetAllPaintStatusQuery
    {
        public GetAllPaintStatusQuery() { }
        public IEnumerable<string> Execute()
        {
            //get all users from database using UserRepository
            var statusess = new List<string> {"DISPONIVEL", "EM USO", "SOBRA" };
            return statusess;
        }
    }
}
