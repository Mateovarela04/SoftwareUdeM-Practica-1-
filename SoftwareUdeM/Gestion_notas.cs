using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUdeM
{
    internal class Gestion_notas
    {
        public Estudiante estudiante;

        public Gestion_notas(Estudiante Estudiante_)
        {
            estudiante = Estudiante_;
        }
        public Dictionary<int, int> Mostrar_notas()
        {
            //Corregir implementacion solo es para omitir el error de que debe retornar algo
            return new Dictionary<int, int> { };
        }

        public void Agregar_nota() 
        {
        }

        public void eliminar_notas() 
        {
        }
    }

}
