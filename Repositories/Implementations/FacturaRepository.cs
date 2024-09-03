using Comercio.Entities;
using Comercio.Repositories.Contracts;
using Comercio.Utils;
using System.Data;

namespace Comercio.Repositories.Implementations
{
    public class FacturaRepository : IFacturaRepository
    {
        public bool Add(Factura factura)
        {
            var parameters = new List<ParameterSQL>
            {
                new ParameterSQL("@IdCliente", factura.Cliente),
                new ParameterSQL("@Fecha", factura.Fecha),
                new ParameterSQL("@Total", factura.Total)
            };
            int filasAfectadas = DataHelper.GetInstance().ExecuteSPDML("Agregar Factura", parameters);
            return filasAfectadas > 0;
        }

        public bool Delete(int idFactura)
        {
            var parameters = new List<ParameterSQL>
            {
                new ParameterSQL("@IdFactura", idFactura)
            };
            int filasAfectadas = DataHelper.GetInstance().ExecuteSPDML("Eliminar Factura", parameters);
            return filasAfectadas > 0;
        }

        public List<Factura> GetAll()
        {
            var facturas = new List<Factura>();
            DataTable dt = DataHelper.GetInstance().ExecuteSPQuery("Obtener Facturas", null);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Factura factura = new Factura
                    {
                        IdFactura = Convert.ToInt32(row["IdFactura"]),
                        Cliente = Convert.ToString(row["Cliente"]),
                        Fecha = Convert.ToDateTime(row["Fecha"]),
                        Total = Convert.ToDouble(row["Total"])
                    };
                    facturas.Add(factura);

                }
            }
            return facturas;
        }

        public bool Update(Factura factura)
        {
            var parameters = new List<ParameterSQL>
            {
                new ParameterSQL("@IdFactura", factura.IdFactura),
                new ParameterSQL("@IdCliente", factura.Cliente),
                new ParameterSQL("@Fecha", factura.Fecha),
                new ParameterSQL("@Total", factura.Total)
            };
            int filasAfectadas = DataHelper.GetInstance().ExecuteSPDML("Actualizar Factura", parameters);
            return filasAfectadas > 0;

        }
    }
}

