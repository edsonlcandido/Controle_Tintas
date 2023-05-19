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
            labelUserName = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox6 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
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
            flowLayoutPanel1.Controls.Add(labelUserName);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBox3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(textBox4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(textBox5);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(textBox6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 49);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(479, 474);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(3, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(199, 17);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "{Model.Paint.Code.DisplayName}";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 25);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(208, 17);
            label2.TabIndex = 2;
            label2.Text = "{Model.Paint.Project.DisplayName}";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 25);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(234, 17);
            label3.TabIndex = 4;
            label3.Text = "{Model.Paint.Description.DisplayName}";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(468, 25);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 144);
            label4.Name = "label4";
            label4.Size = new Size(210, 17);
            label4.TabIndex = 6;
            label4.Text = "{Model.Paint.CanQty.DisplayName}";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(78, 25);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 192);
            label5.Name = "label5";
            label5.Size = new Size(199, 17);
            label5.TabIndex = 8;
            label5.Text = "{Model.Paint.Liters.DisplayName}";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(78, 25);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 240);
            label6.Name = "label6";
            label6.Size = new Size(253, 17);
            label6.TabIndex = 10;
            label6.Text = "{Model.Paint.ExpirationDate.DisplayName}";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 288);
            label7.Name = "label7";
            label7.Size = new Size(192, 17);
            label7.TabIndex = 13;
            label7.Text = "{Model.Paint.Obs.DisplayName}";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(3, 308);
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
            flowLayoutPanel2.Location = new Point(3, 412);
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelUserName;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private TextBox textBox6;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Button button2;
    }
}