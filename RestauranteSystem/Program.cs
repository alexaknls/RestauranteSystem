namespace RestauranteSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new RestauranteSystem.Forms.Clientes.FrmClientes());
=======
            Application.Run(new RestauranteSystem.Login.Seguridad.Login());
>>>>>>> ba77c355c82dc54ca88a7c89bb4bc2dd77c8fc9e
        }
    }
}