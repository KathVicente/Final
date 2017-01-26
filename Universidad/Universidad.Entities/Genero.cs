using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Universidad.Entities
{
    public class Genero
    {
        public Genero()
        {
            Alumnos = new List<Alumno>();
        }
        public int Id { get; set; }

        [StringLength(50), DisplayName("Descripcion")]

        public String Descripcion { get; set; }

        public List<Alumno> Alumnos { get; set; }

      }
}
