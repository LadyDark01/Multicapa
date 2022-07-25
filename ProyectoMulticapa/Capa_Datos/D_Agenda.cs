using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEnlace;
using System.Data;

namespace Capa_Datos
{
    public class D_Agenda
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Agenda> ListarContacto(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCONTACTO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerFilas = cmd.ExecuteReader();

            List<E_Agenda> Listar = new List<E_Agenda>();
            while (leerFilas.Read())
            {
                Listar.Add(new E_Agenda
                {
                    ID = leerFilas.GetInt32(0),
                    Nombre = leerFilas.GetString(1),
                    Apellido = leerFilas.GetString(2),
                    Genero = leerFilas.GetString(3),
                    Estado_Civil = leerFilas.GetString(4),
                    Telefono = leerFilas.GetString(5),
                    Direccion = leerFilas.GetString(6),
                    Correo = leerFilas.GetString(7)
                });
            }
            cn.Close();
            leerFilas.Close();
            return Listar;
        }

        public void InsertarContacto(E_Agenda agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCONTACTO",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", agenda.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", agenda.Apellido);
            cmd.Parameters.AddWithValue("@GENERO", agenda.Genero);
            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", agenda.Estado_Civil);
            cmd.Parameters.AddWithValue("@TELEFONO",agenda.Telefono);
            cmd.Parameters.AddWithValue("@DIRECCION", agenda.Direccion);
            cmd.Parameters.AddWithValue("@CORREO", agenda.Correo);

            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public void EditarContacto (E_Agenda agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCONTACTO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@ID", agenda.ID);
            cmd.Parameters.AddWithValue("@NOMBRE", agenda.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", agenda.Apellido);
            cmd.Parameters.AddWithValue("@GENERO", agenda.Genero);
            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", agenda.Estado_Civil);
            cmd.Parameters.AddWithValue("@TELEFONO", agenda.Telefono);
            cmd.Parameters.AddWithValue("@DIRECCION", agenda.Direccion);
            cmd.Parameters.AddWithValue("@CORREO", agenda.Correo);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void EliminarContacto(E_Agenda agenda)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCONTACTO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@ID", agenda.ID);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
