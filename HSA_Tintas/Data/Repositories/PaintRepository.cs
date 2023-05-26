using Controle_Tintas.Domain.Models;
using Dapper;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Tintas.Data.Repositories
{
    internal class PaintRepository
    {
        //class to access database using Dapper ORM and SQLite database
        //create a method to get all paints from database
        //create a method to get paint by id from database
        //create a method to insert paint in database
        //create a method to update paint in database
        //create a method to delete paint in database
        //paint model
        //          Id INTEGER PRIMARY KEY AUTOINCREMENT
        //                       UNIQUE,
        //          Code           TEXT,
        //          Project TEXT,
        //          Description    TEXT,
        //          CanQty DOUBLE,
        //          Liters         DOUBLE,
        //          ExpirationDate DATE,
        //          Status         TEXT,
        //          Obs TEXT

        private static string _connectionString
        {
            get
            {
                //get connection string from app.config
                string connectionString = Properties.Settings.Default.ConnectionString;
                return connectionString;
            }
        }   

        //method to get all paints from database using dapper ORM and SQLite database
        public static async Task<IEnumerable<PaintModel>> GetAll()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //get all paints from database
                string sql = "SELECT * FROM Paint";
                var paints = await connection.QueryAsync<PaintModel>(sql);
                return paints;
            }
        }
        //method to get paint by id from database using dapper ORM and SQLite database
        public static async Task<Domain.Models.PaintModel> GetById(int id)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //get paint by id from database
                string sql = "SELECT * FROM Paint WHERE Id = @Id";
                var paint = await connection.QueryFirstOrDefaultAsync<PaintModel>(sql, new { Id = id });
                return paint;
            }
        }
        //method to add paint in database using dapper ORM and SQLite database 
        public static async Task Add(PaintModel paint)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //insert paint in database
                //convert ExpirationDate to string format YYYY-MM-DD before insert in database
                //string formatedDate = paint.ExpirationDate.ToString("yyyy-MM-dd");
                string sql = $"INSERT INTO Paint (Code, Project, Description, CanQty, Liters, ExpirationDate, Status, Obs) VALUES (@Code, @Project, @Description, @CanQty, @Liters, @ExpirationDate, @Status, @Obs)";
                await connection.ExecuteAsync(sql, paint);
            }
        }
        //method to update paint in database using dapper ORM and SQLite database
        public static async Task Update(PaintModel paint)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //update paint in database
                string sql = "UPDATE Paint SET Code = @Code, Project = @Project, Description = @Description, CanQty = @CanQty, Liters = @Liters, ExpirationDate = @ExpirationDate, Status = @Status, Obs = @Obs WHERE Id = @Id";
                await connection.ExecuteAsync(sql, paint);
            }
        }
        //method to delete paint in database using dapper ORM and SQLite database
        public static async Task Delete(int id)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                //delete paint from database
                string sql = "DELETE FROM Paint WHERE Id = @Id";
                await connection.ExecuteAsync(sql, new { Id = id });
            }
        }
    }



}
