using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Shared.Entidades
{
    public class PetType
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Mascota")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }    
    }
}
