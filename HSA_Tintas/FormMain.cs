using Microsoft.Extensions.DependencyInjection;

namespace Controle_Tintas
{
    public partial class FormMain : Form
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
                return _mdiClient;
            }
        }

        public FormMain()
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

        private void button3_Click(object sender, EventArgs e)
        {
            //get formMain from ServiceProvider
            FormMain formMain = Program.ServiceProvider.GetRequiredService<FormMain>();
            //get formUser from ServiceProvider
            View.User formUser = Program.ServiceProvider.GetRequiredService<View.User>();

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
    }
}