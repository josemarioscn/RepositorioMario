using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAltura.Models
{
    public enum MascotaType
    {
        Perro = 0,
        Gato = 1,
        Hamster = 2,
        Tortuga = 3,
        Analuisa = 4,
        Revollo = 5,
    }
    public class AlturaCliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El nombre del cliente debe tener mas de 3 letras")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La altura es requerida")]
        [Display(Name = "Altura")]
        public int Altura { get; set; }

        [Required(ErrorMessage = "La mascota es requerida")]
        [Display(Name = "Mascota")]
        public MascotaType Mascota { get; set; }

    }
}
