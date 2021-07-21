using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Cotizaciones : Form
    {
        public Cotizaciones()
        {
            InitializeComponent();
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            cargarProveedores();
            MostrarProducto();
        }
        void cargarDetCotizacion()
        {

            // AUN NO FUNCIONANDO
            try
            {
                using (ContextEntities db = new ContextEntities())
                {
                    DetCotizacion detcot = new DetCotizacion();
                    detcot.iddetcotizacion = "5";
                    // db.DetCotizacions.Select(s => s.iddetcotizacion + 1).Max()
                    detcot.cantidad = Convert.ToInt32(txbCantidad.Text);
                    detcot.precio = Convert.ToDecimal(txbPrecioUnidad.Text);
                    detcot.detalle = txbDescripcion.Text;
                    detcot.idproducto = cbxProducto.SelectedIndex.ToString();

                    db.DetCotizacions.Add(detcot);
                    db.SaveChanges();
                }

            }
            catch (DbEntityValidationException e)
            {
                MessageBox.Show("ERROR: " + e);
            }
        }
        void cargarProveedores()
        {
            try
            {
                using (ContextEntities db = new ContextEntities())
                {
                    List<String> lista = db.Proveedors.Select(s => s.nombrecontacto).ToList();
                    foreach (var ls in lista)
                    {
                        cbxProveedores.Items.Add(ls);
                    }
                }
            }
            catch { }
        }
        void MostrarProducto()
        {
            try
            {
                using (ContextEntities db = new ContextEntities())
                {
                    List<String> lista = db.Productoes.Select(s => s.nombre).ToList();
                    foreach (var ls in lista)
                    {
                        cbxProducto.Items.Add(ls);
                    }
                }
            }
            catch { }
        }
        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            cargarDetCotizacion();
        }
    }
}
