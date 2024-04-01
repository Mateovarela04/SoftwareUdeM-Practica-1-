using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Horario
    {
        public Estudiante estudiante { get; set; }
        public Curso curso { get; set; }

        public Horario(Estudiante estudiante_, Curso curso_) 
        {
            estudiante = estudiante_;
            curso = curso_;    
        }
    }
}
