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
        //          CanQty         DOUBLE,
        //          Liters         DOUBLE,
        //          InsertionDate  DATE,
        //          ExpirationDate DATE,
        //          Status         TEXT,
        //          Obs TEXT
        [DisplayName("#")]
        public int Id { get; set; }
        [DisplayName("Código")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "O campo Código é obrigatório")]
        public string Code { get; set; }
        [DisplayName("Projeto")]
        [DataType(DataType.Text)]        
        public string Project { get; set; }
        [DisplayName("Descrição")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string Description { get; set; }
        [DisplayName("Quant. de latas")]
        [Range(0, double.MaxValue, ErrorMessage = "A quantidade de latas deve ser maior ou igual a zero.")]
        public double CanQty { get; set; }
        [DisplayName("Litros p/lt")]
        [Range(0, double.MaxValue, ErrorMessage = "O volume em litros deve ser maior ou igual a zero.")]

        public double Liters { get; set; }
        [DisplayName("Data de inserção")]
        [DataType(DataType.Date)]
        public DateTime InsertionDate { get; set; }
        [DisplayName("Data de validade")]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
        [DisplayName("Status")]
        [DataType(DataType.Text)]
        public string Status { get; set; }
        [DisplayName("Obs.")]
        [DataType(DataType.Text)]
        public string Obs { get; set; }

        internal bool IsValid(out ICollection<ValidationResult> validationResults)
        {



            //validate data annotations
            validationResults = new List<ValidationResult>();

            //add custom validation to InsertDate
            if (InsertionDate >= DateTime.Now)  // validade the date is less than today
            {
                validationResults.Add(new ValidationResult("A Data de inserção deve ser menor ou igual ao dia de hoje.", new List<string> { "InsertDate" }));
            }

            //add custom validation to ExpirationDate
            if (ExpirationDate <= DateTime.Now.AddDays(1))  // validade the date is greater than today + 1
            {
                validationResults.Add(new ValidationResult("A Data de validade deve ser maior que o dia de hoje mais 1.", new List<string> { "ExpirationDate" }));
            }

            //add custom validation to project is not empty when código is 0
            if (Id == 0 && string.IsNullOrEmpty(Project))
            {
                validationResults.Add(new ValidationResult("O campo Projeto é obrigatório ao adicionar uma nova tinta", new List<string> { "Project" }));
            }

            return Validator.TryValidateObject(this, new ValidationContext(this), validationResults, true);
        }
    }
}
