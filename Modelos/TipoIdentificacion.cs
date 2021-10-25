using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
        public class TipoIdentificacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IdTipoIdentificacion { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection <Pacientes> Pacientes { get; set; }
        
    }
}
