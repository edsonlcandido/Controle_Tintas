using Controle_Tintas.Domain.Commands;
using Controle_Tintas.Domain.Models;
using Controle_Tintas.Domain.Queries;
using Controle_Tintas.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Controle_Tintas
{
    internal static class Program
    {
        public static string version
        {
            get
            {
                return "1.1.0-alpha";
            }
        }
        public static IServiceProvider? ServiceProvider { get; private set; }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainForm>();
            services.AddTransient<UserForm>();
            services.AddTransient<PaintProjectsForm>();
            services.AddTransient<PaintAddToProjectForm>();
            services.AddTransient<PaintAddToLeftoverForm>();
            services.AddTransient<PaintLeftoverForm>();
            services.AddTransient<PaintEditForm>();
            services.AddTransient<PaintReuseLeftoverForm>();
            services.AddTransient<ReportForm>();
            services.AddTransient<UserModel>();  
            services.AddTransient<PaintModel>();
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
            services.AddTransient<GetPaintByIdQuery>();
            services.AddTransient<UpdatePaintToInUseCommand>();
            services.AddTransient<UpdatePaintToLeftoverCommand>();
            services.AddTransient<GetPaintsByStatusQuery>();
            services.AddTransient<UpdatePaintToDiscardCommand>();
            services.AddTransient<GetUserByNameQuery>();
            services.AddTransient<UpdatePaintCommand>();

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
                //get windows user name to upper
                string userName = Environment.UserName.ToUpper();
                //verify if username to upper is in GetUserBynameQuery
                UserModel? user = scope.ServiceProvider.GetRequiredService<GetUserByNameQuery>().Execute(userName);
                if (user != null)
                {
                    if (!user.IsAdmin)
                    {
                        MainForm formMain = scope.ServiceProvider.GetRequiredService<MainForm>();
                        //hide control flowLayoutPanel flowLayoutPanelMain from formMain
                        formMain.flowLayoutPanelMain.Hide();
                        //show PaintleftoverForm in MdiContainer
                        PaintLeftoverForm paintLeftoverForm = scope.ServiceProvider.GetRequiredService<PaintLeftoverForm>();
                        paintLeftoverForm.buttonDicardPaint.Hide();
                        paintLeftoverForm.buttonShowPaintReuseLeftoverForm.Hide();
                        formMain.ShowInMdiContainer(paintLeftoverForm);
                        formMain.Width = formMain.Width + 1;
                        Application.Run(formMain);
                    }
                    else
                    {
                        MainForm formMain = scope.ServiceProvider.GetRequiredService<MainForm>();
                        Application.Run(formMain);
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado no sistema. Contate o administrador do sistema.\n" +
                        "Nome de usuario: " + userName, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}