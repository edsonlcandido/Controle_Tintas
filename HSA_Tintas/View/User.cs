using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Tintas.View
{
    public partial class User : Form
    {
        private Model.User user;
        internal List<User> users = new List<User>();
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            user = new Model.User();
            //use Model.User data anotation description to set labelUserName text
            labelUserName.Text = user.GetType().GetProperty("Name").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            user = new Model.User();
            user.Name = "";
            user.IsAdmin = false;
            textBoxUserName.Text = user.Name;
            checkBoxUserIsAdmin.Checked = user.IsAdmin;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            user.Name = textBoxUserName.Text;
            user.IsAdmin = checkBoxUserIsAdmin.Checked;
            Repository.User.Add(user);
            MessageBox.Show("Usuario adicionado com sucesso!");
        }
    }
}
