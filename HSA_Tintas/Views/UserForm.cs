using Controle_Tintas.Data.Repositories;
using Controle_Tintas.Domain.Commands;
using Controle_Tintas.Domain.Models;
using Controle_Tintas.Domain.Queries;
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
            //clear columns from dataGridViewUsers
            dataGridViewUsers.Columns.Clear();
            //use GetAllUsersQuery to get all users from database
            IEnumerable<UserModel> users = Program.ServiceProvider.GetRequiredService<GetAllUsersQuery>().Execute();
            //sort users by name
            users = users.OrderBy(u => u.Name);
            BindingList<UserModel> bindingUsers = new BindingList<UserModel>(users.ToList());//;
            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.DataSource = bindingUsers;
            //add column UserMode.Name to dataGridViewUsers
            dataGridViewUsers.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = user.GetType().GetProperty("Name").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "UserModelName",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add column UserMode.IsAdmin to dataGridViewUsers
            dataGridViewUsers.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "IsAdmin",
                HeaderText = user.GetType().GetProperty("IsAdmin").GetCustomAttribute<DisplayNameAttribute>().DisplayName,
                Name = "UserModelIsAdmin",
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            //add a column with a button to edit user
            dataGridViewUsers.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "Editar",
                Name = "Edit",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            });
            //add a column with a button to delete user
            dataGridViewUsers.Columns.Add(new DataGridViewButtonColumn()
            {
                HeaderText = "Excluir",
                Name = "Delete",
                Text = "Excluir",
                UseColumnTextForButtonValue = true
            });
            //add users to dataGridViewUsers
            //foreach (UserModel user in users)
            //{
            //    dataGridViewUsers.Rows.Add(user.Name, user.IsAdmin, "Editar", "Excluir");
            //}
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
                    if (user.Id == 0)
                    {

                        user.Name = textBoxUserName.Text;
                        user.IsAdmin = checkBoxUserIsAdmin.Checked;
                        //user CreateUserCommand to add user to database
                        Program.ServiceProvider.GetRequiredService<CreateUserCommand>().Execute(user).Wait();
                        MessageBox.Show("Usuario adicionado com sucesso!");
                        ClearForm();
                        PopulateDataGridViewUsers();

                    }
                    else
                    {
                        user.Name = textBoxUserName.Text;
                        user.IsAdmin = checkBoxUserIsAdmin.Checked;
                        //user UpdateUserCommand to update user in database
                        Program.ServiceProvider.GetRequiredService<UpdateUserCommand>().Execute(user);
                        MessageBox.Show("Usuario atualizado com sucesso!");
                        ClearForm();
                        PopulateDataGridViewUsers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verify if the button clicked is the edit button
            if (dataGridViewUsers.Columns[e.ColumnIndex].Name == "Edit")
            {
                //set user to row clicked                
                UserModel userModel = (UserModel)dataGridViewUsers.Rows[e.RowIndex].DataBoundItem;
                int Id = userModel.Id;
                //get user from database
                user = Program.ServiceProvider.GetRequiredService<GetUserByIdQuery>().Execute(Id);
                //set textBoxUserName text
                textBoxUserName.Text = user.Name;
                //set checkBoxUserIsAdmin checked
                checkBoxUserIsAdmin.Checked = user.IsAdmin;
            }
        }
    }
}
