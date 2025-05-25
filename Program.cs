using System.Runtime.InteropServices;
using dotenv.net;
using Internet_Kafe_Proje.Forms;

namespace Internet_Kafe_Proje
{
    internal static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            // Konsol ile aç
            AllocConsole();

            // .env dosyasını yükle
            DotEnv.Load();

            foreach (var pair in DotEnv.Read())
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AnaGirisSecimForm());
        }
    }
}