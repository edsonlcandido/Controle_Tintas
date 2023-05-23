using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Tintas.Domain.Models
{
    internal class PaintModel
    {
        //create data model for Paint with data annotations
        //          Id INTEGER PRIMARY KEY AUTOINCREMENT
        //                       UNIQUE,
        //          Code           TEXT,
        //          Project TEXT,
        //          Description    TEXT,
        //          CanQty DOUBLE,
        //          Liters         DOUBLE,
        //          ExpirationDate DATE,
        //          Status         TEXT,
        //          Obs TEXT
        [DisplayName("#")]
        public int Id { get; set; }
        [DisplayName("Código")]
        [DataType(DataType.Text)]
        public string Code { get; set; }
        [DisplayName("Projeto")]
        public string Project { get; set; }
        [DisplayName("Descrição")]
        public string Description { get; set; }
        [DisplayName("Quant. de latas")]
        public double CanQty { get; set; }
        [DisplayName("Litros")]
        public double Liters { get; set; }
        [DisplayName("Data de validade")]
        public DateTime ExpirationDate { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; }
        [DisplayName("Obs.")]
        public string Obs { get; set; }
    }
}
