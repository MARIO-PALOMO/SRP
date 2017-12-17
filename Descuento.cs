class Descuento
{
    private double CantidadDescuento;
    private double CantidadSubtotal;

    public Descuento(double subtotal, double descuento)
    {
        CantidadSubtotal = subtotal;
        CantidadDescuento = descuento;
    }
        
    public double CalcularDescuento()
    {
        return (CantidadSubtotal - CantidadDescuento);
    }
}