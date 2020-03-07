using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models.BEAN;

namespace WebApplication1.Models.DAO
{
    public class CategoriaDAO
    {
        public List<CategoriaBEAN> listaCategorias()
        {
            //CREATE PROCEDURE SP_CATEGORIA_List
            //as
            //select idCategoria, nombreCategoria
            //from tb_Categoria

            List<CategoriaBEAN> lista = new List<CategoriaBEAN>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader lector;
            CategoriaBEAN catBEAN;
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CATEGORIA_List";
                cmd.Connection = ConexionBD.GetConnection();
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    catBEAN = new CategoriaBEAN();
                    catBEAN.IdCategoria = lector.GetInt32(0);
                    catBEAN.NombreCategoria = lector.GetString(1);
                    lista.Add(catBEAN);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
    }
}