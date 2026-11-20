namespace Examen_RentaCar_Astrid_
{
    public partial class frmAlquiler : Form
    {
        const decimal RECARGO_SEGURO_COMPLETO = 300m;
        const decimal RECARGO_GPS = 100m;
        const decimal PORCENTAJE_DESCUENTO = 0.15m;
        const decimal COSTO_DOMICILIO = 500m;
        const decimal PORCENTAJE_ITBIS = 0.18m;

        const int ANCHO_DIAS = 6;
        const int ANCHO_VEHICULO = 24;
        const int ANCHO_TARIFA = 10;
        const int ANCHO_TOTAL = 12;

        decimal subtotal = 0m;


        public frmAlquiler()
        {
            InitializeComponent();
        }
        private void frmAlquiler_Load(object sender, EventArgs e)
        {

            lblEncabezado.Font = new Font("Consolas", 9);
            lstAlquileres.Font = new Font("Consolas", 9);

            lblEncabezado.Text = "Días".PadRight(ANCHO_DIAS)
                               + "Vehículo".PadRight(ANCHO_VEHICULO)
                               + "Tarifa".PadLeft(ANCHO_TARIFA)
                               + "Total".PadLeft(ANCHO_TOTAL);

            LimpiarTodo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string vehiculo = txtVehiculo.Text.Trim();
            decimal tarifa;
            int dias = Convert.ToInt32(nudDias.Value);


            if (txtCliente.Text.Trim() == "")
            {
                MessageBox.Show("Digite el nombre del cliente.");
                txtCliente.Focus();
                return;
            }
            if (vehiculo == "")
            {
                MessageBox.Show("Digite el vehículo.");
                txtVehiculo.Focus();
                return;
            }
            if (!decimal.TryParse(txtTarifa.Text, out tarifa) || tarifa <= 0)
            {
                MessageBox.Show("Digite una tarifa válida (mayor que 0).");
                txtTarifa.Focus();
                return;
            }


            decimal tarifaDiaria = tarifa;
            string detalle = "";

            if (rbtCompleto.Checked)
            {
                tarifaDiaria += RECARGO_SEGURO_COMPLETO;
                detalle = "Completo";
            }
            if (chkGps.Checked)
            {
                tarifaDiaria += RECARGO_GPS;
                if (detalle != "") detalle += ", ";
                detalle += "GPS";
            }
            if (detalle == "") detalle = "Básico";

            decimal totalLinea = tarifaDiaria * dias;
            subtotal += totalLinea;

            string descripcion = $"{vehiculo} ({detalle})";
            string linea = dias.ToString().PadRight(ANCHO_DIAS)
                         + descripcion.PadRight(ANCHO_VEHICULO)
                         + tarifaDiaria.ToString("N2").PadLeft(ANCHO_TARIFA)
                         + totalLinea.ToString("N2").PadLeft(ANCHO_TOTAL);
            lstAlquileres.Items.Add(linea);

            ReiniciarVehiculo();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (subtotal == 0)
            {
                MessageBox.Show("Agregue al menos un vehículo al alquiler.");
                return;
            }

            decimal descuento = chkCorporativo.Checked ? subtotal * PORCENTAJE_DESCUENTO : 0m;
            decimal domicilio = rbtDomicilio.Checked ? COSTO_DOMICILIO : 0m;
            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * PORCENTAJE_ITBIS;
            decimal total = baseImponible + itbis;


            lblSubtotal.Text = FormatoMoneda(subtotal);
            lblDescuento.Text = FormatoMoneda(descuento);
            lblDomicilio.Text = FormatoMoneda(domicilio);
            lblItbis.Text = FormatoMoneda(itbis);
            lblTotal.Text = FormatoMoneda(total);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {


            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private string FormatoMoneda(decimal valor)
        {
            return "RD$ " + valor.ToString("N2");
        }

        private void ReiniciarVehiculo()
        {
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 1;
            rbtBasico.Checked = true;
            chkGps.Checked = false;
            txtVehiculo.Focus();
        }
        private void LimpiarTodo()
        {
            txtCliente.Clear();
            chkCorporativo.Checked = false;
            dtpSalida.Value = DateTime.Now;
            rbtSucursal.Checked = true;
            lstAlquileres.Items.Clear();
            subtotal = 0m;

            ReiniciarVehiculo();

            lblSubtotal.Text = FormatoMoneda(0m);
            lblDescuento.Text = FormatoMoneda(0m);
            lblDomicilio.Text = FormatoMoneda(0m);
            lblItbis.Text = FormatoMoneda(0m);
            lblTotal.Text = FormatoMoneda(0m);

            txtCliente.Focus();
        }

        private void lstAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

