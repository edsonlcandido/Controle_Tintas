namespace Controle_Tintas.Views
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelUserName = new Label();
            labelTotalLatasDisponivel = new Label();
            labelTotalLitrosDisponivel = new Label();
            label6 = new Label();
            label2 = new Label();
            labelTotalLatasEmUso = new Label();
            labelTotalLitrosEmUso = new Label();
            label9 = new Label();
            label3 = new Label();
            labelTotalLatasSobra = new Label();
            labelTotalLitrosSobra = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 37);
            label1.TabIndex = 2;
            label1.Text = "Resumo tintas";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelUserName);
            flowLayoutPanel1.Controls.Add(labelTotalLatasDisponivel);
            flowLayoutPanel1.Controls.Add(labelTotalLitrosDisponivel);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(labelTotalLatasEmUso);
            flowLayoutPanel1.Controls.Add(labelTotalLitrosEmUso);
            flowLayoutPanel1.Controls.Add(label9);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(labelTotalLatasSobra);
            flowLayoutPanel1.Controls.Add(labelTotalLitrosSobra);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 49);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(272, 254);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.Location = new Point(3, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(140, 21);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "Tintas disponivel";
            // 
            // labelTotalLatasDisponivel
            // 
            labelTotalLatasDisponivel.AutoSize = true;
            labelTotalLatasDisponivel.Location = new Point(3, 21);
            labelTotalLatasDisponivel.Name = "labelTotalLatasDisponivel";
            labelTotalLatasDisponivel.Size = new Size(231, 17);
            labelTotalLatasDisponivel.TabIndex = 4;
            labelTotalLatasDisponivel.Text = "Quantidade de latas: {Disponivel.latas}";
            // 
            // labelTotalLitrosDisponivel
            // 
            labelTotalLitrosDisponivel.AutoSize = true;
            labelTotalLitrosDisponivel.Location = new Point(3, 38);
            labelTotalLitrosDisponivel.Name = "labelTotalLitrosDisponivel";
            labelTotalLitrosDisponivel.Size = new Size(265, 17);
            labelTotalLitrosDisponivel.TabIndex = 5;
            labelTotalLitrosDisponivel.Text = "Quantidade total de litros: {Disponivel.litros}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 55);
            label6.Name = "label6";
            label6.Size = new Size(12, 17);
            label6.TabIndex = 6;
            label6.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 1;
            label2.Text = "Tintas em uso";
            // 
            // labelTotalLatasEmUso
            // 
            labelTotalLatasEmUso.AutoSize = true;
            labelTotalLatasEmUso.Location = new Point(3, 93);
            labelTotalLatasEmUso.Name = "labelTotalLatasEmUso";
            labelTotalLatasEmUso.Size = new Size(212, 17);
            labelTotalLatasEmUso.TabIndex = 5;
            labelTotalLatasEmUso.Text = "Quantidade de latas: {EmUso.latas}";
            // 
            // labelTotalLitrosEmUso
            // 
            labelTotalLitrosEmUso.AutoSize = true;
            labelTotalLitrosEmUso.Location = new Point(3, 110);
            labelTotalLitrosEmUso.Name = "labelTotalLitrosEmUso";
            labelTotalLitrosEmUso.Size = new Size(246, 17);
            labelTotalLitrosEmUso.TabIndex = 10;
            labelTotalLitrosEmUso.Text = "Quantidade total de litros: {EmUso.litros}";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 127);
            label9.Name = "label9";
            label9.Size = new Size(12, 17);
            label9.TabIndex = 9;
            label9.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 144);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 2;
            label3.Text = "Sobra de tintas";
            // 
            // labelTotalLatasSobra
            // 
            labelTotalLatasSobra.AutoSize = true;
            labelTotalLatasSobra.Location = new Point(3, 165);
            labelTotalLatasSobra.Name = "labelTotalLatasSobra";
            labelTotalLatasSobra.Size = new Size(206, 17);
            labelTotalLatasSobra.TabIndex = 11;
            labelTotalLatasSobra.Text = "Quantidade de latas: {Sobra.latas}";
            // 
            // labelTotalLitrosSobra
            // 
            labelTotalLitrosSobra.AutoSize = true;
            labelTotalLitrosSobra.Location = new Point(3, 182);
            labelTotalLitrosSobra.Name = "labelTotalLitrosSobra";
            labelTotalLitrosSobra.Size = new Size(240, 17);
            labelTotalLitrosSobra.TabIndex = 12;
            labelTotalLitrosSobra.Text = "Quantidade total de litros: {Sobra.litros}";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelUserName;
        private Label label2;
        private Label label3;
        private Label labelTotalLatasDisponivel;
        private Label labelTotalLitrosDisponivel;
        private Label label6;
        private Label label9;
        private Label labelTotalLatasEmUso;
        private Label labelTotalLitrosEmUso;
        private Label labelTotalLatasSobra;
        private Label labelTotalLitrosSobra;
    }
}