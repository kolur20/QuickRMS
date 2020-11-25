using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRMS.Classes
{
    class SqlManager
    {
        static readonly SqlManager instance = new SqlManager();
        public static SqlManager GetInstance()
        {
            return instance;
        }


        public string FolderDB { get; private set; }
        public string NameDB { get; private set; }

        SQLiteConnection connection;
        SQLiteCommand command;

        SqlManager()
        {
            FolderDB = Properties.Settings.Default.FolderDataBase;
            NameDB = Properties.Settings.Default.NameDataBase + ".db";
            if (!Directory.Exists(FolderDB))
            {
                Directory.CreateDirectory(FolderDB);
                
            }
            connection = new SQLiteConnection($@"Data Source={FolderDB}\{NameDB}; Version=3;");
            if (!File.Exists(FolderDB + @"\" + NameDB))
            {
                try
                {


                    SQLiteConnection.CreateFile(NameDB);
                    
                    string q = @"CREATE TABLE IF NOT EXISTS Servers ("
                        + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                        + "name TEXT, "
                        + "connection TEXT, "
                        + "version TEXT, "
                        + "isChain BOOLEAN, "
                        + "coConnection TEXT, "
                        + "login TEXT, "
                        + "password TEXT)";

                    command = new SQLiteCommand(q, connection);
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    connection.Close();
                    throw ex;
                }

            }

        }
        
        public void Insert(Server server)
        {
            try
            {
                string q = @"INSERT INTO Servers ('name', 'connection', 'version', 'isChain', 'coConnection', 'login', 'password') values ("
                    + $"'{server.Name}','{server.Connection}','{server.Version}','{server.isChain}','{server.coConnection}','{server.Login}','{server.Password}')";
                command = new SQLiteCommand(q, connection);
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
        
        public void Insert(IEnumerable<Server> servers)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                command = new SQLiteCommand(connection);
                foreach (var server in servers)
                {
                    command.CommandText = @"INSERT INTO Servers ('name', 'connection', 'version', 'isChain', 'coConnection', 'login', 'password') values ("
                        + $"'{server.Name}','{server.Connection}','{server.Version}','{server.isChain}','{server.coConnection}','{server.Login}','{server.Password}')";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public IEnumerable<Server> GetData()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                command = new SQLiteCommand(connection);
                command.CommandText = @"SELECT * FROM Servers";
                SQLiteDataReader Servers = command.ExecuteReader();
                var listServer = new List<Server>();
                
                while (Servers.Read())
                {
                    var server = new Server();
                    server.Name = Servers.GetString(Servers.GetOrdinal("name"));
                    server.Connection = Servers.GetString(Servers.GetOrdinal("connection"));
                    server.Version = Servers.GetString(Servers.GetOrdinal("version"));
                    server.isChain = Servers.GetString(Servers.GetOrdinal("isChain")) == true.ToString() ? true : false;
                    server.coConnection = Servers.GetString(Servers.GetOrdinal("coConnection"));
                    server.Login = Servers.GetString(Servers.GetOrdinal("login"));
                    server.Password = Servers.GetString(Servers.GetOrdinal("password"));
                    listServer.Add(server);
                }
                connection.Close();
                return listServer.ToList();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public void RemoveAll()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                command = new SQLiteCommand(connection);
                command.CommandText = @"DELETE FROM Servers";
                SQLiteDataReader Servers = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }

        public void UpdateVersions(ICollection<Server> servers)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                command = new SQLiteCommand(connection);
                command.CommandText = "";
                foreach (var server in servers)
                {
                    command.CommandText += $@"UPDATE Servers SET version = '{server.Version}' WHERE name = '{server.Name}';";
                    
                }
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                throw ex;
            }
        }
       
         
    }
}
