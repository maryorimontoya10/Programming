﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Shared.Entidades
{
    public class Agenda
    {
        public int Id { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)] 
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name="Is Available")]
        public bool IsAvailable { get; set; }

        public Owner Owner { get; set; }
        public Pet Pet { get; set; }

    }
}
