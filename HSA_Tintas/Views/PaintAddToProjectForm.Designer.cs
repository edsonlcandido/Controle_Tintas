namespace Controle_Tintas.Views
{
    partial class PaintAddToProjectForm
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
            textBox1 = new TextBox();
            labelProjectDisplayName = new Label();
            textBox2 = new TextBox();
            labelDescriptionDisplayName = new Label();
            textBox3 = new TextBox();
            labelCanQtyDisplayName = new Label();
            textBox4 = new TextBox();
            labelLitersDisplayName = new Label();
            textBox5 = new TextBox();
            labelExpirationDateDisplayName = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelObsDisplayName = new Label();
            textBox6 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            labelStatusDisplayName = new Label();
            comboBox1 = new ComboBox();
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
            label1.Size = new Size(336, 37);
            label1.TabIndex = 3;
            label1.Text = "Adiciona tinta para projeto";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelCodeDisplayName);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(labelProjectDisplayName);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(labelDescriptionDisplayName);
            flowLayoutPanel1.Controls.Add(textBox3);
            flowLayoutPanel1.Controls.Add(labelCanQtyDisplayName);
            flowLayoutPanel1.Controls.Add(textBox4);
            flowLayoutPanel1.Controls.Add(labelLitersDisplayName);
            flowLayoutPanel1.Controls.Add(textBox5);
            flowLayoutPanel1.Controls.Add(labelExpirationDateDisplayName);
            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            flowLayoutPanel1.Controls.Add(labelStatusDisplayName);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(labelObsDisplayName);
            flowLayoutPanel1.Controls.Add(textBox6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 49);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(479, 515);
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
            // textBox1
            // 
            textBox1.Location = new Point(3, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 25);
            textBox1.TabIndex = 1;
            // 
            // labelProjectDisplayName
            // 
            labelProjectDisplayName.AutoSize = true;
            labelProjectDisplayName.Location = new Point(3, 48);
            labelProjectDisplayName.Name = "labelProjectDisplayName";
            labelProjectDisplayName.Size = new Size(208, 17);
            labelProjectDisplayName.TabIndex = 2;
            labelProjectDisplayName.Text = "{Model.Paint.Project.DisplayName}";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 25);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(3, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(468, 25);
            textBox3.TabIndex = 5;
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
            // textBox4
            // 
            textBox4.Location = new Point(3, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(78, 25);
            textBox4.TabIndex = 7;
            // 
            // labelLitersDisplayName
            // 
            labelLitersDisplayName.AutoSize = true;
            labelLitersDisplayName.Location = new Point(3, 192);
            labelLitersDisplayName.Name = "labelLitersDisplayName";
            labelLitersDisplayName.Size = new Size(199, 17);
            labelLitersDisplayName.TabIndex = 8;
            labelLitersDisplayName.Text = "{Model.Paint.Liters.DisplayName}";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(78, 25);
            textBox5.TabIndex = 9;
            // 
            // labelExpirationDateDisplayName
            // 
            labelExpirationDateDisplayName.AutoSize = true;
            labelExpirationDateDisplayName.Location = new Point(3, 240);
            labelExpirationDateDisplayName.Name = "labelExpirationDateDisplayName";
            labelExpirationDateDisplayName.Size = new Size(253, 17);
            labelExpirationDateDisplayName.TabIndex = 10;
            labelExpirationDateDisplayName.Text = "{Model.Paint.ExpirationDate.DisplayName}";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Checked = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(3, 260);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 25);
            dateTimePicker1.TabIndex = 12;
            // 
            // labelObsDisplayName
            // 
            labelObsDisplayName.AutoSize = true;
            labelObsDisplayName.Location = new Point(3, 334);
            labelObsDisplayName.Name = "labelObsDisplayName";
            labelObsDisplayName.Size = new Size(192, 17);
            labelObsDisplayName.TabIndex = 13;
            labelObsDisplayName.Text = "{Model.Paint.Obs.DisplayName}";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(3, 354);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ScrollBars = ScrollBars.Vertical;
            textBox6.Size = new Size(468, 98);
            textBox6.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(3, 458);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(4);
            flowLayoutPanel2.Size = new Size(468, 49);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(382, 7);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 0;
            button1.Text = "Adiciona";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(301, 7);
            button2.Name = "button2";
            button2.Size = new Size(75, 34);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // labelStatusDisplayName
            // 
            labelStatusDisplayName.AutoSize = true;
            labelStatusDisplayName.Location = new Point(3, 288);
            labelStatusDisplayName.Name = "labelStatusDisplayName";
            labelStatusDisplayName.Size = new Size(203, 17);
            labelStatusDisplayName.TabIndex = 5;
            labelStatusDisplayName.Text = "{Model.Paint.Status.DisplayName}";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 308);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 25);
            comboBox1.TabIndex = 16;
            // 
            // PaintAddToProjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaintAddToProjectForm";
            Text = "PaintAddToProjectForm";
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
        private TextBox textBox1;
        private Label labelProjectDisplayName;
        private TextBox textBox2;
        private Label labelDescriptionDisplayName;
        private TextBox textBox3;
        private Label labelCanQtyDisplayName;
        private TextBox textBox4;
        private Label labelLitersDisplayName;
        private TextBox textBox5;
        private Label labelExpirationDateDisplayName;
        private DateTimePicker dateTimePicker1;
        private Label labelObsDisplayName;
        private TextBox textBox6;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
        private Label labelStatusDisplayName;
        private ComboBox comboBox1;
    }
}