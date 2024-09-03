namespace Comercio.Entities
{
    public class Factura
    {
        // la factura recibe de detalle factura la id para saber que detalle factura es y sumar el subtotal de cada detalle factura(cantidad * precio) que viene de la tabla detalle factura
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public string Cliente { get; set; }
        public List<DetalleFactura> Detalles { get; set; } = new List<DetalleFactura>();


        // to string
        public override string ToString()
        {
            return $"IdFactura: {IdFactura}, Fecha: {Fecha}, Total: {Total}, Cliente: {Cliente}";
        }

    }

}
