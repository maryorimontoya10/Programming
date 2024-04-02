using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Shared.Entidades
{
    public class Pet
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Mascota")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Foto Mascota")]
        public string ImageUrl { get; set; }


        [Display(Name = "Raza")]
        [MaxLength(50, ErrorMessage = "No se permiten más de 50 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Race { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)] //La fecha tiene que tener un formato específico
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public DateTime Born { get; set; }

        public string Remarks { get; set; }

        //Relaciones
        public Owner Owner { get; set; }

        public PetType PetTypes { get; set; }

        public ICollection<History> Histories { get; set; } //Relación uno a muchos (IColletion)

        public ICollection<Agenda> Agendas { get; set; }


    }
}
