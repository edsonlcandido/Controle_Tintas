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

namespace Controle_Tintas.Views
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            //get paint by GetPainstByStatusQuery
            var paintsDisponivel = new GetPaintsByStatusQuery().Execute("DISPONIVEL");
            //get paint by GetPainstByStatusQuery "EM USO"
            var paintsEmUso = new GetPaintsByStatusQuery().Execute("EM USO");
            //get paint by GetPainstByStatusQuery "SOBRA"
            var paintsSobra = new GetPaintsByStatusQuery().Execute("SOBRA");

            //aggregate paints sum PaintModel.CanQty
            var totalLatasDisponivel = paintsDisponivel.Sum(x => x.CanQty);
            var totalLatasEmUso = paintsEmUso.Sum(x => x.CanQty);
            var totalLatasSobra = paintsSobra.Sum(x => x.CanQty);

            //aggregate paints sum PaintModel.CanQty * PaintModel.Liters
            var totalLitrosDisponivel = paintsDisponivel.Sum(x => x.CanQty * x.Liters);
            var totalLitrosEmUso = paintsEmUso.Sum(x => x.CanQty * x.Liters);
            var totalLitrosSobra = paintsSobra.Sum(x => x.CanQty * x.Liters);

            //set labels can qty tostring integer format
            labelTotalLatasDisponivel.Text = labelTotalLatasDisponivel.Text.Replace("{Disponivel.latas}", totalLatasDisponivel.ToString("N0"));
            labelTotalLatasEmUso.Text = labelTotalLatasEmUso.Text.Replace("{EmUso.latas}", totalLatasEmUso.ToString("N0"));
            labelTotalLatasSobra.Text = labelTotalLatasSobra.Text.Replace("{Sobra.latas}", totalLatasSobra.ToString("N0"));

            //set labels liters tostring double one digit format
            labelTotalLitrosDisponivel.Text = labelTotalLitrosDisponivel.Text.Replace("{Disponivel.litros}", totalLitrosDisponivel.ToString("N1"));
            labelTotalLitrosEmUso.Text = labelTotalLitrosEmUso.Text.Replace("{EmUso.litros}", totalLitrosEmUso.ToString("N1"));
            labelTotalLitrosSobra.Text = labelTotalLitrosSobra.Text.Replace("{Sobra.litros}", totalLitrosSobra.ToString("N1"));


        }
    }
}
