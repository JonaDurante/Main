namespace Lucas_Mata
{
    class Program
    {
        static void Main(string[] args)
        {   
            InicioSesion CheckSesiom = new InicioSesion();
            CheckSesiom.NombreUsuario = "Lucas666";
            CheckSesiom.Contraseña = "Lucas1234";
            CheckSesiom.Sesion();
        }
    }
}