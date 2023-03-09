using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
   

        public class DALContacto
        { 


        

        public void Create(DOMContacto pcontacto)
        {
            var con = new SqlConnection(@"Data Source=MASTER-PC\SQLEXPRESS;Initial Catalog=Agenda;Integrated Security=True");

            SqlTransaction transaccion = null;
            try
        {
          

            con.Open();

            transaccion = con.BeginTransaction();

            var comm = new SqlCommand("INSERT INTO Contactos (con_nombre, con_apellido, con_email, con_edad) VALUES (@Nombre, @Apellido, @Email, @Edad)", con);

            comm.Parameters.AddWithValue("Nombre", pcontacto.nombre);
            comm.Parameters.AddWithValue("Apellido", pcontacto.apellido);
            comm.Parameters.AddWithValue("Email", pcontacto.email);
            comm.Parameters.AddWithValue("Edad", pcontacto.edad);

            comm.Transaction = transaccion;

            var resultado = comm.ExecuteNonQuery();

            transaccion.Commit();

            MessageBox.Show("El contacto se ha registrado correctamente.");



        }
        catch (Exception)
        {
            if (transaccion != null)
                transaccion.Rollback();
            throw new Exception("El contacto no se registro correctamente.");

        }
        finally
        {
            con.Close();
            Form.ActiveForm.Close();

        }
    }
    }
}
