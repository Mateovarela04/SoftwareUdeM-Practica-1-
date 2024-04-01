using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Administrativo : Usuario
    {
        private string cargo;
        public Administrativo(string nombre_, int id_, string Correo_, string cargo_) : base(nombre_, id_, Correo_)
        {
            cargo = cargo_;
        }
    }
}
