using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Entities
{
    public class Alumno
    {
        public int AlumnoId { get; set; }

        public DateTime Created { get; set; }

        [StringLength(10), DisplayName("Codigo")]

        public String Codigo { get; set; }

        [StringLength(50), DisplayName("Apellidos")]

        public String Apellidos { get; set; }

        [StringLength(50), DisplayName("Nombres")]

        public String Nombres { get; set; }

        public int GeneroId { get; set; }

        public Genero Genero { get; set; }      
        
        public EstadoCivil EstadoCivil { get; set; }

        public int EstadoCivilId { get; set; }
        
    }
}
