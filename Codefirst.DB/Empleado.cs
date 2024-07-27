using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codefirst.DB
{
    public class Empleado
    {
        [Key]
        //para que sea incremental
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Area { get; set; }
        public string PersonaDNI { get; set; }

        [ForeignKey("PersonaDNI")]
        public virtual Persona Persona { get; set; }

    }
}
