using Controle_Tintas.Domain.Models;
using Controle_Tintas.Domain.Queries;
using Controle_Tintas.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Controle_Tintas
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainForm>();
            services.AddTransient<UserForm>();
            services.AddTransient<UserModel>();
            services.AddTransient<GetAllUsersQuery>();
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
            MainForm formMain = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(formMain);
        }
    }
}