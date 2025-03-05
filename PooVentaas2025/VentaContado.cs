namespace PooVentaas2025
{
    public class VentaContado : Venta
    {
        public VentaContado(string producto, decimal monto) : base(producto, monto)
        {
        }

        public override decimal CalcularTotal()
        {
            return Monto;
        }
    }
}
