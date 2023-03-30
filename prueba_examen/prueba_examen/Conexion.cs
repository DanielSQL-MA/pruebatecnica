using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prueba_examen
{
    internal class Conexion
    {
        SqlConnection sqlcon;

        public Conexion()
        {
            try
            {
                sqlcon = new SqlConnection("Data Source=DMLAP\\SQLEXPRESS; Initial Catalog=examen;User ID=pru;Password=redes_01");
                sqlcon.Open();
                MessageBox.Show("Conecatado correctamente","Exito al conectar",MessageBoxButtons.OK);

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Error inesperado", MessageBoxButtons.OK);
            }
            


            
        }
    }
}
