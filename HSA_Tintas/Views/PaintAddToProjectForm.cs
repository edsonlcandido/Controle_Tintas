using Controle_Tintas.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Tintas.Views
{
    public partial class PaintAddToProjectForm : Form
    {
        PaintModel paintModel;
        public PaintAddToProjectForm()
        {
            InitializeComponent();
        }

        private void PaintAddToProjectForm_Load(object sender, EventArgs e)
        {
            paintModel = new PaintModel();
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
            //get data anotation from PaintModel.ExpirationDate to labelExpirationDateDisplayName text
            labelExpirationDateDisplayName.Text = paintModel.GetType().GetProperty("ExpirationDate").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Status to labelStatusDisplayName text
            labelStatusDisplayName.Text = paintModel.GetType().GetProperty("Status").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //get data anotation from PaintModel.Obs to labelObsDisplayName text
            labelObsDisplayName.Text = paintModel.GetType().GetProperty("Obs").GetCustomAttribute<DisplayNameAttribute>().DisplayName;

        }
    }
}
