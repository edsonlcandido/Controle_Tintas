using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_Tintas.Domain.Models;
using Dapper;
using System.Data.SQLite;   

namespace Controle_Tintas.Data.Repositories
{
    //class to access database using Dapper ORM and SQLite database
    //create a method to get all users from database
    //create a method to get user by id from database
    //create a method to insert user in database
    //create a method to update user in database
    //create a method to delete user in database

    internal static class UserRepository
    {
        private static string _connectionString
        {
            get
            {
                //get connection string from app.config
                string connectionString = Properties.Settings.Default.ConnectionString;
                return connectionString;
            }
        }
        //method to add user in database using dapper ORM and SQLite database
        public static async Task Add(Domain.Models.UserModel user)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //insert user in database
                string sql = "INSERT INTO User (Name, IsAdmin) VALUES (@Name, @IsAdmin)";
                await connection.ExecuteAsync(sql, user);
            }
        }

        //method to get all users from database using dapper ORM and SQLite database
        public static async Task<IEnumerable<Domain.Models.UserModel>> GetAll()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //get all users from database
                string sql = "SELECT * FROM User";
                var users = await connection.QueryAsync<Domain.Models.UserModel>(sql);
                return users;
            }
        }

        internal static Task Delete(int id)
        {
            //delete user from database using dapper ORM and SQLite database
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //delete user from database
                string sql = "DELETE FROM User WHERE Id = @Id";
                return connection.ExecuteAsync(sql, new { Id = id });
            }
        }

        internal static async Task<UserModel> GetById(int id)
        {
           //get user by id from database using dapper ORM and SQLite database
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //get user by id from database
                string sql = "SELECT * FROM User WHERE Id = @Id";
                var user = await connection.QueryFirstOrDefaultAsync<Domain.Models.UserModel>(sql, new { Id = id });
                return user;
            }
        }

        internal static async Task<UserModel> GetByName(string name)
        {
           //get user by name from database using dapper ORM and SQLite database
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //get user by name from database
                string sql = "SELECT * FROM User WHERE Name = @Name";
                var user = await connection.QueryFirstOrDefaultAsync<Domain.Models.UserModel>(sql, new { Name = name });
                return user;
            }
        }

        internal static async Task Update(UserModel user)
        {
            //update user in database using dapper ORM and SQLite database
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //update user in database
                string sql = "UPDATE User SET Name = @Name, IsAdmin = @IsAdmin WHERE Id = @Id";
                await connection.ExecuteAsync(sql, user);
            }
        }
    }
}
