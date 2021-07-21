using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
         );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideSubMenu();
        }


        // -------------Button Close
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // ----------------Event --- Click ----> and Leave for Almacen, Compras, Ventas, Settings
        private void btnDashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Reportes";

            showSubMenu(panelReportes);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Configuracion";
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAlmacenLeave(object sender, EventArgs e)
        {
            btnAlmacen.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnComprasClick(object sender, EventArgs e)
        {
            showSubMenu(panelCompras);
            pnlNav.Height = btnCompras.Height;
            pnlNav.Top = btnCompras.Top;
            btnCompras.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Compras";
        }

        private void btnComprasLeave(object sender, EventArgs e)
        {
            btnCompras.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAlmacenClick(object sender, EventArgs e)
        {
            showSubMenu(panelAlmacen);
            pnlNav.Height = btnAlmacen.Height;
            pnlNav.Top = btnAlmacen.Top;
            btnAlmacen.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Almacen";
        }

        private void btnVentasClick(object sender, EventArgs e)
        {
            showSubMenu(panelVentas);
            pnlNav.Height = btnVentas.Height;
            pnlNav.Top = btnVentas.Top;
            btnVentas.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Ventas";
        }

        private void btnVentasLeave(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.FromArgb(24, 30, 54);
        }


        ////    FUNCIONES DE OCULTACION

        private void customizeDesign()
        {
            panelReportes.Visible = false;
            panelAlmacen.Visible = false;
            panelCompras.Visible = false;
            panelVentas.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
            if (panelAlmacen.Visible == true)
                panelAlmacen.Visible = false;
            if (panelCompras.Visible == true)
                panelCompras.Visible = false;
            if (panelVentas.Visible == true)
                panelVentas.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        ////    BUTTONS ----->  Reportes
        private void btnVentasMensuales_Click(object sender, EventArgs e)
        {
            openChildForm(new VentasMensuales());
            hideSubMenu();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new ListarClientes());
            hideSubMenu();
        }

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
            openChildForm(new ListarProveedores());
            hideSubMenu();
        }


        ////    BUTTONS ------> Almacen
        
        private void btnProductosFaltantes_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductosFaltantes());
            hideSubMenu();
        }

        private void btnGenerarInventario_Click(object sender, EventArgs e)
        {
            openChildForm(new GenerarInventario());
            hideSubMenu();
        }


        ////      BUTTONS ---------> Compras

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            openChildForm(new OrdenCompra());
            hideSubMenu();
        }


        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            openChildForm(new Cotizaciones());
            hideSubMenu();
        }

        private void btnFacturaCompra_Click(object sender, EventArgs e)
        {
            openChildForm(new FacturaCompra());
            hideSubMenu();
        }

        private void btnGuiaEntrada_Click(object sender, EventArgs e)
        {
            //openChildForm(new GuiaEntrada);
            hideSubMenu();
        }

        ////    BUTTONS ------> VENTAS

        private void btnGuiaSalida_Click(object sender, EventArgs e)
        {
            //openChildForm(new GuiaSalida());
            hideSubMenu();
        }

        private void btnDocumentoVenta_Click(object sender, EventArgs e)
        {
            openChildForm(new DocumentoVenta());
            hideSubMenu();
        }





        ////    ---------->> FUNCTION TO SHOW CLASS CHILD
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new VentasMensuales());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (ContextEntities db = new ContextEntities())
            {
                //lblUser.Text = db.Usuarios.Select(Usuari);
            }
        }
    }
}
