using Lucas_Mata.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_Mata.DataBase
{
    public class UsuarioMapper
    {
        public dynamic Mapper([Optional] SqlDataReader dataReader)
        {
            Usuario usuario = new Usuario();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    usuario.Id = Convert.ToInt32(dataReader["ID"]);
                    usuario.Nombre = dataReader["Nombre"].ToString();
                    usuario.Apellido = dataReader["Apellido"].ToString();
                    usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                    usuario.Contraseña = dataReader["Contraseña"].ToString();
                    usuario.Mail = dataReader["Mail"].ToString();
                }
            }
            return usuario;
        }
    }
}
