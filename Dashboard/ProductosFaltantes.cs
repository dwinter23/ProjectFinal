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
    public partial class ProductosFaltantes : Form
    {
        public ProductosFaltantes()
        {
            InitializeComponent();
        }

        private void ProductosFaltantes_Load(object sender, EventArgs e)
        {
            ListarProdFaltantes();
        }

        void ListarProdFaltantes()
        {
            lbltimeProdFaltantes.Text = DateTime.Now.ToString();
            try
            {
                using (ContextEntities db = new ContextEntities())
                {
                    
                    gridProductosFaltantes.DataSource = db.Productoes.Where(x => x.unidadesstock == 0).Select(x => new { x.nombre, x.unidadesstock}).ToList();
                }
            }
            catch
            {
                MessageBox.Show("Error al generar lista: Revisar => 'Error en (PK)'");
            }
        }
    }
}
//gridProductosFaltantes.DataSource = db.DetProdFaltantes.Where(x => x.cantidad == 0).Select(x => new { Nombre = x.detalle, x.cantidad}).ToList();