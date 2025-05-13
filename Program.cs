using dotenv.net;
using Internet_Kafe_Proje.GirisFormlari;

namespace Internet_Kafe_Proje
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // .env dosyasını yükle
            DotEnv.Load();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AnaForm());
        }
    }
}