using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Controle_Tintas.Model
{
    internal class User
    {
        //create data model for User with data annotations
        [Key]
        [DisplayName("#")]
        public int Id { get; set; }
        //set required field
        //set display name
        //set data type
        [Required]
        [DisplayName("Nome de usuario")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DisplayName("Administrador")]
        public bool IsAdmin { get; set; }
    }
}
