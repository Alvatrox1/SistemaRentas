namespace RentaCongelada.Models
{
    public class Domicilio
    {
        private int id { get; set; }
        private string calle { get; set; }
        private int numInterior { get; set; }
        private int numExterior { get; set; }
        private string colonia { get; set; }
        private string municipio { get; set; }
        private string estado { get; set; }
        private string codigoPostal { get; set; }

        public Domicilio() {

        }

        public Domicilio( int id, string calle, int numInterior, int numExterior, string colonia, 
        string municipio, string estado, string codigoPostal) {

            this.id = id;
            this.calle = calle;
            this.numInterior = numInterior;
            this.numExterior = numExterior;
            this.colonia = colonia;
            this.municipio = municipio;
            this.estado = estado;
            this.codigoPostal = codigoPostal;

        }


    }
}