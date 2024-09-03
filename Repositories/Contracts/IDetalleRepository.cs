using Comercio.Entities;

namespace Comercio.Repositories.Contracts
{
    public interface IDetalleRepository
    {
        // Solo se necesita un método para obtener todos los detalles de factura
        List<DetalleFactura> GetAll();
    }
}
