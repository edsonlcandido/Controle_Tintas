namespace Controle_Tintas
{
    partial class FormMain
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 55);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(6);
            flowLayoutPanel1.Size = new Size(199, 674);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(9, 9);
            button1.Name = "button1";
            button1.Size = new Size(176, 35);
            button1.TabIndex = 0;
            button1.Text = "Tintas para projetos";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(9, 50);
            button2.Name = "button2";
            button2.Size = new Size(176, 35);
            button2.TabIndex = 1;
            button2.Text = "Sobras de tintas";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Location = new Point(9, 91);
            button3.Name = "button3";
            button3.Size = new Size(176, 35);
            button3.TabIndex = 2;
            button3.Text = "Gerenciar usuarios";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(9, 132);
            button4.Name = "button4";
            button4.Size = new Size(176, 35);
            button4.TabIndex = 3;
            button4.Text = "Resumo Tintas";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            Name = "FormMain";
            Text = "{FormMainTitle}";
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}