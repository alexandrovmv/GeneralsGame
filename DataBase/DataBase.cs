using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Data;

namespace DataBase
{
    public class DB
    {
        public DB() { }
        //Создание базы данных
        public void Create_DataBase()
        {
            SQLiteConnection.CreateFile("TestDB.db");
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            sql_con.Open();
            string sql = @"CREATE TABLE Users(
                            Login varchar(20) NOT NULL,
                            Password varchar(40) NOT NULL)";
            SQLiteCommand command = new SQLiteCommand(sql, sql_con);
            command.ExecuteNonQuery();
            sql = @"CREATE TABLE History(
                            Name varchar(20) NOT NULL,
                            Games int NOT NULL,
                            Wins int NOT NULL)";
            command = new SQLiteCommand(sql, sql_con);
            command.ExecuteNonQuery();
            sql_con.Close();
        }
        //Регистрация пользователя
        public void Add_User(string login, string password)
        {
            MD5 md5 = MD5.Create();
            byte[] inputbytes = Encoding.ASCII.GetBytes(password);
            byte[] hashbytes = md5.ComputeHash(inputbytes);
            StringBuilder strBuild = new StringBuilder();
            for (int i = 0; i < hashbytes.Length; i++)
                strBuild.Append(hashbytes[i].ToString("X2"));
            string result = strBuild.ToString();
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            sql_con.Open();
            string sql = $"INSERT INTO Users VALUES ('{login}', '{result}')";
            SQLiteCommand command = new SQLiteCommand(sql, sql_con);
            command.ExecuteNonQuery();
            sql_con.Close();
        }
        //Аутентификация пользователя, в случае совпадения в базе данных возвращает true
        public bool Authorization(string login, string password)
        {
            MD5 md5 = MD5.Create();
            byte[] inputbytes = Encoding.ASCII.GetBytes(password);
            byte[] hashbytes = md5.ComputeHash(inputbytes);
            StringBuilder strBuild = new StringBuilder();
            for (int i = 0; i < hashbytes.Length; i++)
                strBuild.Append(hashbytes[i].ToString("X2"));
            string result = strBuild.ToString();
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            sql_con.Open();
            SQLiteCommand sql_cmd = sql_con.CreateCommand();
            string CommandText = $"SELECT * FROM Users WHERE Login LIKE '{login}' AND Password LIKE '{result}'";
            SQLiteDataAdapter DB = new SQLiteDataAdapter(CommandText, sql_con);
            DataSet DS = new DataSet();
            DS.Reset();
            DB.Fill(DS);
            DataTable DT = new DataTable();
            DT = DS.Tables[0];
            sql_con.Close();
            if (DT.Rows.Count != 0)
                return true;
            else
                return false;
        }
        //Изменить пароль пользователя
        public void Change_Password(string login, string password)
        {
            MD5 md5 = MD5.Create();
            byte[] inputbytes = Encoding.ASCII.GetBytes(password);
            byte[] hashbytes = md5.ComputeHash(inputbytes);
            StringBuilder strBuild = new StringBuilder();
            for (int i = 0; i < hashbytes.Length; i++)
                strBuild.Append(hashbytes[i].ToString("X2"));
            string result = strBuild.ToString();
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            sql_con.Open();
            string sql = $"UPDATE Users SET Password = '{result}' WHERE Login LIKE '{login}'";
            SQLiteCommand command = new SQLiteCommand(sql, sql_con);
            command.ExecuteNonQuery();
            sql_con.Close();
        }
        //Удаление пользователя
        public void Delete_User(string login)
        {
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            sql_con.Open();
            string sql = $"DELETE FROM Users WHERE Login LIKE '{login}'";
            SQLiteCommand command = new SQLiteCommand(sql, sql_con);
            command.ExecuteNonQuery();
            sql_con.Close();
        }
        //Обновление если есть пользователь такой в таблице истории или создание новой статистики пользователя
        public void Update_User_History(string login, int games, int wins)
        {
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            sql_con.Open();
            SQLiteCommand sql_cmd = sql_con.CreateCommand();
            string CommandText = $"SELECT * FROM History WHERE Name LIKE '{login}'";
            SQLiteDataAdapter DB = new SQLiteDataAdapter(CommandText, sql_con);
            DataSet DS = new DataSet();
            DS.Reset();
            DB.Fill(DS);
            DataTable DT = new DataTable();
            DT = DS.Tables[0];
            if (DT.Rows.Count == 0)
            {
                string sql = $"INSERT INTO History VALUES ('{login}',{games},{wins})";
                SQLiteCommand command = new SQLiteCommand(sql, sql_con);
                command.ExecuteNonQuery();
            }
            else
            {
                string sql = $"UPDATE History SET Games = {games}, Wins = {wins} WHERE Name LIKE '{login}'";
                SQLiteCommand command = new SQLiteCommand(sql, sql_con);
                command.ExecuteNonQuery();
            }
            sql_con.Close();
        }
        //Получение количества игор пользователя, в случае если пользователя нет в истории метод возвращает -1
        public int GetCount_Games(string login)
        {
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            sql_con.Open();
            SQLiteCommand sql_cmd = sql_con.CreateCommand();
            string CommandText = $"SELECT * FROM History WHERE Name LIKE '{login}'";
            SQLiteDataAdapter DB = new SQLiteDataAdapter(CommandText, sql_con);
            DataSet DS = new DataSet();
            DS.Reset();
            DB.Fill(DS);
            DataTable DT = new DataTable();
            DT = DS.Tables[0];
            if (DT.Rows.Count == 0)
                return -1;
            sql_con.Close();
            int games_count = Convert.ToInt32(DT.Rows[0][1]);
            return games_count;
        }
        //Получение количества побед пользователя, в случае если пользователя нет в истории метод возвращает -1
        public int GetCount_Wins(string login)
        {
            SQLiteConnection sql_con = new SQLiteConnection("Data Source=TestDB.db;Version=3;");
            sql_con.Open();
            SQLiteCommand sql_cmd = sql_con.CreateCommand();
            string CommandText = $"SELECT * FROM History WHERE Name LIKE '{login}'";
            SQLiteDataAdapter DB = new SQLiteDataAdapter(CommandText, sql_con);
            DataSet DS = new DataSet();
            DS.Reset();
            DB.Fill(DS);
            DataTable DT = new DataTable();
            DT = DS.Tables[0];
            if (DT.Rows.Count == 0)
                return -1;
            sql_con.Close();
            int wins_count = Convert.ToInt32(DT.Rows[0][2]);
            return wins_count;
        }
    }
}
