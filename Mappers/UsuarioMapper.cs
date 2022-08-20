using Lucas_Mata.Class;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Lucas_Mata.Mappers
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
