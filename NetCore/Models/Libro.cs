﻿using System.ComponentModel.DataAnnotations;

namespace CrudNetCore.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caraccteres", MinimumLength =3)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} caraccteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public int Precio { get; set; }
    }
}
