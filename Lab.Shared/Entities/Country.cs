using Lab.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Shared.Entities
{
    public class Country
    {

        public int Id { get; set; }

        [Display(Name = "País")]  //{0}
        [MaxLength(100, ErrorMessage = "Cuidado el campo {0} no permite más de {1} caracteres ")]  //{1}
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null;

        public ICollection<State>? States { get; set; }

        //Contamos  Estados por Pais

        [Display(Name = "Estados/Departamentos")]
        public int StatesNumber => States == null ? 0 : States.Count;





    }
}
