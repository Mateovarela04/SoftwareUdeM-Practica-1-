namespace SoftwareUdeM
{
    internal class Estudiante : Usuario
    {
        public string carrera;
        public int semestre;
        private string horario;
        public string notas;
        public Estudiante(string nombre_, int id_, string Correo_, string carrera_, int semestre_, string horario_, string notas_) : base(nombre_, id_, Correo_)
        {
            carrera = carrera_;
            semestre = semestre_;
            horario = horario_;
            notas = notas_;
        }
    }
}
