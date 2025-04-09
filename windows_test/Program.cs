using System;
using DotNetEnv;
namespace windows_test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Load environment variables from .env file
            Env.Load();

            // Tes koneksi
            string connectionString = DatabaseHelper.GetConnectionString();
            Console.WriteLine(connectionString);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DataKategori());
        }
    }
}