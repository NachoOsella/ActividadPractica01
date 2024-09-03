using Comercio.Entities;

namespace Comercio.Repositories.Contracts
{
    public interface IFacturaRepository
    {
        // metodos para obtener todas las facturas, agregar una factura, actualizar una factura y eliminar una factura
        bool Add(Factura factura);
        List<Factura> GetAll();
        bool Update(Factura factura);
        bool Delete(int idFactura);

    }

}
