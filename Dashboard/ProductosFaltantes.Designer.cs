
namespace Dashboard
{
    partial class ProductosFaltantes
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
            this.gridProductosFaltantes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltimeProdFaltantes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosFaltantes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductosFaltantes
            // 
            this.gridProductosFaltantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductosFaltantes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridProductosFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductosFaltantes.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridProductosFaltantes.Location = new System.Drawing.Point(76, 85);
            this.gridProductosFaltantes.Name = "gridProductosFaltantes";
            this.gridProductosFaltantes.Size = new System.Drawing.Size(769, 334);
            this.gridProductosFaltantes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ultima Actualizacion:";
            // 
            // lbltimeProdFaltantes
            // 
            this.lbltimeProdFaltantes.AutoSize = true;
            this.lbltimeProdFaltantes.Location = new System.Drawing.Point(211, 52);
            this.lbltimeProdFaltantes.Name = "lbltimeProdFaltantes";
            this.lbltimeProdFaltantes.Size = new System.Drawing.Size(35, 13);
            this.lbltimeProdFaltantes.TabIndex = 2;
            this.lbltimeProdFaltantes.Text = "label2";
            // 
            // ProductosFaltantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 504);
            this.Controls.Add(this.lbltimeProdFaltantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProductosFaltantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosFaltantes";
            this.Text = "ProductosFaltantes";
            this.Load += new System.EventHandler(this.ProductosFaltantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductosFaltantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductosFaltantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltimeProdFaltantes;
    }
}