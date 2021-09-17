using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WPF_Restaurant.Model
{
    class DbConnection
    {
        static string connString = "Data Source=DESKTOP-910JD2V;Initial Catalog=WPF;User ID=sa;Password=1234";
        public SqlConnection conn = new SqlConnection(connString);

        public int Crear_Categoria(Categorias categorias)
        {
            int res = 1;
            try
            {
                string sql = "SetCategoria";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", categorias.id);
                cmd.Parameters.AddWithValue("@nombre", categorias.Nombre_Categoria);
                cmd.Parameters.AddWithValue("@descripcion", categorias.Descripcion_Categoria);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                res = 1;
            }
            finally
            {
                res = 1;
                conn.Close();
            }
            return res;
        }

    }
}
