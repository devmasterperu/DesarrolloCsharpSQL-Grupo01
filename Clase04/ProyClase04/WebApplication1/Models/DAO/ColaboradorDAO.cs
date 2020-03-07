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
            on col.idTipoDocumento = td.idTipoDocumento
            where estado = 'A'
             */
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
        public ColaboradorBEAN datosColaborador(int id)
        {
            //CREATE PROCEDURE SP_COLABORADOR_Edit
            //@id int
            //as
            //select idColaborador, nombreColaborador, apellidoColaborador, 
            //numeroDocumentoColaborador--, idRol, idTipoDocumento
            //from tb_Colaborador
            //where idColaborador = @id

            ColaboradorBEAN colBEAN = new ColaboradorBEAN();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader lector;
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_COLABORADOR_Edit";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = ConexionBD.GetConnection();
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    colBEAN.IdColaborador = lector.GetInt32(0);
                    colBEAN.NombreColaborador = lector.GetString(1);
                    colBEAN.ApellidoColaborador = (string)lector[2];
                    colBEAN.NumDocColaborador = (string)lector[3];
                }
            }
            catch (Exception)
            {

                throw;
            }
            return colBEAN;
        }
        public bool editarColaborador(ColaboradorBEAN colBEAN)
        {
            //CREATE PROCEDURE SP_COLABORADOR_Editar
            //@idColaborador int,
            //@nombreColaborador varchar(50),
            //@apellidoColaborador varchar(50),
            //@numeroDocumentoColaborador varchar(50)
            //as
            //UPDATE tb_Colaborador
            //SET nombreColaborador = @nombreColaborador,
            //apellidoColaborador = @apellidoColaborador,
            //numeroDocumentoColaborador = @numeroDocumentoColaborador
            //WHERE idColaborador = @idColaborador

            bool rpta = false;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_COLABORADOR_Editar";
                cmd.Parameters.AddWithValue("@idColaborador",colBEAN.IdColaborador);
                cmd.Parameters.AddWithValue("@nombreColaborador", colBEAN.NombreColaborador);
                cmd.Parameters.AddWithValue("@apellidoColaborador", colBEAN.ApellidoColaborador);
                cmd.Parameters.AddWithValue("@numeroDocumentoColaborador", colBEAN.NumDocColaborador);
                cmd.Connection = ConexionBD.GetConnection();
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception)
            {
                throw;
            }
            return rpta;
        }
        public bool agregarColaborador(ColaboradorBEAN colBEAN)
        {
            //CREATE PROCEDURE SP_COLABORADOR_Add
            //@nombreColaborador varchar(50), 
            //@apellidoColaborador varchar(50), 
            //@numeroDocumentoColaborador varchar(20),
            //@idRol int
            //AS
            //INSERT INTO tb_Colaborador
            //(nombreColaborador, apellidoColaborador, numeroDocumentoColaborador,
            // idRol, idTipoDocumento, estado)
            // values(@nombreColaborador, @apellidoColaborador,
            // @numeroDocumentoColaborador, @idRol, 1, 'A')
            bool rpta = false;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_COLABORADOR_Add";
                cmd.Parameters.AddWithValue("@nombreColaborador", colBEAN.NombreColaborador);
                cmd.Parameters.AddWithValue("@apellidoColaborador", colBEAN.ApellidoColaborador);
                cmd.Parameters.AddWithValue("@numeroDocumentoColaborador", colBEAN.NumDocColaborador);
                cmd.Parameters.AddWithValue("@idRol", colBEAN.IdRol);
                cmd.Connection = ConexionBD.GetConnection();
                cmd.ExecuteNonQuery();
                rpta = true;
            }
            catch (Exception)
            {
                throw;
            }
            return rpta;
        }

        public bool deleteColaborador(int id)
        {
            //create procedure SP_COLABORADOR_Delete
            //@id int
            //as
            //UPDATE tb_Colaborador
            //SET estado = 'I'
            //where idColaborador = @id
            bool rpta = false;
            SqlCommand cmd = new SqlCommand();            
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_COLABORADOR_Delete";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = ConexionBD.GetConnection();
                cmd.ExecuteReader();
                rpta = true;
            }
            catch (Exception)
            {

                throw;
            }
            return rpta;
        }
        public List<RolBEAN> listaRoles()
        {
            List<RolBEAN> lista = new List<RolBEAN>();
            SqlCommand cmd = new SqlCommand();
            RolBEAN rolBEAN;
            SqlDataReader lector;
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ROL_List";
                cmd.Connection = ConexionBD.GetConnection();
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    rolBEAN = new RolBEAN();
                    rolBEAN.IdRol = lector.GetInt32(0);
                    rolBEAN.NombreRol = lector.GetString(1);
                    lista.Add(rolBEAN);
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