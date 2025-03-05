namespace PooVentaas2025
{
    public class VentaCredito : Venta
    {
        private const decimal RECARGO = 0.05m; //5% de recargo

        public VentaCredito(string producto, decimal monto) : base(producto, monto)
        {
        }

        public override decimal CalcularTotal()
        {
            return Monto * (1 + RECARGO);
            throw new NotImplementedException();
        }
    }
}
