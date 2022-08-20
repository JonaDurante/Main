using System.Data;
using Lucas_Mata.Class;
using Lucas_Mata.Mappers;
using System.Data.SqlClient;

namespace Lucas_Mata.DataBase
{
    public class UsuarioHandler : DBHandler
    {
        public Usuario GetUsuario(string NombreUsuario)
        {
            UsuarioMapper MapperUsuario = new UsuarioMapper();
            var query = "SELECT * FROM Usuario where NombreUsuario = @NombreUsuario";
            var sqlParamenter = new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = NombreUsuario };
            var a = DBHandler.Execute(query, sqlParamenter, MapperUsuario);
            return (Usuario)a;
        }
    }
}
