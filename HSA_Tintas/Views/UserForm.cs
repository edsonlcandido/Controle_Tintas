using Controle_Tintas.Data.Repositories;
using Controle_Tintas.Domain.Commands;
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
        private UserModel user;
        internal List<UserForm> users = new List<UserForm>();
        public UserForm()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            //get user from ServiceProvider
            user = Program.ServiceProvider.GetRequiredService<UserModel>();
            //use Model.User data anotation description to set labelUserName text
            labelUserName.Text = user.GetType().GetProperty("Name").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            PopulateDataGridViewUsers();
        }

        //populate dataGridViewUsers with users from database
        private void PopulateDataGridViewUsers()
        {
            //clear dataGridViewUsers
            dataGridViewUsers.Rows.Clear();
            //use GetAllUsersQuery to get all users from database
            var users = Program.ServiceProvider.GetRequiredService<Domain.Queries.GetAllUsersQuery>().Execute();
            //loop through users and add to dataGridViewUsers
            foreach (UserModel user in users)
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
            user = Program.ServiceProvider.GetRequiredService<UserModel>();
            user.Name = "";
            user.IsAdmin = false;
            textBoxUserName.Text = user.Name;
            checkBoxUserIsAdmin.Checked = user.IsAdmin;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxUserName.Text == string.Empty)
                {
                    throw new Exception("Campos obrigatorios não preenchidos");
                }
                else
                {
                    user.Name = textBoxUserName.Text;
                    user.IsAdmin = checkBoxUserIsAdmin.Checked;
                    //user CreateUserCommand to add user to database
                    Program.ServiceProvider.GetRequiredService<CreateUserCommand>().Execute(user).Wait();
                    MessageBox.Show("Usuario adicionado com sucesso!");
                    ClearForm();
                    PopulateDataGridViewUsers();
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
