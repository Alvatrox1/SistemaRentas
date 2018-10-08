namespace RentaCongelada.Models
{
    public class Persona
    {
        private int id { get; set; }
        private string nombre { get; set; }
        private string apPaterno { get; set; }
        private string apMaterno { get; set; }
        private string telefono { get; set; }
        private Usuario usuario { get; set; }


        public Persona() {

        }

        public Persona( int id, string nombre, string apPaterno, string apMaterno, string telefono, 
        Usuario usuario) {

            this.id = id;
            this.nombre = nombre;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.telefono = telefono;
            this.usuario = usuario;

        }

        public Persona( int id, string nombre, string apPaterno, string apMaterno, string telefono ) {

            this.id = id;
            this.nombre = nombre;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.telefono = telefono;

        }

        public string toString() {
            
            return " Nombre : " + this.nombre + " " + this.apPaterno + " " + this.apMaterno +
            this.telefono + ". \n ";
        }

    }
}