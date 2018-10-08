namespace RentaCongelada.Models
{
    public class Usuario
    {
        private int id { get; set; }
        private string mail { get; set;}
        private string password { get; set; }

        public Usuario() {

        }

        public Usuario( int id, string mail, string password ) {

            this.id = id;
            this.mail = mail;
            this.password = password;

        }

        public string toString() {
            return "Mail : " + this.mail + ". Contraseña : " + this.password + ". \n ";
        }

    }
}