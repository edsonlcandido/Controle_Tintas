using Controle_Tintas.Domain.Commands;
using Controle_Tintas.Domain.Models;
using Controle_Tintas.Domain.Queries;
using Controle_Tintas.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Controle_Tintas
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainForm>();
            services.AddTransient<UserForm>();
            services.AddTransient<PaintProjectsForm>();
            services.AddTransient<PaintAddToProjectForm>();
            services.AddTransient<UserModel>();            
            //register all queries and commands here
            services.AddTransient<GetAllUsersQuery>();            
            services.AddTransient<GetUserByIdQuery>();
            services.AddTransient<CreateUserCommand>();
            services.AddTransient<UpdateUserCommand>();
            services.AddTransient<DeleteUserCommand>();
            services.AddTransient<GetAllPaintStatusQuery>();
            services.AddTransient<CreatePaintCommand>();
            services.AddTransient<GetAllPaintsQuery>();
            services.AddTransient<GetPaintsAvailableAndInUseQuery>();

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
            using (IServiceScope scope = ServiceProvider.CreateScope()) // Throwaway scope to avoid potential NULL parameter
            {
                MainForm formMain = scope.ServiceProvider.GetRequiredService<MainForm>();
                Application.Run(formMain);
            }
        }
    }
}