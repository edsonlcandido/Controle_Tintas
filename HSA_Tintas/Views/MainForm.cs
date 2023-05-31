using Microsoft.Extensions.DependencyInjection;

namespace Controle_Tintas.Views
{
    public partial class MainForm : Form
    {
        //get size of MdiContainer and set to prop MdiClient _mdiClient
        private MdiClient _mdiClient;
        internal MdiClient MdiClient
        {
            get
            {
                if (_mdiClient == null)
                {
                    foreach (Control control in this.Controls)
                    {
                        if (control is MdiClient)
                        {
                            _mdiClient = control as MdiClient;
                            break;
                        }
                    }
                }

                if (_mdiClient == null)
                {
                    _mdiClient = new MdiClient();
                    this.Controls.Add(_mdiClient);
                }

                return _mdiClient;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = Controle_Tintas.Properties.Settings.Default.MainFormTitle;

        }

        //Create a method to show form in MdiContainer
        public void ShowInMdiContainer(Form form)
        {
            foreach (Form mdiChild in MdiChildren)
            {
                mdiChild.Close();
            }
            form.MdiParent = this;
            form.Show();
            form.Size = new Size(this.MdiClient.Width - 4, this.MdiClient.Height - 4);
            form.Location = new Point(0, 0);
        }

        private void buttonShowUserForm_Click(object sender, EventArgs e)
        {
            //get formMain from ServiceProvider
            Views.MainForm formMain = Program.ServiceProvider.GetRequiredService<Views.MainForm>();
            //get formUser from ServiceProvider
            Views.UserForm formUser = Program.ServiceProvider.GetRequiredService<Views.UserForm>();

            //show formUser in MdiContainer
            formMain.ShowInMdiContainer(formUser);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //verify if MdiClient is not null
            if (MdiClient != null)
            {
                //loop through MdiClient child forms
                foreach (Form mdiChild in MdiClient.Controls)
                {
                    //set child form size to MdiClient size
                    mdiChild.Size = new Size(this.MdiClient.Width - 4, this.MdiClient.Height - 4);
                    mdiChild.Location = new Point(0, 0);
                }
            }
        }

        private void buttonShowPaintToProjectForm_Click(object sender, EventArgs e)
        {
            //get form main from ServiceProvider
            Views.MainForm formMain = Program.ServiceProvider.GetRequiredService<Views.MainForm>();

            //get form PaintProjectsForm from ServiceProvider
            Views.PaintProjectsForm formPaintProjects = Program.ServiceProvider.GetRequiredService<Views.PaintProjectsForm>();
            formMain.ShowInMdiContainer(formPaintProjects);
        }

        private void buttonShowPaintLeftoverForm_Click(object sender, EventArgs e)
        {
            //get form main from ServiceProvider
            Views.MainForm formMain = Program.ServiceProvider.GetRequiredService<Views.MainForm>();

            //get form PaintProjectsForm from ServiceProvider
            Views.PaintLeftoverForm paintLeftoverForm = Program.ServiceProvider.GetRequiredService<Views.PaintLeftoverForm>();
            formMain.ShowInMdiContainer(paintLeftoverForm);
        }

        private void buttonReportForm_Click(object sender, EventArgs e)
        {
            ShowReportForm();
        }

        //method to show report form in MdiContainer
        public void ShowReportForm()
        {
            //get form main from ServiceProvider
            Views.MainForm formMain = Program.ServiceProvider.GetRequiredService<Views.MainForm>();
            //get report form from ServiceProvider
            Views.ReportForm reportForm = Program.ServiceProvider.GetRequiredService<Views.ReportForm>();
            formMain.ShowInMdiContainer(reportForm);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            ShowReportForm();
        }
    }
}