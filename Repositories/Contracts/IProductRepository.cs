using Comercio.Entities;

namespace Comercio.Repositories.Contracts
{
    public interface IProductRepository
    {
        // Solo se necesita un método para obtener todos los productos y otro para agregar un producto
        List<Product> GetAll();
        bool Add(Product product);
    }
}
