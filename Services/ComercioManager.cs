using Comercio.Entities;
using Comercio.Repositories.Contracts;
using Comercio.Repositories.Implementations;


namespace Comercio.Services
{
    public class ComercioManager
    {
        IProductRepository _productRepository;
        IFacturaRepository _facturaRepository;
        IDetalleRepository _detalleRepository;

        public ComercioManager()
        {
            _productRepository = new ProductRepository();
            _facturaRepository = new FacturaRepository();
            _detalleRepository = new DetalleFacturaRepository();
        }

        // obtener todos los productos
        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        // obtener todas las facturas
        public List<Factura> GetAllFacturas()
        {
            return _facturaRepository.GetAll();
        }

        // obtener todos los detalles de factura
        public List<DetalleFactura> GetAllDetalles()
        {
            return _detalleRepository.GetAll();
        }

        // agregar una factura
        public bool AddFactura(Factura factura)
        {
            return _facturaRepository.Add(factura);
        }

        // eliminar una factura
        public bool DeleteFactura(int idFactura)
        {
            return _facturaRepository.Delete(idFactura);
        }

        // editar una factura
        public bool EditFactura(Factura factura)
        {
            return _facturaRepository.Update(factura);
        }

        // agregar un producto
        public bool AddProduct(Product product)
        {
            return _productRepository.Add(product);
        }
    }
}
