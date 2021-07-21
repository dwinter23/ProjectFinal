
namespace Dashboard
{
    partial class GenerarInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGenerarInventario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEntradaTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalidaTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrecioUnidad = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPrecioVenta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblActivoPasivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(77, 73);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(755, 170);
            this.gridProductos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscador:";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(163, 32);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(167, 20);
            this.txbFiltro.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(77, 388);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 53);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Motivo";
            // 
            // btnGenerarInventario
            // 
            this.btnGenerarInventario.Location = new System.Drawing.Point(434, 388);
            this.btnGenerarInventario.Name = "btnGenerarInventario";
            this.btnGenerarInventario.Size = new System.Drawing.Size(139, 35);
            this.btnGenerarInventario.TabIndex = 5;
            this.btnGenerarInventario.Text = "Generar Inventario";
            this.btnGenerarInventario.UseVisualStyleBackColor = true;
            this.btnGenerarInventario.Click += new System.EventHandler(this.btnGenerarInventario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(775, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exportar a PDF";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entrada Total:";
            // 
            // lblEntradaTotal
            // 
            this.lblEntradaTotal.AutoSize = true;
            this.lblEntradaTotal.Location = new System.Drawing.Point(159, 325);
            this.lblEntradaTotal.Name = "lblEntradaTotal";
            this.lblEntradaTotal.Size = new System.Drawing.Size(78, 13);
            this.lblEntradaTotal.TabIndex = 7;
            this.lblEntradaTotal.Text = "lblEntradaTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salida Total:";
            // 
            // lblSalidaTotal
            // 
            this.lblSalidaTotal.AutoSize = true;
            this.lblSalidaTotal.Location = new System.Drawing.Point(782, 325);
            this.lblSalidaTotal.Name = "lblSalidaTotal";
            this.lblSalidaTotal.Size = new System.Drawing.Size(35, 13);
            this.lblSalidaTotal.TabIndex = 7;
            this.lblSalidaTotal.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total de Productos:";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Location = new System.Drawing.Point(792, 263);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(35, 13);
            this.lblTotalProductos.TabIndex = 7;
            this.lblTotalProductos.Text = "label2";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(367, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Precio Unidad:";
            // 
            // lblTotalPrecioUnidad
            // 
            this.lblTotalPrecioUnidad.AutoSize = true;
            this.lblTotalPrecioUnidad.Location = new System.Drawing.Point(202, 263);
            this.lblTotalPrecioUnidad.Name = "lblTotalPrecioUnidad";
            this.lblTotalPrecioUnidad.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPrecioUnidad.TabIndex = 9;
            this.lblTotalPrecioUnidad.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Precio Venta:";
            // 
            // lblTotalPrecioVenta
            // 
            this.lblTotalPrecioVenta.AutoSize = true;
            this.lblTotalPrecioVenta.Location = new System.Drawing.Point(512, 263);
            this.lblTotalPrecioVenta.Name = "lblTotalPrecioVenta";
            this.lblTotalPrecioVenta.Size = new System.Drawing.Size(35, 13);
            this.lblTotalPrecioVenta.TabIndex = 9;
            this.lblTotalPrecioVenta.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generar Inventario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGenerarInventario_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resumen de factura de compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Resumen de los documentos de ventas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Activo Pasivo:";
            // 
            // lblActivoPasivo
            // 
            this.lblActivoPasivo.AutoSize = true;
            this.lblActivoPasivo.Location = new System.Drawing.Point(494, 334);
            this.lblActivoPasivo.Name = "lblActivoPasivo";
            this.lblActivoPasivo.Size = new System.Drawing.Size(35, 13);
            this.lblActivoPasivo.TabIndex = 9;
            this.lblActivoPasivo.Text = "label2";
            // 
            // GenerarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 465);
            this.Controls.Add(this.lblActivoPasivo);
            this.Controls.Add(this.lblTotalPrecioVenta);
            this.Controls.Add(this.lblTotalPrecioUnidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblTotalProductos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSalidaTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEntradaTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerarInventario);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerarInventario";
            this.Text = "GenerarInventario";
            this.Load += new System.EventHandler(this.GenerarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnGenerarInventario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEntradaTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalidaTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrecioUnidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPrecioVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblActivoPasivo;
    }
}