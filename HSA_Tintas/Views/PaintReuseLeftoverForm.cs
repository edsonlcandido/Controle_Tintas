using Controle_Tintas.Domain.Commands;
using Controle_Tintas.Domain.Models;
using Controle_Tintas.Domain.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Tintas.Views
{
    public partial class PaintReuseLeftoverForm : Form
    {
        PaintModel paintModel;
        public PaintReuseLeftoverForm(int paintId)
        {
            InitializeComponent();
            paintModel = Program.ServiceProvider.GetRequiredService<GetPaintByIdQuery>().Execute(paintId);
        }

        private void PaintAddToProjectForm_Load(object sender, EventArgs e)
        {
            //get data anotation from PaintModel.Code to labelCodeDisplayName text
            labelCodeDisplayName.Text = paintModel.GetType().GetProperty("Code").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Project to labelProjectDisplayName text
            labelProjectDisplayName.Text = paintModel.GetType().GetProperty("Project").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Description to labelDescriptionDisplayName text
            labelDescriptionDisplayName.Text = paintModel.GetType().GetProperty("Description").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.CanQty to labelCanQtyDisplayName text
            labelCanQtyDisplayName.Text = paintModel.GetType().GetProperty("CanQty").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Obs to labelObsDisplayName text
            labelObsDisplayName.Text = paintModel.GetType().GetProperty("Obs").GetCustomAttribute<DisplayNameAttribute>().DisplayName;

            paintModelToForm();
        }

        private void paintModelToForm()
        {
            //set paintModel.Code to textBoxPaintCode text
            this.textBoxPaintCode.Text = paintModel.Code;
            //set paintModel.Project to textBoxPaintProject text
            this.textBoxPaintProject.Text = paintModel.Project;
            //set paintModel.Description to textBoxPaintDescription text
            this.textBoxPaintDescription.Text = paintModel.Description;
            //set paintModel.CanQty to textBoxPaintCanQty text
            this.textBoxPaintCanQty.Text = paintModel.CanQty.ToString();
            //set paintModel.Obs to textBoxPaintObs text
            this.textBoxPaintObs.Text = paintModel.Obs;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {

            PaintModel paint = formToPaintModel();
            if (paint != null)
            {
                //if paint is valid, add paint to project
                Program.ServiceProvider.GetRequiredService<UpdatePaintToInUseCommand>().Execute(paint);
                MessageBox.Show("Tinta adicionada ao projeto com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //invoke cancel button click event
                buttonCancel.PerformClick();
            }
            else
            {
                //if paint is not valid, show error message
                MessageBox.Show("Erro ao adicionar tinta ao projeto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PaintModel formToPaintModel()
        {
            paintModel.CanQty = Convert.ToInt32(textBoxPaintCanQty.Text);
            paintModel.Project = textBoxPaintProject.Text;

            //verify if paintModel is valid
            ICollection<ValidationResult> validationResults;
            if (!paintModel.IsValid(out validationResults))
            {
                //if paintModel is not valid, show error messages
                foreach (ValidationResult validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }
            return paintModel;
        }

        private void PaintAddToProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void PaintAddToProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //get form main from ServiceProvider
            Views.MainForm formMain = Program.ServiceProvider.GetRequiredService<Views.MainForm>();

            //get form PaintProjectsForm from ServiceProvider
            Views.PaintLeftoverForm paintLeftoverForm = Program.ServiceProvider.GetRequiredService<Views.PaintLeftoverForm>();
            formMain.ShowInMdiContainer(paintLeftoverForm);
        }
    }
}
