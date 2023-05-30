namespace Controle_Tintas.Views
{
    partial class PaintLeftoverForm
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
            flowLayoutPanel2 = new FlowLayoutPanel();
            textBoxCodeFilter = new TextBox();
            buttonCodeFilter = new Button();
            label2 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            textBoxProjectFilter = new TextBox();
            buttonProjectFIlter = new Button();
            label3 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            textBoxDescriptionFilter = new TextBox();
            buttonDescriptionFilter = new Button();
            groupBox1 = new GroupBox();
            buttonClearFilters = new Button();
            buttonShowPaintReuseLeftoverForm = new Button();
            buttonDicardPaint = new Button();
            dataGridViewPaintsLeftover = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaintsLeftover).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 2;
            label1.Text = "Sobra de tintas";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelUserName);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(252, 213);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(3, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(118, 17);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "Pesquisar por cód.";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(textBoxCodeFilter);
            flowLayoutPanel2.Controls.Add(buttonCodeFilter);
            flowLayoutPanel2.Location = new Point(3, 20);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(249, 45);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // textBoxCodeFilter
            // 
            textBoxCodeFilter.CharacterCasing = CharacterCasing.Upper;
            textBoxCodeFilter.Location = new Point(3, 3);
            textBoxCodeFilter.Name = "textBoxCodeFilter";
            textBoxCodeFilter.Size = new Size(156, 25);
            textBoxCodeFilter.TabIndex = 0;
            // 
            // buttonCodeFilter
            // 
            buttonCodeFilter.Location = new Point(165, 3);
            buttonCodeFilter.Name = "buttonCodeFilter";
            buttonCodeFilter.Size = new Size(75, 34);
            buttonCodeFilter.TabIndex = 1;
            buttonCodeFilter.Text = "Pesquisar";
            buttonCodeFilter.UseVisualStyleBackColor = true;
            buttonCodeFilter.Click += buttonCodeFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 68);
            label2.Name = "label2";
            label2.Size = new Size(136, 17);
            label2.TabIndex = 2;
            label2.Text = "Pesquisar por projeto";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(textBoxProjectFilter);
            flowLayoutPanel3.Controls.Add(buttonProjectFIlter);
            flowLayoutPanel3.Location = new Point(3, 88);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(249, 45);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // textBoxProjectFilter
            // 
            textBoxProjectFilter.CharacterCasing = CharacterCasing.Upper;
            textBoxProjectFilter.Location = new Point(3, 3);
            textBoxProjectFilter.Name = "textBoxProjectFilter";
            textBoxProjectFilter.Size = new Size(156, 25);
            textBoxProjectFilter.TabIndex = 0;
            // 
            // buttonProjectFIlter
            // 
            buttonProjectFIlter.Location = new Point(165, 3);
            buttonProjectFIlter.Name = "buttonProjectFIlter";
            buttonProjectFIlter.Size = new Size(75, 34);
            buttonProjectFIlter.TabIndex = 1;
            buttonProjectFIlter.Text = "Pesquisar";
            buttonProjectFIlter.UseVisualStyleBackColor = true;
            buttonProjectFIlter.Click += buttonProjectFilter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 136);
            label3.Name = "label3";
            label3.Size = new Size(149, 17);
            label3.TabIndex = 4;
            label3.Text = "Pesquisar por descrição";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(textBoxDescriptionFilter);
            flowLayoutPanel4.Controls.Add(buttonDescriptionFilter);
            flowLayoutPanel4.Location = new Point(3, 156);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(249, 45);
            flowLayoutPanel4.TabIndex = 5;
            // 
            // textBoxDescriptionFilter
            // 
            textBoxDescriptionFilter.CharacterCasing = CharacterCasing.Upper;
            textBoxDescriptionFilter.Location = new Point(3, 3);
            textBoxDescriptionFilter.Name = "textBoxDescriptionFilter";
            textBoxDescriptionFilter.Size = new Size(156, 25);
            textBoxDescriptionFilter.TabIndex = 0;
            // 
            // buttonDescriptionFilter
            // 
            buttonDescriptionFilter.Location = new Point(165, 3);
            buttonDescriptionFilter.Name = "buttonDescriptionFilter";
            buttonDescriptionFilter.Size = new Size(75, 34);
            buttonDescriptionFilter.TabIndex = 1;
            buttonDescriptionFilter.Text = "Pesquisar";
            buttonDescriptionFilter.UseVisualStyleBackColor = true;
            buttonDescriptionFilter.Click += buttonDescriptionFilter_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonClearFilters);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 288);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // buttonClearFilters
            // 
            buttonClearFilters.Location = new Point(75, 244);
            buttonClearFilters.Name = "buttonClearFilters";
            buttonClearFilters.Size = new Size(93, 34);
            buttonClearFilters.TabIndex = 0;
            buttonClearFilters.Text = "Limpar filtros";
            buttonClearFilters.UseVisualStyleBackColor = true;
            buttonClearFilters.Click += buttonClearFilters_Click;
            // 
            // buttonShowPaintReuseLeftoverForm
            // 
            buttonShowPaintReuseLeftoverForm.Location = new Point(287, 63);
            buttonShowPaintReuseLeftoverForm.Name = "buttonShowPaintReuseLeftoverForm";
            buttonShowPaintReuseLeftoverForm.Size = new Size(187, 34);
            buttonShowPaintReuseLeftoverForm.TabIndex = 5;
            buttonShowPaintReuseLeftoverForm.Text = "Utilizar tinta em novo projeto";
            buttonShowPaintReuseLeftoverForm.UseVisualStyleBackColor = true;
            buttonShowPaintReuseLeftoverForm.Click += buttonShowPaintReuseLeftoverForm_Click;
            // 
            // buttonDicardPaint
            // 
            buttonDicardPaint.Location = new Point(480, 63);
            buttonDicardPaint.Name = "buttonDicardPaint";
            buttonDicardPaint.Size = new Size(187, 34);
            buttonDicardPaint.TabIndex = 6;
            buttonDicardPaint.Text = "Descartar tinta";
            buttonDicardPaint.UseVisualStyleBackColor = true;
            buttonDicardPaint.Click += buttonDicardPaint_Click;
            // 
            // dataGridViewPaintsLeftover
            // 
            dataGridViewPaintsLeftover.AllowUserToAddRows = false;
            dataGridViewPaintsLeftover.AllowUserToDeleteRows = false;
            dataGridViewPaintsLeftover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPaintsLeftover.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPaintsLeftover.Location = new Point(287, 107);
            dataGridViewPaintsLeftover.MultiSelect = false;
            dataGridViewPaintsLeftover.Name = "dataGridViewPaintsLeftover";
            dataGridViewPaintsLeftover.ReadOnly = true;
            dataGridViewPaintsLeftover.RowTemplate.Height = 25;
            dataGridViewPaintsLeftover.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPaintsLeftover.Size = new Size(581, 540);
            dataGridViewPaintsLeftover.TabIndex = 8;
            dataGridViewPaintsLeftover.DataBindingComplete += dataGridViewPaintsLeftover_DataBindingComplete;
            // 
            // PaintLeftoverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 660);
            Controls.Add(dataGridViewPaintsLeftover);
            Controls.Add(buttonDicardPaint);
            Controls.Add(buttonShowPaintReuseLeftoverForm);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaintLeftoverForm";
            Text = "PaintProjectsForm";
            Load += PaintProjectsForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaintsLeftover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelUserName;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBoxCodeFilter;
        private Button buttonCodeFilter;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox textBoxProjectFilter;
        private Button buttonProjectFIlter;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel4;
        private TextBox textBoxDescriptionFilter;
        private Button buttonDescriptionFilter;
        private GroupBox groupBox1;
        private Button buttonClearFilters;
        private Button buttonShowPaintReuseLeftoverForm;
        private Button buttonDicardPaint;
        private DataGridView dataGridViewPaintsLeftover;
    }
}