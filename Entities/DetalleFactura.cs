namespace Comercio.Entities
{
    public class DetalleFactura
    {
        // el detalle factura recibe de producto la id para saber que producto
        public int IdDetalleFactura { get; set; }
        public int Cantidad { get; set; }
        public int IdProducto { get; set; }


        // to string
        public override string ToString()
        {
            return $"IdDetalleFactura: {IdDetalleFactura}, Cantidad: {Cantidad}, IdProducto: {IdProducto}";
        }

    }

}
