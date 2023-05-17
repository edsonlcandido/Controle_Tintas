namespace Controle_Tintas
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = Controle_Tintas.Properties.Settings.Default.MainFormTitle;
        }
    }
}