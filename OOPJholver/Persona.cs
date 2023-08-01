namespace OOPJholver
{
    public class Persona
    {
        private string idAlumno;
        private string nombreAlumno;

        public Persona(string _nombreAlumno){
            this.idAlumno = Guid.NewGuid().ToString();
            this.nombreAlumno = _nombreAlumno;
        }
        public string IdAlumno {
            get { return this.idAlumno; }
        }

        public string NombreAlumno {
            get { return this.nombreAlumno; }
            set { this.nombreAlumno = value; }
        }
        // metodos estan clasificados en funciones y procedimiento
        // la palabra reservada de procedimiento es void
    }
}