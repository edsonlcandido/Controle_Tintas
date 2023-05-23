using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Tintas.Views
{
    public partial class PaintProjectsForm : Form
    {
        public PaintProjectsForm()
        {
            InitializeComponent();
        }

        private void buttonShowPaintAddToProjectForm_Click(object sender, EventArgs e)
        {
            //get formMain from ServiceProvider
            Views.MainForm formMain = Program.ServiceProvider.GetRequiredService<Views.MainForm>();
            //het PaintAddToProjectForm from ServiceProvider
            Views.PaintAddToProjectForm formPaintAddToProject = Program.ServiceProvider.GetRequiredService<Views.PaintAddToProjectForm>();
            formMain.ShowInMdiContainer(formPaintAddToProject);
        }
    }
}
