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
            paintsToDataGridView = paints;
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
            //add column PaintModel.InsertionDate to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "InsertionDate",
                HeaderText = paintModel.GetType().GetProperty("InsertionDate").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelInsertionDate",
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

            //add column PaintModel.Obs to dataGridViewPaintsAvailableAndInUse
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Obs",
                HeaderText = paintModel.GetType().GetProperty("Obs").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "PaintModelObs",
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            //add collumn to dataGridViewPaintsAvailableAndInUse to show button to edit paint
            dataGridViewPaintsAvailableAndInUse.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "",
                Name = "EditPaint",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            });
            //invoke dataGridViewPaintsAvailableAndInUse_DataBindingComplete event
            dataGridViewPaintsAvailableAndInUse_DataBindingComplete(this, new DataGridViewBindingCompleteEventArgs(ListChangedType.Reset));

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

        private void buttonCodeFilter_Click(object sender, EventArgs e)
        {
            //filter paints by Code to a new paints and update dataGridViewPaintsAvailableAndInUse
            var paints = this.paints.Where(p => p.Code.Contains(textBoxCodeFilter.Text));
            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void buttonProjectFilter_Click(object sender, EventArgs e)
        {
            //filter paints by Project to a new paints and update dataGridViewPaintsAvailableAndInUse
            var paints = this.paints.Where(p => p.Project.Contains(textBoxProjectFilter.Text));
            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void buttonDescriptionFilter_Click(object sender, EventArgs e)
        {
            //filter paints by Description to a new paints and update dataGridViewPaintsAvailableAndInUse
            var paints = this.paints.Where(p => p.Description.Contains(textBoxDescriptionFilter.Text));
            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void comboBoxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filter paints by Status to a new paints and update dataGridViewPaintsAvailableAndInUse
            var paints = this.paints.Where(p => p.Status == comboBoxStatusFilter.Text);
            PopulateDataGridViewPaintsAvailableAndInUse(paints);
        }

        private void buttonUsePaint_Click(object sender, EventArgs e)
        {
            PaintModel paintModelCurrentBiding = new PaintModel();
            PaintModel paintModel = new PaintModel();
            //get selected paint from dataGridViewPaintsAvailableAndInUse
            paintModelCurrentBiding = (PaintModel)dataGridViewPaintsAvailableAndInUse.CurrentRow.DataBoundItem;

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
            paintModelCurrentBiding = (PaintModel)dataGridViewPaintsAvailableAndInUse.CurrentRow.DataBoundItem;

            //execute GetPaintByIdQuery.execute fom service provider
            paintModel = Program.ServiceProvider.GetRequiredService<GetPaintByIdQuery>().Execute(paintModelCurrentBiding.Id);

            //get mainForm from service provider
            MainForm mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();
            //set PaintAddToProjectForm from ServiceProvider
            Views.PaintAddToLeftoverForm paintAddToLeftoverForm = new PaintAddToLeftoverForm(paintModel.Id);
            mainForm.ShowInMdiContainer(paintAddToLeftoverForm);

        }

        private void dataGridViewPaintsAvailableAndInUse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verify if column EditPaint was clicked
            if (dataGridViewPaintsAvailableAndInUse.Columns[e.ColumnIndex].Name == "EditPaint")
            {
                //get selected paint from dataGridViewPaintsAvailableAndInUse
                PaintModel paintModelCurrentBiding = (PaintModel)dataGridViewPaintsAvailableAndInUse.CurrentRow.DataBoundItem;
                int id = paintModelCurrentBiding.Id;

                //get mainForm from service provider
                MainForm mainForm = Program.ServiceProvider.GetRequiredService<MainForm>();
                //set PaintAddToProjectForm from ServiceProvider
                Views.PaintEditForm paintAddToProjectForm = new PaintEditForm(id);
                mainForm.ShowInMdiContainer(paintAddToProjectForm);
            }
        }
    }
}
