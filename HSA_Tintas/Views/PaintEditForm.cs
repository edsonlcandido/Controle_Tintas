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
    public partial class PaintEditForm : Form
    {
        PaintModel paintModel;
        public PaintEditForm(int paintId)
        {
            InitializeComponent();
            paintModel = new PaintModel();
            //get paint from GetPaintByIdQuery
            paintModel = Program.ServiceProvider.GetRequiredService<GetPaintByIdQuery>().Execute(paintId);

        }

        private void PaintEditForm_Load(object sender, EventArgs e)
        {
            //get data anotation from PaintModel.Code to labelCodeDisplayName text
            labelCodeDisplayName.Text = paintModel.GetType().GetProperty("Code").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Project to labelProjectDisplayName text
            labelProjectDisplayName.Text = paintModel.GetType().GetProperty("Project").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Description to labelDescriptionDisplayName text
            labelDescriptionDisplayName.Text = paintModel.GetType().GetProperty("Description").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.CanQty to labelCanQtyDisplayName text
            labelCanQtyDisplayName.Text = paintModel.GetType().GetProperty("CanQty").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Liters to labelLitersDisplayName text
            labelLitersDisplayName.Text = paintModel.GetType().GetProperty("Liters").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from Paintmodel.InsertionDate to labelInsetionDateDisplayName text
            labelInsertionDateDisplayName.Text = paintModel.GetType().GetProperty("InsertionDate").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.ExpirationDate to labelExpirationDateDisplayName text
            labelExpirationDateDisplayName.Text = paintModel.GetType().GetProperty("ExpirationDate").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Status to labelStatusDisplayName text
            labelStatusDisplayName.Text = paintModel.GetType().GetProperty("Status").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Obs to labelObsDisplayName text
            labelObsDisplayName.Text = paintModel.GetType().GetProperty("Obs").GetCustomAttribute<DisplayNameAttribute>().DisplayName;

            GetAllPaintStatusQuery GetAllPaintStatusQuery = Program.ServiceProvider.GetRequiredService<GetAllPaintStatusQuery>();
            //set comboBoxPaintStatus DataSource from GetAllPaintStatusQuery
            comboBoxPaintStatus.DataSource = GetAllPaintStatusQuery.Execute();

            paintModelToForm();
        }

        private void paintModelToForm()
        {
            //set paintModel.Code to textBoxPaintCode text
            textBoxPaintCode.Text = paintModel.Code;
            //set paintModel.Project to textBoxPaintProject text
            textBoxPaintProject.Text = paintModel.Project;
            //set paintModel.Description to textBoxPaintDescription text
            textBoxPaintDescription.Text = paintModel.Description;
            //set paintModel.CanQty to textBoxPaintCanQty text
            textBoxPaintCanQty.Text = paintModel.CanQty.ToString();
            //set paintModel.Liters to textBoxPaintLiters text
            textBoxPaintLiters.Text = paintModel.Liters.ToString();
            //set paintModel.InsertionDate to dateTimePickerPaintInsertionDate.Value
            dateTimePickerPaintInsertionDate.Value = paintModel.InsertionDate;
            //set paintModel.ExpirationDate to dateTimePickerPaintExpirationDate.Value
            dateTimePickerPaintExpirationDate.Value = paintModel.ExpirationDate;
            //set comboBoxPaintStatus from paintModel.Status
            comboBoxPaintStatus.SelectedItem = paintModel.Status;
            //set paintModel.Obs to textBoxPaintObs text
            textBoxPaintObs.Text = paintModel.Obs;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {

            PaintModel paint = formToPaintModel();
            //paintModel.Obs = textBoxPaintObs.Text;
            if (paint != null)
            {
                try
                {
                    //if paint is valid, update paint
                    Program.ServiceProvider.GetRequiredService<UpdatePaintCommand>().Execute(paint).Wait();

                    MessageBox.Show("Tinta editada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //invoke cancel button click event
                    buttonCancel.PerformClick();
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else
            {
                //if paint is not valid, show error message
                MessageBox.Show("Erro ao editar tinta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PaintModel formToPaintModel()
        {
            paintModel.Code = textBoxPaintCode.Text;
            paintModel.Project = textBoxPaintProject.Text;
            paintModel.Description = textBoxPaintDescription.Text;
            paintModel.CanQty = Convert.ToInt32(textBoxPaintCanQty.Text);
            paintModel.Liters = Convert.ToDouble(textBoxPaintLiters.Text);
            //convert dateTimePickerPaintInsertionDate.Value to DateOnly with format YYYY-MM-DD
            paintModel.InsertionDate = dateTimePickerPaintInsertionDate.Value;
            //set insertion date to 00:00:00
            paintModel.InsertionDate = paintModel.InsertionDate.Date;
            //convert dateTimePickerPaintExpirationDate.Value to DateOnly with format YYYY-MM-DD
            paintModel.ExpirationDate = dateTimePickerPaintExpirationDate.Value;
            //set expiration date to 00:00:00
            paintModel.ExpirationDate = paintModel.ExpirationDate.Date;
            paintModel.Status = comboBoxPaintStatus.SelectedItem.ToString();
            paintModel.Obs = textBoxPaintObs.Text;

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
            Views.PaintProjectsForm formPaintProjects = Program.ServiceProvider.GetRequiredService<Views.PaintProjectsForm>();
            formMain.ShowInMdiContainer(formPaintProjects);
        }
    }
}
