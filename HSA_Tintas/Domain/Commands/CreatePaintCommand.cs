using Controle_Tintas.Data.Repositories;
using Controle_Tintas.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Tintas.Domain.Commands
{
    //create a class command to create Paint and insert in database
    internal class CreatePaintCommand
    {
        public CreatePaintCommand()
        {

        }
        public async Task Execute(PaintModel paint)
        {
            //add paint to database using PaintRepository
            await PaintRepository.Add(paint);
        }
    }
}
