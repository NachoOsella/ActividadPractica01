namespace Comercio.Entities
{
    public class Product
    {
        // la clase producto tiene un id, nombre y precio
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }



        // to string
        public override string ToString()
        {
            return $"IdProducto: {IdProducto}, Nombre: {Nombre}, Precio: {Precio}";
        }
    }

}
