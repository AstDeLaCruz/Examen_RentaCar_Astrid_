namespace Examen_RentaCar_Astrid_
{
    partial class frmAlquiler
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblEncabezado = new Label();
            label11 = new Label();
            chkCorporativo = new CheckBox();
            chkGps = new CheckBox();
            txtVehiculo = new TextBox();
            lblSubtotal = new TextBox();
            txtTarifa = new TextBox();
            txtCliente = new TextBox();
            lblTotal = new TextBox();
            lblItbis = new TextBox();
            lblDomicilio = new TextBox();
            lblDescuento = new TextBox();
            nudDias = new NumericUpDown();
            dtpSalida = new DateTimePicker();
            groupBox1 = new GroupBox();
            rbtCompleto = new RadioButton();
            rbtBasico = new RadioButton();
            lstAlquileres = new ListBox();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 381);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "TOTAL A PAGAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 348);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "ITBIS (18%)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 321);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Domicilio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 255);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Subtotal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 202);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 5;
            label6.Text = "Dias:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 169);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 6;
            label7.Text = "Tarifa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(525, 285);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 7;
            label8.Text = "Descuento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 139);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 8;
            label9.Text = "Vehiculo:";
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEncabezado.Location = new Point(498, 67);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(301, 20);
            lblEncabezado.TabIndex = 9;
            lblEncabezado.Text = "Dias   Vehiculo                   Tarifa          Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 105);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 10;
            label11.Text = "Salida:";
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Location = new Point(15, 63);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(160, 24);
            chkCorporativo.TabIndex = 11;
            chkCorporativo.Text = "Cliente Corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Location = new Point(15, 369);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(185, 24);
            chkGps.TabIndex = 12;
            chkGps.Text = "GPS (+RD$100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(90, 136);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(368, 27);
            txtVehiculo.TabIndex = 13;
            txtVehiculo.TextChanged += textBox1_TextChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(619, 248);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(125, 27);
            lblSubtotal.TabIndex = 14;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(90, 169);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(368, 27);
            txtTarifa.TabIndex = 15;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(90, 21);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(368, 27);
            txtCliente.TabIndex = 16;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(619, 378);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 27);
            lblTotal.TabIndex = 17;
            // 
            // lblItbis
            // 
            lblItbis.Location = new Point(619, 345);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(125, 27);
            lblItbis.TabIndex = 18;
            // 
            // lblDomicilio
            // 
            lblDomicilio.Location = new Point(619, 314);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(125, 27);
            lblDomicilio.TabIndex = 19;
            // 
            // lblDescuento
            // 
            lblDescuento.Location = new Point(619, 278);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(125, 27);
            lblDescuento.TabIndex = 20;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(90, 202);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(368, 27);
            nudDias.TabIndex = 21;
            // 
            // dtpSalida
            // 
            dtpSalida.Location = new Point(90, 106);
            dtpSalida.Name = "dtpSalida";
            dtpSalida.Size = new Size(368, 27);
            dtpSalida.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtCompleto);
            groupBox1.Controls.Add(rbtBasico);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(15, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 125);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro";
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Font = new Font("Segoe UI", 9F);
            rbtCompleto.Location = new Point(6, 74);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(172, 24);
            rbtCompleto.TabIndex = 1;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo (+RD$300)";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rbtBasico
            // 
            rbtBasico.AutoSize = true;
            rbtBasico.Font = new Font("Segoe UI", 9F);
            rbtBasico.Location = new Point(6, 42);
            rbtBasico.Name = "rbtBasico";
            rbtBasico.Size = new Size(73, 24);
            rbtBasico.TabIndex = 0;
            rbtBasico.TabStop = true;
            rbtBasico.Text = "Basico";
            rbtBasico.UseVisualStyleBackColor = true;
            // 
            // lstAlquileres
            // 
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(498, 90);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(311, 144);
            lstAlquileres.TabIndex = 24;
            lstAlquileres.SelectedIndexChanged += lstAlquileres_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(498, 20);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(290, 44);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtDomicilio);
            groupBox2.Controls.Add(rbtSucursal);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(247, 243);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 125);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entrega";
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Font = new Font("Segoe UI", 9F);
            rbtDomicilio.Location = new Point(6, 74);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(171, 24);
            rbtDomicilio.TabIndex = 1;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio (+RD$500)";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Font = new Font("Segoe UI", 9F);
            rbtSucursal.Location = new Point(6, 44);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(102, 24);
            rbtSucursal.TabIndex = 0;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "En sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ActiveCaption;
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(15, 404);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 42);
            btnCalcular.TabIndex = 27;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(165, 404);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(144, 42);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Nuevo Alquiler";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaption;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(327, 404);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 42);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmAlquiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 468);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox2);
            Controls.Add(btnAgregar);
            Controls.Add(lstAlquileres);
            Controls.Add(groupBox1);
            Controls.Add(dtpSalida);
            Controls.Add(nudDias);
            Controls.Add(lblDescuento);
            Controls.Add(lblDomicilio);
            Controls.Add(lblItbis);
            Controls.Add(lblTotal);
            Controls.Add(txtCliente);
            Controls.Add(txtTarifa);
            Controls.Add(lblSubtotal);
            Controls.Add(txtVehiculo);
            Controls.Add(chkGps);
            Controls.Add(chkCorporativo);
            Controls.Add(label11);
            Controls.Add(lblEncabezado);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlquiler";
            Text = "RentaCar Express - Alquileres";
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblEncabezado;
        private Label label11;
        private CheckBox chkCorporativo;
        private CheckBox chkGps;
        private TextBox txtVehiculo;
        private TextBox lblSubtotal;
        private TextBox txtTarifa;
        private TextBox txtCliente;
        private TextBox lblTotal;
        private TextBox lblItbis;
        private TextBox lblDomicilio;
        private TextBox lblDescuento;
        private NumericUpDown nudDias;
        private DateTimePicker dtpSalida;
        private GroupBox groupBox1;
        private RadioButton rbtCompleto;
        private RadioButton rbtBasico;
        private ListBox lstAlquileres;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
