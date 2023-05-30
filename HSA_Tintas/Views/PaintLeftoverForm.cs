using Controle_Tintas.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using Controle_Tintas.Domain.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Controle_Tintas.Domain.Commands;

namespace Controle_Tintas.Views
{
    public partial class PaintLeftoverForm : Form
    {
        PaintModel paintModel;
        IEnumerable<PaintModel> paints;
        public PaintLeftoverForm()
        {
            InitializeComponent();
        }

        private void buttonShowPaintReuseLeftoverForm_Click(object sender, EventArgs e)
        {
            //get currentrow to databind paints from dataGridViewPaintsLeftover
            DataGridViewRow currentRow = dataGridViewPaintsLeftover.CurrentRow;
            //get paintModel from currentRow
            paintModel = (PaintModel)currentRow.DataBoundItem;
            //open PaintReuseLeftoverForm
            PaintReuseLeftoverForm paintReuseLeftoverForm = new PaintReuseLeftoverForm(paintModel.Id);
            //get mainform fro service provider
            MainForm mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();
            //set paintReuseLeftover mainform MDI container  
            mainForm.ShowInMdiContainer(paintReuseLeftoverForm);

        }

        private void PaintProjectsForm_Load(object sender, EventArgs e)
        {
            //start and reseted form status
            textBoxCodeFilter.Text = "";
            textBoxProjectFilter.Text = "";
            textBoxDescriptionFilter.Text = "";

            paintModel = new PaintModel();
            //paint GetAllPaintsAvailableAndInUseQuery to get all paints available and in use from database
            paints = Program.ServiceProvider.GetRequiredService<GetPaintsByStatusQuery>().Execute("SOBRA");

            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void PopulateDataGridViewPaintsAvailableAndInUse(IEnumerable<PaintModel> paints)
        {
            IEnumerable<PaintModel> paintsToDataGridView;
            //clear dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Rows.Clear();
            //clear columns from dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Clear();
            paintsToDataGridView = paints;
            BindingList<PaintModel> bindingPaints = new BindingList<PaintModel>(paintsToDataGridView.ToList());
            dataGridViewPaintsLeftover.AutoGenerateColumns = false;
            dataGridViewPaintsLeftover.DataSource = bindingPaints;
            //add column PaintModel.Code to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Code",
                HeaderText = paintModel.GetType().GetProperty("Code").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelCode",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.Project to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Project",
                HeaderText = paintModel.GetType().GetProperty("Project").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelProject",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.Description to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Description",
                HeaderText = paintModel.GetType().GetProperty("Description").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelDescription",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.CanQty to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CanQty",
                HeaderText = paintModel.GetType().GetProperty("CanQty").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelCanQty",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.Liters to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Liters",
                HeaderText = paintModel.GetType().GetProperty("Liters").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelLiters",
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            //add column with total liters multiple CanQty * Liters
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Total Litros",
                Name = "CalculatedTotalLiters",
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            //add column PaintModel.ExpirationDate to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ExpirationDate",
                HeaderText = paintModel.GetType().GetProperty("ExpirationDate").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelExpirationDate",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.Status to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Status",
                HeaderText = paintModel.GetType().GetProperty("Status").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelStatus",
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            //add column PaintModel.Obs to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Obs",
                HeaderText = paintModel.GetType().GetProperty("Obs").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelObs",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //invoke dataGridViewPaintsAvailableAndInUse_DataBindingComplete event
            dataGridViewPaintsLeftover_DataBindingComplete(this, new DataGridViewBindingCompleteEventArgs(ListChangedType.Reset));

        }

        private void dataGridViewPaintsLeftover_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach row in dataGridViewPaintsAvailableAndInUse to set column TotalLiter value to CanQty * Liters
            foreach (DataGridViewRow row in dataGridViewPaintsLeftover.Rows)
            {
                double CanQty = Convert.ToDouble(row.Cells["PaintModelCanQty"].Value);
                double Liters = Convert.ToDouble(row.Cells["PaintModelLiters"].Value);
                double TotalLiters = CanQty * Liters;
                row.Cells["CalculatedTotalLiters"].Value = TotalLiters;
            }

            //update dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Update();
            //refresh dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsLeftover.Refresh();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            //invoke formload event
            PaintProjectsForm_Load(sender, e);
        }

        private void buttonCodeFilter_Click(object sender, EventArgs e)
        {
            //filter paints by Code to a new paints and update dataGridViewPaintsAvailableAndInUse
            var paints = this.paints.Where(p => p.Code.Contains(textBoxCodeFilter.Text));
            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void buttonProjectFilter_Click(object sender, EventArgs e)
        {
            //filter paints by Project to a new paints and update dataGridViewPaintsAvailableAndInUse
            var paints = this.paints.Where(p => p.Obs.Contains(textBoxProjectFilter.Text));
            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void buttonDescriptionFilter_Click(object sender, EventArgs e)
        {
            //filter paints by Description to a new paints and update dataGridViewPaintsAvailableAndInUse
            var paints = this.paints.Where(p => p.Description.Contains(textBoxDescriptionFilter.Text));
            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void buttonDicardPaint_Click(object sender, EventArgs e)
        {
            PaintModel paintModelCurrentBiding = new PaintModel();
            PaintModel paintModel = new PaintModel();
            //get selected paint from dataGridViewPaintsAvailableAndInUse
            paintModelCurrentBiding = (PaintModel)dataGridViewPaintsLeftover.CurrentRow.DataBoundItem;

            //execute GetPaintByIdQuery.execute fom service provider
            paintModel = Program.ServiceProvider.GetRequiredService<GetPaintByIdQuery>().Execute(paintModelCurrentBiding.Id);

            //show a message box to confirm if user wants to use the paint
            DialogResult dialogResult = MessageBox.Show("Deseja usar a tinta selecionada?\n" +
                "A tinta mudará o status para \"EM USO\"", "Confirmar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                //execute UpdatePaintCommand.execute from service provider
                Program.ServiceProvider.GetRequiredService<UpdatePaintToInUseCommand>().Execute(paintModel);
                //invoke formload event
                PaintProjectsForm_Load(sender, e);
            }

        }

        private void buttonPaintToLeftover_Click(object sender, EventArgs e)
        {
            PaintModel paintModelCurrentBiding = new PaintModel();
            PaintModel paintModel = new PaintModel();
            //get selected paint from dataGridViewPaintsAvailableAndInUse
            paintModelCurrentBiding = (PaintModel)dataGridViewPaintsLeftover.CurrentRow.DataBoundItem;

            //execute GetPaintByIdQuery.execute fom service provider
            paintModel = Program.ServiceProvider.GetRequiredService<GetPaintByIdQuery>().Execute(paintModelCurrentBiding.Id);

            //get mainForm from service provider
            MainForm mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();
            //set PaintAddToProjectForm from ServiceProvider
            Views.PaintAddToLeftoverForm paintAddToLeftoverForm = new PaintAddToLeftoverForm(paintModel.Id);
            mainForm.ShowInMdiContainer(paintAddToLeftoverForm);

        }
    }
}
