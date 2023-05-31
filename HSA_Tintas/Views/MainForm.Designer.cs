namespace Controle_Tintas.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanelMain = new FlowLayoutPanel();
            buttonShowPaintToProjectForm = new Button();
            buttonShowPaintLeftoverForm = new Button();
            buttonShowUserForm = new Button();
            buttonReportForm = new Button();
            panel1.SuspendLayout();
            flowLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 55);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-1, 2);
            label1.Name = "label1";
            label1.Size = new Size(316, 50);
            label1.TabIndex = 0;
            label1.Text = "Controle de tintas";
            // 
            // flowLayoutPanelMain
            // 
            flowLayoutPanelMain.Controls.Add(buttonShowPaintToProjectForm);
            flowLayoutPanelMain.Controls.Add(buttonShowPaintLeftoverForm);
            flowLayoutPanelMain.Controls.Add(buttonShowUserForm);
            flowLayoutPanelMain.Controls.Add(buttonReportForm);
            flowLayoutPanelMain.Dock = DockStyle.Left;
            flowLayoutPanelMain.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelMain.Location = new Point(0, 55);
            flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            flowLayoutPanelMain.Padding = new Padding(6);
            flowLayoutPanelMain.Size = new Size(199, 674);
            flowLayoutPanelMain.TabIndex = 2;
            // 
            // buttonShowPaintToProjectForm
            // 
            buttonShowPaintToProjectForm.Location = new Point(9, 9);
            buttonShowPaintToProjectForm.Name = "buttonShowPaintToProjectForm";
            buttonShowPaintToProjectForm.Size = new Size(176, 35);
            buttonShowPaintToProjectForm.TabIndex = 0;
            buttonShowPaintToProjectForm.Text = "Tintas para projetos";
            buttonShowPaintToProjectForm.UseVisualStyleBackColor = false;
            buttonShowPaintToProjectForm.Click += buttonShowPaintToProjectForm_Click;
            // 
            // buttonShowPaintLeftoverForm
            // 
            buttonShowPaintLeftoverForm.Location = new Point(9, 50);
            buttonShowPaintLeftoverForm.Name = "buttonShowPaintLeftoverForm";
            buttonShowPaintLeftoverForm.Size = new Size(176, 35);
            buttonShowPaintLeftoverForm.TabIndex = 1;
            buttonShowPaintLeftoverForm.Text = "Sobras de tintas";
            buttonShowPaintLeftoverForm.UseVisualStyleBackColor = false;
            buttonShowPaintLeftoverForm.Click += buttonShowPaintLeftoverForm_Click;
            // 
            // buttonShowUserForm
            // 
            buttonShowUserForm.Location = new Point(9, 91);
            buttonShowUserForm.Name = "buttonShowUserForm";
            buttonShowUserForm.Size = new Size(176, 35);
            buttonShowUserForm.TabIndex = 2;
            buttonShowUserForm.Text = "Gerenciar usuarios";
            buttonShowUserForm.UseVisualStyleBackColor = false;
            buttonShowUserForm.Click += buttonShowUserForm_Click;
            // 
            // buttonReportForm
            // 
            buttonReportForm.Location = new Point(9, 132);
            buttonReportForm.Name = "buttonReportForm";
            buttonReportForm.Size = new Size(176, 35);
            buttonReportForm.TabIndex = 3;
            buttonReportForm.Text = "Resumo Tintas";
            buttonReportForm.UseVisualStyleBackColor = false;
            buttonReportForm.Click += buttonReportForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(flowLayoutPanelMain);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "{FormMainTitle}";
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonShowPaintToProjectForm;
        private Button buttonShowPaintLeftoverForm;
        private Button buttonShowUserForm;
        private Button buttonReportForm;
        internal FlowLayoutPanel flowLayoutPanelMain;
    }
}