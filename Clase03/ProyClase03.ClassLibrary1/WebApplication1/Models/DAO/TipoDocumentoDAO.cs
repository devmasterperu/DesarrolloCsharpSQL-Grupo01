using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models.BEAN;

namespace WebApplication1.Models.DAO
{
    public class TipoDocumentoDAO
    {
        public List<TipoDocumentoBEAN> listaTipoDocumentos()
        {
            /*
            CREATE PROCEDURE SP_TIPODOCUMENTO_List
            as
            BEGIN
            select idTipoDocumento, nombreTipoDocumento
            from tb_TipoDocumento
            END*/

            List<TipoDocumentoBEAN> lista = new List<TipoDocumentoBEAN>();
            SqlCommand cmd = new SqlCommand();
            TipoDocumentoBEAN tpBEAN;
            SqlDataReader lector;
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_TIPODOCUMENTO_List";
                cmd.Connection = ConexionBD.GetConnection();
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    tpBEAN = new TipoDocumentoBEAN();
                    tpBEAN.IdTipoDocumento = lector.GetInt32(0);
                    tpBEAN.NombreTipoDocumento = lector.GetString(1);
                    lista.Add(tpBEAN);
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