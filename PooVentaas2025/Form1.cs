namespace PooVentaas2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            decimal monto;
            bool esCredito = rbCredito.Checked;

            if (!decimal.TryParse(txtMonto.Text, out monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el producto no esté vacío
            if (string.IsNullOrWhiteSpace(producto))
            {
                MessageBox.Show("Ingrese el nombre del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Aumentar el 5% si es a crédito
            if (esCredito)
            {
                monto *= 1.05m; // Incrementa el monto en un 5%
            }

            // Determinar el tipo de venta
            Venta venta = esCredito ? new VentaCredito(producto, monto) : new VentaContado(producto, monto);

            // Agregar los datos al DataGridView
            dgvProductos.Rows.Add(producto, monto.ToString("C")); // "C" formatea el monto como moneda
        

            // Mensaje para verificar que funciona
            MessageBox.Show($"Producto: {producto}\nMonto: {monto}\nTipo: {(esCredito ? "Crédito" : "Contado")}", "Resultado");

            if (esCredito)
                venta = new VentaCredito(producto, monto);
            else
                venta = new VentaContado(producto, monto);
        }



        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
