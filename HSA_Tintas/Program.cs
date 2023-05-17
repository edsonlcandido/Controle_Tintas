using Microsoft.Extensions.DependencyInjection;

namespace Controle_Tintas
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<FormMain>();
            services.AddTransient<View.User>();
            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ConfigureServices();
            FormMain formMain = ServiceProvider.GetRequiredService<FormMain>();
            Application.Run(formMain);
        }
    }
}