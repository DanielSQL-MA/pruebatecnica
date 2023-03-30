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

namespace prueba_examen.ControlUser
{
    public partial class ventasxarticulo : UserControl
    {
        public ventasxarticulo()
        {
            InitializeComponent();
        }

        private void ventasxarticulo_Load(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection("Data Source=DMLAP\\SQLEXPRESS; Initial Catalog=examen;User ID=pru;Password=redes_01");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.Productos.Titulo, SUM(dbo.Ventas.CantidadVendida) AS total_ventas\r\nFROM dbo.Productos\r\nJOIN Ventas ON Productos.IDProductos = Ventas.IDProductos\r\nGROUP BY Productos.Titulo\r\nORDER BY total_ventas DESC;", sqlcon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
