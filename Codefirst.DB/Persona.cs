
using System.ComponentModel.DataAnnotations;

namespace Codefirst.DB
{
    public class Persona
    {
        [Key]
        [StringLength(8)]
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
