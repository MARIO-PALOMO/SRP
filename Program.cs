using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {

            FacturaFactorizada facturaFactorizada = new FacturaFactorizada();
            facturaFactorizada.Codigo = "00001";
            facturaFactorizada.FechaEmision = "2017-12-16";
            facturaFactorizada.Subtotal = 14191.39;
            facturaFactorizada.CantidadDescuento = 56.09;

            Console.WriteLine("FACTURA N°          " + facturaFactorizada.Codigo);
            Console.WriteLine("Fecha de Emisión:   " + facturaFactorizada.FechaEmision);
            Console.WriteLine("Subtotal:           " + facturaFactorizada.Subtotal);
            Console.WriteLine("Descuento:          " + facturaFactorizada.CantidadDescuento);
            Console.WriteLine("IVA:                " + facturaFactorizada.Iva);
            Console.WriteLine("Total:              " + Math.Truncate(facturaFactorizada.CalcularTotal() * 100) / 100);
        }
    }
}
