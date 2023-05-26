namespace Controle_Tintas.Views
{
    partial class UserForm
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
            textBoxUserName = new TextBox();
            checkBoxUserIsAdmin = new CheckBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonClear = new Button();
            dataGridViewUsers = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 4);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 1;
            label1.Text = "Gerenciar usuários";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelUserName);
            flowLayoutPanel1.Controls.Add(textBoxUserName);
            flowLayoutPanel1.Controls.Add(checkBoxUserIsAdmin);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(7, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(235, 142);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(3, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(206, 17);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "{Model.User.Name.Display Name}";
            // 
            // textBoxUserName
            // 
            textBoxUserName.CharacterCasing = CharacterCasing.Upper;
            textBoxUserName.Location = new Point(3, 20);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(221, 25);
            textBoxUserName.TabIndex = 1;
            // 
            // checkBoxUserIsAdmin
            // 
            checkBoxUserIsAdmin.AutoSize = true;
            checkBoxUserIsAdmin.Location = new Point(3, 51);
            checkBoxUserIsAdmin.Name = "checkBoxUserIsAdmin";
            checkBoxUserIsAdmin.Size = new Size(110, 21);
            checkBoxUserIsAdmin.TabIndex = 2;
            checkBoxUserIsAdmin.Text = "Administrador";
            checkBoxUserIsAdmin.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonSave);
            flowLayoutPanel2.Controls.Add(buttonClear);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(3, 78);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(4);
            flowLayoutPanel2.Size = new Size(232, 48);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(146, 7);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 34);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(65, 7);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 34);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Limpar";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(249, 44);
            dataGridViewUsers.Margin = new Padding(4);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowTemplate.Height = 25;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(543, 548);
            dataGridViewUsers.TabIndex = 3;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(dataGridViewUsers);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Padding = new Padding(4);
            Text = "Usuario";
            Load += User_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelUserName;
        private TextBox textBoxUserName;
        private CheckBox checkBoxUserIsAdmin;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonSave;
        private Button buttonClear;
        private DataGridView dataGridViewUsers;
    }
}