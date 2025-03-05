namespace PooVentaas2025
{
    //Clase abstracta que representa una venta
    public abstract class Venta
    {
        //Propiedades encapsuladas
        public string Producto { get; set; }
        public decimal Monto { get; set; }

        //Constructor
        public Venta(string producto, decimal monto) 
        {
            Producto = producto;
            Monto = monto;
        }

        public abstract decimal CalcularTotal();
    }
}
