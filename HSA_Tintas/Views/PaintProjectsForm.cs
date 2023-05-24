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

namespace Controle_Tintas.Views
{
    public partial class PaintProjectsForm : Form
    {
        PaintModel paintModel;
        IEnumerable<PaintModel> paints;
        public PaintProjectsForm()
        {
            InitializeComponent();
        }

        private void buttonShowPaintAddToProjectForm_Click(object sender, EventArgs e)
        {
            //get formMain from ServiceProvider
            Views.MainForm formMain = Program.ServiceProvider.GetRequiredService<MainForm>();
            //het PaintAddToProjectForm from ServiceProvider
            Views.PaintAddToProjectForm formPaintAddToProject = Program.ServiceProvider.GetRequiredService<PaintAddToProjectForm>();
            formMain.ShowInMdiContainer(formPaintAddToProject);
        }

        private void PaintProjectsForm_Load(object sender, EventArgs e)
        {
            //start and reseted form status
            comboBoxStatusFilter.Text = "DISPONIVEL";
            textBoxCodeFilter.Text = "";
            textBoxProjectFilter.Text = "";
            textBoxDescriptionFilter.Text = "";

            paintModel = new PaintModel();
            //paint GetAllPaintsAvailableAndInUseQuery to get all paints available and in use from database
            paints = Program.ServiceProvider.GetRequiredService<GetPaintsAvailableAndInUseQuery>().Execute();

            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void PopulateDataGridViewPaintsAvailableAndInUse(IEnumerable<PaintModel> paints)
        {
            IEnumerable<PaintModel> paintsToDataGridView;
            //clear dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Rows.Clear();
            //clear columns from dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Clear();
            //sort paints by ExpirationDate
            paintsToDataGridView = paints.OrderBy(p => p.ExpirationDate);
            BindingList<PaintModel> bindingPaints = new BindingList<PaintModel>(paintsToDataGridView.ToList());
            dataGridViewPaintsAvailableAndInUse.AutoGenerateColumns = false;
            dataGridViewPaintsAvailableAndInUse.DataSource = bindingPaints;
            //add column PaintModel.Code to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Code",
                HeaderText = paintModel.GetType().GetProperty("Code").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelCode",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.Project to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Project",
                HeaderText = paintModel.GetType().GetProperty("Project").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelProject",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.Description to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Description",
                HeaderText = paintModel.GetType().GetProperty("Description").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelDescription",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.CanQty to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CanQty",
                HeaderText = paintModel.GetType().GetProperty("CanQty").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelCanQty",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.Liters to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Liters",
                HeaderText = paintModel.GetType().GetProperty("Liters").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelLiters",
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            //add column with total liters multiple CanQty * Liters
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Total Litros",
                Name = "CalculatedTotalLiters",
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            //add column PaintModel.ExpirationDate to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ExpirationDate",
                HeaderText = paintModel.GetType().GetProperty("ExpirationDate").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelExpirationDate",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column PaintModel.Status to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Status",
                HeaderText = paintModel.GetType().GetProperty("Status").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelStatus",
                SortMode = DataGridViewColumnSortMode.Automatic
            });

        }

        private void dataGridViewPaintsAvailableAndInUse_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //foreach row in dataGridViewPaintsAvailableAndInUse to set column TotalLiter value to CanQty * Liters
            foreach (DataGridViewRow row in dataGridViewPaintsAvailableAndInUse.Rows)
            {
                double CanQty = Convert.ToDouble(row.Cells["PaintModelCanQty"].Value);
                double Liters = Convert.ToDouble(row.Cells["PaintModelLiters"].Value);
                double TotalLiters = CanQty * Liters;
                row.Cells["CalculatedTotalLiters"].Value = TotalLiters;
            }

            //update dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Update();
            //refresh dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Refresh();
        }

        private void buttonClearFilters_Click(object sender, EventArgs e)
        {
            //invoke formload event
            PaintProjectsForm_Load(sender, e);
        }
    }
}
