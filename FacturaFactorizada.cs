class FacturaFactorizada
{
    public string Codigo { get; set; }
    public string FechaEmision { get; set; }
    public double Subtotal { get; set; }
    public double Iva { get; set; }
    public double DescuentoTotal { get; set; }
    public double CantidadDescuento { get; set; }
    public double Total { get; set; }
        
    // Método que calcula el total de la factura
    public double CalcularTotal()
    {
        // Calculamos el descuento
        Descuento descuento = new Descuento(Subtotal, CantidadDescuento);
        DescuentoTotal = descuento.CalcularDescuento();
        // Calculamos el IVA
        IvaNormal iva = new IvaNormal();
        Iva = iva.CalcularIVA(Subtotal);
        // Calculamos el total
        Total = (DescuentoTotal) + Iva;

        return Total;
    }
}