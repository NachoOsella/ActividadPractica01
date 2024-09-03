using System.Data;
using Comercio.Entities;
using Comercio.Repositories.Contracts;
using Comercio.Utils;

namespace Comercio.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public bool Add(Product product)
        {
            var parameters = new List<ParameterSQL>
            {
                new ParameterSQL("@Nombre", product.Nombre),
                new ParameterSQL("@Precio", product.Precio)
            };
            int filasAfectadas = DataHelper.GetInstance().ExecuteSPDML("Agregar Producto", parameters);
            return filasAfectadas > 0;
        }

        public List<Product> GetAll()
        {
            var Products = new List<Product>();
            DataTable dt = DataHelper.GetInstance().ExecuteSPQuery("Obtener Productos", null);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Product product = new Product
                    {
                        IdProducto = Convert.ToInt32(row["IdProducto"]),
                        Nombre = row["Nombre"].ToString(),
                        Precio = Convert.ToDouble(row["Precio"])
                    };
                    Products.Add(product);

                }
            }
            return Products;
        }
    }
}
