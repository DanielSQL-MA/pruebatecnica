using prueba_examen.ControlUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void ventasxarticulo_Click(object sender, EventArgs e)
        {
            ventasxarticulo vxa = new ventasxarticulo();
            addUserControl(vxa);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ventasglobales vg = new ventasglobales();
            addUserControl(vg);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            articulostop at= new articulostop();
            addUserControl(at);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            articulosstock ast= new articulosstock();
            addUserControl(ast);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            notificaciones nt= new notificaciones();
            addUserControl(nt);
        }
    }
}
