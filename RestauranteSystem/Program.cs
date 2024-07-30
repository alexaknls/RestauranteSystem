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
<<<<<<< HEAD
            //ApplicationConfiguration.Initialize();
            //Application.Run(new RestauranteSystem.Login.Main());

            Application.Run(new RestauranteSystem.Reservas.frmReservas());
=======
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new RestauranteSystem.Forms.Clientes.FrmClientes());
=======
            Application.Run(new RestauranteSystem.Login.Seguridad.Login());
>>>>>>> ba77c355c82dc54ca88a7c89bb4bc2dd77c8fc9e
>>>>>>> 66f08e23fedeee50ac57d8931a5ed30abaccd017
        }
    }
}