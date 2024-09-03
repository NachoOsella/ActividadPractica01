using System.Data;
using Comercio.Entities;
using Comercio.Repositories.Contracts;
using Comercio.Utils;

namespace Comercio.Repositories.Implementations
{
    public class DetalleFacturaRepository : IDetalleRepository
    {
        public List<DetalleFactura> GetAll()
        {
            DataTable dt = DataHelper.GetInstance().ExecuteSPQuery("Obtener Detalles", null);
            var DetallesFactura = new List<DetalleFactura>();

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DetalleFactura detalleFactura = new DetalleFactura
                    {
                        IdDetalleFactura = Convert.ToInt32(row["IdDetalle"]),
                        IdProducto = Convert.ToInt32(row["IdProducto"]),
                        Cantidad = Convert.ToInt32(row["Cantidad"]),
                    };
                    DetallesFactura.Add(detalleFactura);
                }
            }
            return DetallesFactura;
        }
    }
}