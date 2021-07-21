using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class GenerarInventario : Form
    {
        public GenerarInventario()
        {
            InitializeComponent();
        }

        private void GenerarInventario_Load(object sender, EventArgs e)
        {
            lblTotalPrecioVenta.Text = lblTotalPrecioUnidad.Text = lblActivoPasivo.Text = lblEntradaTotal.Text = lblTotalProductos.Text = lblSalidaTotal.Text = "";
        }

        void datos_generales()
        {
            try
            {
                using (ContextEntities db = new ContextEntities())
                {
                    gridProductos.DataSource = db.Productoes.Select(x => new { x.idproducto, x.nombre, x.categoria, x.descripcion, x.preciounidad, x.precioventa }).ToList();
                    lblTotalProductos.Text = db.Productoes.GroupBy(o => o.idproducto).Count().ToString();
                    lblTotalPrecioUnidad.Text = db.Productoes.Sum(x => x.preciounidad).ToString();

                    String ProPrecioVenta = db.Productoes.Sum(x => x.precioventa).ToString();
                    String ProEntradaTotal = db.DetFacturaComps.Sum(x => x.total).ToString();
                    String ProSalidaTotal = db.DetDocVentas.Sum(x => x.total).ToString();
                    lblTotalPrecioVenta.Text = ProPrecioVenta;
                    lblEntradaTotal.Text = ProEntradaTotal;
                    lblSalidaTotal.Text = ProSalidaTotal;
                    lblActivoPasivo.Text = (Convert.ToDouble(ProEntradaTotal)
                        + Convert.ToDouble(ProPrecioVenta)
                        - Convert.ToDouble(ProSalidaTotal)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Faltan algunos datos...procesando." );
            }
        }

        private void btnGenerarInventario_Click(object sender, EventArgs e)
        {
            datos_generales();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (ContextEntities db = new ContextEntities())
                {
                    gridProductos.DataSource = db.Productoes.Where(x => x.idproducto == txbFiltro.Text || x.nombre == txbFiltro.Text).Select(x => new { x.idproducto, x.nombre, x.categoria, x.descripcion, x.preciounidad, x.precioventa }).ToList();
                    lblTotalProductos.Text = db.Productoes.Where(x => x.nombre == txbFiltro.Text || x.idproducto == txbFiltro.Text)
                        .GroupBy(o => o.idproducto)
                        .Count()
                        .ToString();

                }
            }
            catch
            {
                MessageBox.Show("Error al filtrar productos..");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
