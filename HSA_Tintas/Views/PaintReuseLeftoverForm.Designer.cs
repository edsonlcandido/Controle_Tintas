namespace Controle_Tintas.Views
{
    partial class PaintReuseLeftoverForm
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
            labelCodeDisplayName = new Label();
            textBoxPaintCode = new TextBox();
            labelProjectDisplayName = new Label();
            textBoxPaintProject = new TextBox();
            labelDescriptionDisplayName = new Label();
            textBoxPaintDescription = new TextBox();
            labelCanQtyDisplayName = new Label();
            textBoxPaintCanQty = new TextBox();
            labelObsDisplayName = new Label();
            textBoxPaintObs = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 3;
            label1.Text = "Reutilizar tinta";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelCodeDisplayName);
            flowLayoutPanel1.Controls.Add(textBoxPaintCode);
            flowLayoutPanel1.Controls.Add(labelProjectDisplayName);
            flowLayoutPanel1.Controls.Add(textBoxPaintProject);
            flowLayoutPanel1.Controls.Add(labelDescriptionDisplayName);
            flowLayoutPanel1.Controls.Add(textBoxPaintDescription);
            flowLayoutPanel1.Controls.Add(labelCanQtyDisplayName);
            flowLayoutPanel1.Controls.Add(textBoxPaintCanQty);
            flowLayoutPanel1.Controls.Add(labelObsDisplayName);
            flowLayoutPanel1.Controls.Add(textBoxPaintObs);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 49);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(479, 381);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // labelCodeDisplayName
            // 
            labelCodeDisplayName.AutoSize = true;
            labelCodeDisplayName.Location = new Point(3, 0);
            labelCodeDisplayName.Name = "labelCodeDisplayName";
            labelCodeDisplayName.Size = new Size(199, 17);
            labelCodeDisplayName.TabIndex = 0;
            labelCodeDisplayName.Text = "{Model.Paint.Code.DisplayName}";
            // 
            // textBoxPaintCode
            // 
            textBoxPaintCode.CharacterCasing = CharacterCasing.Upper;
            textBoxPaintCode.Enabled = false;
            textBoxPaintCode.Location = new Point(3, 20);
            textBoxPaintCode.Name = "textBoxPaintCode";
            textBoxPaintCode.Size = new Size(156, 25);
            textBoxPaintCode.TabIndex = 1;
            // 
            // labelProjectDisplayName
            // 
            labelProjectDisplayName.AutoSize = true;
            labelProjectDisplayName.Location = new Point(3, 48);
            labelProjectDisplayName.Name = "labelProjectDisplayName";
            labelProjectDisplayName.Size = new Size(208, 17);
            labelProjectDisplayName.TabIndex = 5;
            labelProjectDisplayName.Text = "{Model.Paint.Project.DisplayName}";
            // 
            // textBoxPaintProject
            // 
            textBoxPaintProject.CharacterCasing = CharacterCasing.Upper;
            textBoxPaintProject.Location = new Point(3, 68);
            textBoxPaintProject.Name = "textBoxPaintProject";
            textBoxPaintProject.Size = new Size(156, 25);
            textBoxPaintProject.TabIndex = 6;
            // 
            // labelDescriptionDisplayName
            // 
            labelDescriptionDisplayName.AutoSize = true;
            labelDescriptionDisplayName.Location = new Point(3, 96);
            labelDescriptionDisplayName.Name = "labelDescriptionDisplayName";
            labelDescriptionDisplayName.Size = new Size(234, 17);
            labelDescriptionDisplayName.TabIndex = 4;
            labelDescriptionDisplayName.Text = "{Model.Paint.Description.DisplayName}";
            // 
            // textBoxPaintDescription
            // 
            textBoxPaintDescription.CharacterCasing = CharacterCasing.Upper;
            textBoxPaintDescription.Enabled = false;
            textBoxPaintDescription.Location = new Point(3, 116);
            textBoxPaintDescription.Name = "textBoxPaintDescription";
            textBoxPaintDescription.Size = new Size(468, 25);
            textBoxPaintDescription.TabIndex = 5;
            // 
            // labelCanQtyDisplayName
            // 
            labelCanQtyDisplayName.AutoSize = true;
            labelCanQtyDisplayName.Location = new Point(3, 144);
            labelCanQtyDisplayName.Name = "labelCanQtyDisplayName";
            labelCanQtyDisplayName.Size = new Size(210, 17);
            labelCanQtyDisplayName.TabIndex = 6;
            labelCanQtyDisplayName.Text = "{Model.Paint.CanQty.DisplayName}";
            // 
            // textBoxPaintCanQty
            // 
            textBoxPaintCanQty.Location = new Point(3, 164);
            textBoxPaintCanQty.Name = "textBoxPaintCanQty";
            textBoxPaintCanQty.Size = new Size(78, 25);
            textBoxPaintCanQty.TabIndex = 7;
            // 
            // labelObsDisplayName
            // 
            labelObsDisplayName.AutoSize = true;
            labelObsDisplayName.Location = new Point(3, 192);
            labelObsDisplayName.Name = "labelObsDisplayName";
            labelObsDisplayName.Size = new Size(192, 17);
            labelObsDisplayName.TabIndex = 13;
            labelObsDisplayName.Text = "{Model.Paint.Obs.DisplayName}";
            // 
            // textBoxPaintObs
            // 
            textBoxPaintObs.CharacterCasing = CharacterCasing.Upper;
            textBoxPaintObs.Enabled = false;
            textBoxPaintObs.Location = new Point(3, 212);
            textBoxPaintObs.Multiline = true;
            textBoxPaintObs.Name = "textBoxPaintObs";
            textBoxPaintObs.ScrollBars = ScrollBars.Vertical;
            textBoxPaintObs.Size = new Size(468, 98);
            textBoxPaintObs.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonSave);
            flowLayoutPanel2.Controls.Add(buttonCancel);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(3, 316);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(4);
            flowLayoutPanel2.Size = new Size(468, 49);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(382, 7);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 34);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(301, 7);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 34);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // PaintReuseLeftoverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaintReuseLeftoverForm";
            Text = "PaintAddToProjectForm";
            FormClosing += PaintAddToProjectForm_FormClosing;
            FormClosed += PaintAddToProjectForm_FormClosed;
            Load += PaintAddToProjectForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelCodeDisplayName;
        private TextBox textBoxPaintCode;
        private Label labelDescriptionDisplayName;
        private TextBox textBoxPaintDescription;
        private Label labelCanQtyDisplayName;
        private TextBox textBoxPaintCanQty;
        private Label labelObsDisplayName;
        private TextBox textBoxPaintObs;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelProjectDisplayName;
        private TextBox textBoxPaintProject;
    }
}