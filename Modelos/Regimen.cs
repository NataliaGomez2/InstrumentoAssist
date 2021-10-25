using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Regimen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IdRegimen { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Pacientes> Pacientes { get; set; }
    }
}
