using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Universidad.Entities;

namespace Universidad.MVC.DTO
{
    public class GeneroDto
    {
        public class Genero
        {
           
            public int Id { get; set; }

            public String Descripcion { get; set; }

            public List<Alumno> Alumnos { get; set; }

        }
        
    }
}