using Comercio.Services;
using Comercio.Entities;

ComercioManager comercioManager = new ComercioManager();

// prueba para obtener todos los productos
Console.WriteLine("Productos:");
var productos = comercioManager.GetAllProducts();

foreach (var producto in productos)
{
    Console.WriteLine($"Id: {producto.IdProducto}, Nombre: {producto.Nombre}, Precio: {producto.Precio}");
}

// prueba para obtener todas las facturas
Console.WriteLine("\nFacturas:");
var facturas = comercioManager.GetAllFacturas();

foreach (var factura in facturas)
{
    Console.WriteLine($"Id: {factura.IdFactura}, Cliente: {factura.Cliente}, Fecha: {factura.Fecha}, Total: {factura.Total}");
}

// prueba para obtener todos los detalles de factura
Console.WriteLine("\nDetalles de Factura:");
var detalles = comercioManager.GetAllDetalles();

foreach (var detalle in detalles)
{
    Console.WriteLine($"Id: {detalle.IdDetalleFactura}, IdProducto: {detalle.IdProducto}, Cantidad: {detalle.Cantidad}");
}

// prueba para agregar una factura
Console.WriteLine("\nAgregar Factura:");
Factura facturaNueva = new Factura
{
    Cliente = "Juan",
    Fecha = DateTime.Now,
    Total = 100
};

if (comercioManager.AddFactura(facturaNueva))
{
    Console.WriteLine("Factura agregada correctamente");
}
else
{
    Console.WriteLine("Error al agregar la factura");
}

// prueba para eliminar una factura
Console.WriteLine("\nEliminar Factura:");
if (comercioManager.DeleteFactura(1))
{
    Console.WriteLine("Factura eliminada correctamente");
}
else
{
    Console.WriteLine("Error al eliminar la factura");
}

// prueba para editar una factura
Console.WriteLine("\nEditar Factura:");
Factura facturaEditada = new Factura
{
    IdFactura = 2,
    Cliente = "Pedro",
    Fecha = DateTime.Now,
    Total = 200
};

if (comercioManager.EditFactura(facturaEditada))
{
    Console.WriteLine("Factura editada correctamente");
}
else
{
    Console.WriteLine("Error al editar la factura");
}
