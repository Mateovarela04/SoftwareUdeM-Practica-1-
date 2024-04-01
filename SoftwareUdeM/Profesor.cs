using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Profesor: Usuario
    {
        private int salario;
        public Profesor(string nombre_, int id_, string Correo_, int salario_) : base(nombre_, id_, Correo_)
        {
            salario = salario_;
        }  
    }
}
