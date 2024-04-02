using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Shared.Entidades
{
    public class History
    {
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "No se permiten más de 100 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd HH:mm}",ApplyFormatInEditMode = true)] //La fecha tiene que tener un formato específico
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        public DateTime DateLocal=>Date.ToLocalTime();


        //Relaciones
        public ServiceType ServiceTypes { get; set; } //Llave foránea

        public Pet Pet { get; set; }
    }
}
