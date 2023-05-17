using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.Sqlite;

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
        //method to add user in database using dapper ORM and SQLite database in the same folder called database.db
        public static async Task Add(Domain.Models.UserModel user)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                //insert user in database
                string sql = "INSERT INTO User (Name, IsAdmin) VALUES (@Name, @IsAdmin)";
                await connection.ExecuteAsync(sql, user);
            }
        }

        //method to get all users from database using dapper ORM and SQLite database in the same folder called database.db
        public static async Task<IEnumerable<Domain.Models.UserModel>> GetAll()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                //get all users from database
                string sql = "SELECT * FROM User";
                var users = await connection.QueryAsync<Domain.Models.UserModel>(sql);
                return users;
            }
        }
    }
}
