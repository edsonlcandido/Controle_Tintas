using Controle_Tintas.Domain.Models;
using Microsoft.Extensions.DependencyInjection;
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

namespace Controle_Tintas.Views
{
    public partial class UserForm : Form
    {
        private Domain.Models.UserModel user;
        internal List<UserForm> users = new List<UserForm>();
        public UserForm()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            //get user from ServiceProvider
            user = Program.ServiceProvider.GetRequiredService<Domain.Models.UserModel>();
            //use Model.User data anotation description to set labelUserName text
            labelUserName.Text = user.GetType().GetProperty("Name").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            //use GetAllUsersQuery to get all users from database
            var users = Program.ServiceProvider.GetRequiredService<Domain.Queries.GetAllUsersQuery>();
            //loop through users and add to dataGridViewUsers
            foreach (UserModel user in users.Execute())
            {
                dataGridViewUsers.Rows.Add(user.Id, user.Name, user.IsAdmin);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        //clear form and set user to null
        private void ClearForm()
        {
            user = Program.ServiceProvider.GetRequiredService<Domain.Models.UserModel>();
            user.Name = "";
            user.IsAdmin = false;
            textBoxUserName.Text = user.Name;
            checkBoxUserIsAdmin.Checked = user.IsAdmin;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            user.Name = textBoxUserName.Text;
            user.IsAdmin = checkBoxUserIsAdmin.Checked;
            try
            {
                if (textBoxUserName.Text == string.Empty)
                {
                    throw new Exception("Campos obrigatorios não preenchidos");
                }
                else
                {
                    Infrastructure.Data.Repositories.UserRepository.Add(user);
                    MessageBox.Show("Usuario adicionado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }
    }
}
