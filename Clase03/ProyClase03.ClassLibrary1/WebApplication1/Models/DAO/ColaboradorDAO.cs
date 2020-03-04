using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models.BEAN;

namespace WebApplication1.Models.DAO
{
    public class ColaboradorDAO
    {
        public List<ColaboradorBEAN> listaColaborador()
        {/*
            CREATE PROCEDURE SP_COLABORADOR_List
            as
            select col.idColaborador, col.nombreColaborador, col.apellidoColaborador,
            col.numeroDocumentoColaborador, r.nombreRol, td.nombreTipoDocumento
            from tb_Colaborador col inner join tb_Rol r
            on col.idRol = r.idRol inner join tb_TipoDocumento td
            on col.idTipoDocumento = td.idTipoDocumento*/
            List<ColaboradorBEAN> lista = new List<ColaboradorBEAN>();
            SqlCommand cmd = new SqlCommand();
            ColaboradorBEAN colBEAN;
            SqlDataReader lector;
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_COLABORADOR_List";
                cmd.Connection = ConexionBD.GetConnection();
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    colBEAN = new ColaboradorBEAN();
                    colBEAN.IdColaborador = lector.GetInt32(0);
                    colBEAN.NombreColaborador = lector.GetString(1);
                    colBEAN.ApellidoColaborador = lector.GetString(2);
                    colBEAN.NumDocColaborador = lector.GetString(3);
                    colBEAN.NombreRol = lector.GetString(4);
                    colBEAN.NombreTipoDoc = lector.GetString(5);
                    lista.Add(colBEAN);
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