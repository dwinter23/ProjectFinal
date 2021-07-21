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
    public partial class OrdenCompra : Form
    {

        DataTable table = new DataTable(); // Crear la tabla para agregar datos a los productos finales.

        public OrdenCompra()
        {
            InitializeComponent();
        }

        private void OrdenCompra_Load(object sender, EventArgs e)
        {
            cargarProveedores();
            cargarTodosProductos();
            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("categoria", typeof(string));
            table.Columns.Add("Precio_Unidad", typeof(double));
            table.Columns.Add("Precio_Venta", typeof(double));
            gridProductoFinal.DataSource = table;
        }

        void cargarProveedores()
        {
            try {
                using (ContextEntities db = new ContextEntities())
                {
                    List<String> lista = db.Proveedors.Select(s => s.nombrecontacto).ToList();
                    foreach (var ls in lista)
                    {
                        txbProveedores.Items.Add(ls);
                    }
                }
            } catch { }
        }
        void cargarTodosProductos()
        {
            using (ContextEntities db = new ContextEntities())
            {
                gridProductos.DataSource = db.Productoes
                    .Select(s => new { Nombre = s.nombre, Categoria = s.categoria, Precio_Unidad = s.preciounidad, Precio_Venta = s.precioventa }).ToList();
            }
        }

        //double total = 0;
        private void btnMover_Click(object sender, EventArgs e)
        {
            double total = 0;
            lblCostoTotal.Text = "";
            var nombre = gridProductos.SelectedCells[0].Value.ToString();
            var categoria = gridProductos.SelectedCells[1].Value.ToString();
            var precio_unidad = gridProductos.SelectedCells[2].Value.ToString();
            var precio_venta = gridProductos.SelectedCells[3].Value.ToString();

            // MessageBox.Show(nombre + categoria + precio_unidad + precio_venta);  // Mostrar datos en un message box de prueva

            table.Rows.Add(nombre, categoria, Convert.ToDouble(precio_unidad), Convert.ToDouble(precio_venta));
            // Agregar datos a la tabla productos finales.

            //Mostrar el total
            foreach (DataGridViewRow recorrido in gridProductoFinal.Rows)
            {
                foreach (DataGridViewCell cell in recorrido.Cells)
                {
                    if (cell.ColumnIndex == 3) //Set your Column Index
                    {
                        total = total + Convert.ToDouble(cell.Value);
                        lblCostoTotal.Text = total.ToString();
                        }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in gridProductoFinal.SelectedRows)

                if (!row.IsNewRow)

                    gridProductoFinal.Rows.Remove(row);

            foreach (DataGridViewRow recorrido in gridProductoFinal.Rows)
            {
                foreach (DataGridViewCell cell in recorrido.Cells)
                {
                    if (cell.ColumnIndex == 3) //Set your Column Index
                    {
                        total = total + Convert.ToDouble(cell.Value);
                        lblCostoTotal.Text = total.ToString();
                    }
                }
            }
        }
    }
}
