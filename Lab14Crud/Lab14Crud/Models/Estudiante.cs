using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14Crud.Models
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime Nacimiento { get; set; }
        public Boolean Aprobado { get; set; }
    }
}
