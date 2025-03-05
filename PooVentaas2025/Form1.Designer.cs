namespace PooVentaas2025
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProducto = new Label();
            lblMonto = new Label();
            txtProducto = new TextBox();
            txtMonto = new TextBox();
            btnCalcular = new Button();
            rbContado = new RadioButton();
            rbCredito = new RadioButton();
            dgvProductos = new DataGridView();
            dgvProducto = new DataGridViewTextBoxColumn();
            dgvCantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(69, 57);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(69, 97);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(53, 20);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(156, 53);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(139, 27);
            txtProducto.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(156, 94);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(139, 27);
            txtMonto.TabIndex = 1;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(121, 183);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rbContado
            // 
            rbContado.AutoSize = true;
            rbContado.Location = new Point(69, 140);
            rbContado.Name = "rbContado";
            rbContado.Size = new Size(87, 24);
            rbContado.TabIndex = 3;
            rbContado.TabStop = true;
            rbContado.Text = "Contado";
            rbContado.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Location = new Point(186, 140);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(79, 24);
            rbCredito.TabIndex = 3;
            rbCredito.TabStop = true;
            rbCredito.Text = "Crédito";
            rbCredito.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { dgvProducto, dgvCantidad });
            dgvProductos.Location = new Point(40, 234);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(300, 188);
            dgvProductos.TabIndex = 4;
            dgvProductos.CellContentClick += dgvLista_CellContentClick;
            // 
            // dgvProducto
            // 
            dgvProducto.HeaderText = "Producto";
            dgvProducto.MinimumWidth = 6;
            dgvProducto.Name = "dgvProducto";
            dgvProducto.Width = 125;
            // 
            // dgvCantidad
            // 
            dgvCantidad.HeaderText = "Cantidad";
            dgvCantidad.MinimumWidth = 6;
            dgvCantidad.Name = "dgvCantidad";
            dgvCantidad.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(819, 450);
            Controls.Add(dgvProductos);
            Controls.Add(rbCredito);
            Controls.Add(rbContado);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(txtProducto);
            Controls.Add(lblMonto);
            Controls.Add(lblProducto);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private Label lblMonto;
        private TextBox txtProducto;
        private TextBox txtMonto;
        private Button btnCalcular;
        private RadioButton rbContado;
        private RadioButton rbCredito;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn dgvProducto;
        private DataGridViewTextBoxColumn dgvCantidad;
    }
}
