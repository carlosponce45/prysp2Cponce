namespace prysp2Cponce
{
    partial class FrmReservaDeCabaña
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMuestra = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNonbre = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.MrcPago = new System.Windows.Forms.GroupBox();
            this.CmbTarjeta = new System.Windows.Forms.ComboBox();
            this.LblTarjeta = new System.Windows.Forms.Label();
            this.RbTarjeta = new System.Windows.Forms.RadioButton();
            this.RbEfectivo = new System.Windows.Forms.RadioButton();
            this.MrcAdcionales = new System.Windows.Forms.GroupBox();
            this.ChkTv = new System.Windows.Forms.CheckBox();
            this.ChkHeladera = new System.Windows.Forms.CheckBox();
            this.ChkCocina = new System.Windows.Forms.CheckBox();
            this.GbCabaña = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.LblDias = new System.Windows.Forms.Label();
            this.CmbPersonas = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblPersonas = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.GbDatos.SuspendLayout();
            this.MrcPago.SuspendLayout();
            this.MrcAdcionales.SuspendLayout();
            this.GbCabaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMuestra
            // 
            this.LblMuestra.AutoSize = true;
            this.LblMuestra.Location = new System.Drawing.Point(114, 533);
            this.LblMuestra.Name = "LblMuestra";
            this.LblMuestra.Size = new System.Drawing.Size(0, 13);
            this.LblMuestra.TabIndex = 21;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Enabled = false;
            this.BtnAceptar.Location = new System.Drawing.Point(592, 533);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 48);
            this.BtnAceptar.TabIndex = 20;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.TxtNumero);
            this.GbDatos.Controls.Add(this.TxtNonbre);
            this.GbDatos.Controls.Add(this.LblNumero);
            this.GbDatos.Controls.Add(this.LblNombre);
            this.GbDatos.Location = new System.Drawing.Point(114, 356);
            this.GbDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbDatos.Size = new System.Drawing.Size(607, 156);
            this.GbDatos.TabIndex = 19;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(80, 108);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(522, 20);
            this.TxtNumero.TabIndex = 19;
            // 
            // TxtNonbre
            // 
            this.TxtNonbre.Enabled = false;
            this.TxtNonbre.Location = new System.Drawing.Point(80, 47);
            this.TxtNonbre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtNonbre.Name = "TxtNonbre";
            this.TxtNonbre.Size = new System.Drawing.Size(522, 20);
            this.TxtNonbre.TabIndex = 17;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(15, 111);
            this.LblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(44, 13);
            this.LblNumero.TabIndex = 18;
            this.LblNumero.Text = "Numero";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(15, 47);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 17;
            this.LblNombre.Text = "Nombre";
            // 
            // MrcPago
            // 
            this.MrcPago.Controls.Add(this.CmbTarjeta);
            this.MrcPago.Controls.Add(this.LblTarjeta);
            this.MrcPago.Controls.Add(this.RbTarjeta);
            this.MrcPago.Controls.Add(this.RbEfectivo);
            this.MrcPago.Location = new System.Drawing.Point(371, 166);
            this.MrcPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MrcPago.Name = "MrcPago";
            this.MrcPago.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MrcPago.Size = new System.Drawing.Size(350, 169);
            this.MrcPago.TabIndex = 18;
            this.MrcPago.TabStop = false;
            this.MrcPago.Text = "Medios de pago";
            this.MrcPago.Enter += new System.EventHandler(this.MrcPago_Enter);
            // 
            // CmbTarjeta
            // 
            this.CmbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTarjeta.FormattingEnabled = true;
            this.CmbTarjeta.Items.AddRange(new object[] {
            "Visa",
            "Master",
            "Naranja"});
            this.CmbTarjeta.Location = new System.Drawing.Point(135, 107);
            this.CmbTarjeta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbTarjeta.Name = "CmbTarjeta";
            this.CmbTarjeta.Size = new System.Drawing.Size(204, 21);
            this.CmbTarjeta.TabIndex = 17;
            
            // 
            // LblTarjeta
            // 
            this.LblTarjeta.AutoSize = true;
            this.LblTarjeta.Location = new System.Drawing.Point(132, 73);
            this.LblTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTarjeta.Name = "LblTarjeta";
            this.LblTarjeta.Size = new System.Drawing.Size(40, 13);
            this.LblTarjeta.TabIndex = 17;
            this.LblTarjeta.Text = "Tarjeta";
            // 
            // RbTarjeta
            // 
            this.RbTarjeta.AutoSize = true;
            this.RbTarjeta.Enabled = false;
            this.RbTarjeta.Location = new System.Drawing.Point(24, 107);
            this.RbTarjeta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RbTarjeta.Name = "RbTarjeta";
            this.RbTarjeta.Size = new System.Drawing.Size(58, 17);
            this.RbTarjeta.TabIndex = 22;
            this.RbTarjeta.TabStop = true;
            this.RbTarjeta.Text = "Tarjeta";
            this.RbTarjeta.UseVisualStyleBackColor = true;
            // 
            // RbEfectivo
            // 
            this.RbEfectivo.AutoSize = true;
            this.RbEfectivo.Enabled = false;
            this.RbEfectivo.Location = new System.Drawing.Point(24, 49);
            this.RbEfectivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RbEfectivo.Name = "RbEfectivo";
            this.RbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.RbEfectivo.TabIndex = 21;
            this.RbEfectivo.TabStop = true;
            this.RbEfectivo.Text = "Efectivo";
            this.RbEfectivo.UseVisualStyleBackColor = true;
            // 
            // MrcAdcionales
            // 
            this.MrcAdcionales.Controls.Add(this.ChkTv);
            this.MrcAdcionales.Controls.Add(this.ChkHeladera);
            this.MrcAdcionales.Controls.Add(this.ChkCocina);
            this.MrcAdcionales.Enabled = false;
            this.MrcAdcionales.Location = new System.Drawing.Point(114, 166);
            this.MrcAdcionales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MrcAdcionales.Name = "MrcAdcionales";
            this.MrcAdcionales.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MrcAdcionales.Size = new System.Drawing.Size(239, 169);
            this.MrcAdcionales.TabIndex = 17;
            this.MrcAdcionales.TabStop = false;
            this.MrcAdcionales.Text = "Adicionales";
            this.MrcAdcionales.Enter += new System.EventHandler(this.MrcAdcionales_Enter);
            // 
            // ChkTv
            // 
            this.ChkTv.AutoSize = true;
            this.ChkTv.Location = new System.Drawing.Point(18, 127);
            this.ChkTv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkTv.Name = "ChkTv";
            this.ChkTv.Size = new System.Drawing.Size(69, 17);
            this.ChkTv.TabIndex = 2;
            this.ChkTv.Text = "Televisor";
            this.ChkTv.UseVisualStyleBackColor = true;
            // 
            // ChkHeladera
            // 
            this.ChkHeladera.AutoSize = true;
            this.ChkHeladera.Location = new System.Drawing.Point(18, 88);
            this.ChkHeladera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkHeladera.Name = "ChkHeladera";
            this.ChkHeladera.Size = new System.Drawing.Size(69, 17);
            this.ChkHeladera.TabIndex = 1;
            this.ChkHeladera.Text = "Heladera";
            this.ChkHeladera.UseVisualStyleBackColor = true;
            // 
            // ChkCocina
            // 
            this.ChkCocina.AutoSize = true;
            this.ChkCocina.Location = new System.Drawing.Point(18, 49);
            this.ChkCocina.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkCocina.Name = "ChkCocina";
            this.ChkCocina.Size = new System.Drawing.Size(59, 17);
            this.ChkCocina.TabIndex = 0;
            this.ChkCocina.Text = "Cocina";
            this.ChkCocina.UseVisualStyleBackColor = true;
            // 
            // GbCabaña
            // 
            this.GbCabaña.Controls.Add(this.numericUpDown1);
            this.GbCabaña.Controls.Add(this.TxtDias);
            this.GbCabaña.Controls.Add(this.LblDias);
            this.GbCabaña.Controls.Add(this.CmbPersonas);
            this.GbCabaña.Controls.Add(this.LblTipo);
            this.GbCabaña.Controls.Add(this.LblPersonas);
            this.GbCabaña.Controls.Add(this.CmbTipo);
            this.GbCabaña.Location = new System.Drawing.Point(114, 6);
            this.GbCabaña.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbCabaña.Name = "GbCabaña";
            this.GbCabaña.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GbCabaña.Size = new System.Drawing.Size(607, 119);
            this.GbCabaña.TabIndex = 16;
            this.GbCabaña.TabStop = false;
            this.GbCabaña.Text = "Tipo de Cabaña";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(410, 78);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 17;
            // 
            // TxtDias
            // 
            this.TxtDias.Enabled = false;
            this.TxtDias.Location = new System.Drawing.Point(410, 48);
            this.TxtDias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(88, 20);
            this.TxtDias.TabIndex = 16;
            this.TxtDias.TextChanged += new System.EventHandler(this.TxtDias_TextChanged);
            // 
            // LblDias
            // 
            this.LblDias.AutoSize = true;
            this.LblDias.Location = new System.Drawing.Point(373, 51);
            this.LblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDias.Name = "LblDias";
            this.LblDias.Size = new System.Drawing.Size(28, 13);
            this.LblDias.TabIndex = 15;
            this.LblDias.Text = "Dias";
            // 
            // CmbPersonas
            // 
            this.CmbPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPersonas.Enabled = false;
            this.CmbPersonas.FormattingEnabled = true;
            this.CmbPersonas.Location = new System.Drawing.Point(257, 48);
            this.CmbPersonas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbPersonas.Name = "CmbPersonas";
            this.CmbPersonas.Size = new System.Drawing.Size(97, 21);
            this.CmbPersonas.TabIndex = 14;
            this.CmbPersonas.SelectedIndexChanged += new System.EventHandler(this.CmbPersonas_SelectedIndexChanged);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(5, 48);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(28, 13);
            this.LblTipo.TabIndex = 11;
            this.LblTipo.Text = "Tipo";
            // 
            // LblPersonas
            // 
            this.LblPersonas.AutoSize = true;
            this.LblPersonas.Location = new System.Drawing.Point(178, 48);
            this.LblPersonas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPersonas.Name = "LblPersonas";
            this.LblPersonas.Size = new System.Drawing.Size(51, 13);
            this.LblPersonas.TabIndex = 13;
            this.LblPersonas.Text = "Personas";
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.CmbTipo.Location = new System.Drawing.Point(51, 47);
            this.CmbTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(97, 21);
            this.CmbTipo.TabIndex = 12;
            this.CmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipo_SelectedIndexChanged);
            // 
            // FrmMains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 587);
            this.Controls.Add(this.LblMuestra);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.GbDatos);
            this.Controls.Add(this.MrcPago);
            this.Controls.Add(this.MrcAdcionales);
            this.Controls.Add(this.GbCabaña);
            this.Name = "FrmMains";
            this.Text = "reserva de cabaña";
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.MrcPago.ResumeLayout(false);
            this.MrcPago.PerformLayout();
            this.MrcAdcionales.ResumeLayout(false);
            this.MrcAdcionales.PerformLayout();
            this.GbCabaña.ResumeLayout(false);
            this.GbCabaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMuestra;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNonbre;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.GroupBox MrcPago;
        private System.Windows.Forms.ComboBox CmbTarjeta;
        private System.Windows.Forms.Label LblTarjeta;
        private System.Windows.Forms.RadioButton RbTarjeta;
        private System.Windows.Forms.RadioButton RbEfectivo;
        private System.Windows.Forms.GroupBox MrcAdcionales;
        private System.Windows.Forms.CheckBox ChkTv;
        private System.Windows.Forms.CheckBox ChkHeladera;
        private System.Windows.Forms.CheckBox ChkCocina;
        private System.Windows.Forms.GroupBox GbCabaña;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label LblDias;
        private System.Windows.Forms.ComboBox CmbPersonas;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblPersonas;
        protected internal System.Windows.Forms.ComboBox CmbTipo;
    }
}

