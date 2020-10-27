using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StoreManagement
{
    class Db
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection DBConnection()
        {
            try
            {
                connection = new SQLiteConnection("Data Source = " + Globals.DBPath + Globals.DBName);
                connection.Open();
                return connection;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error connecting database!");
                throw ex;
            }
        }

        private static DataTable DataQuery(string content)
        {
            try
            {
                var connection = DBConnection();
                var command = connection.CreateCommand();
                command.CommandText = content;
                SQLiteDataAdapter data = new SQLiteDataAdapter(command.CommandText, connection);
                DataTable table = new DataTable();
                data.Fill(table);
                connection.Close();
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning data!");
                throw ex;
            }
        }

        private static void DataManipulation(string content, string successMessage = null, string errorMessage = null)
        {
            try
            {
                var connection = DBConnection();
                var command = connection.CreateCommand();
                command.CommandText = content;
                command.ExecuteNonQuery();
                connection.Close();
                if (successMessage != null)
                {
                    MessageBox.Show(successMessage);
                }
            }
            catch (Exception ex)
            {
                if (errorMessage != null)
                {
                    MessageBox.Show(errorMessage);
                }
                throw ex;
            }
        }

        public static DataTable GetAllUsers()
        {
            return DataQuery("SELECT * FROM tb_users");
        }

        public static DataTable GetUser(string username, string password)
        {
            return DataQuery("SELECT * FROM tb_users WHERE T_USERNAME='" + username + "' AND T_PASSWORD='" + password + "'");
        }

        public static void NewUser(User newUser)
        {
            var command = "INSERT INTO tb_users (T_NAME, T_USERNAME, T_PASSWORD, N_ACCESSLEVEL, T_PHOTO) VALUES ('"+newUser.name+"','"+newUser.username+"','"+newUser.password+"',"+newUser.accessLevel+",'"+newUser.photo+"')";
            var successMessage = "New user added!";
            var errorMessage = "Error adding new user!";
            DataManipulation(command, successMessage, errorMessage);
        }

        /*
        "SELECT N_IDUSUARIO as 'ID Usuário',T_NOMEUSUARIO as 'Nome Usuário' FROM tb_usuarios";
        "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO=" + id;
        "UPDATE tb_usuarios SET T_NOMEUSUARIO='" + u.name + "',T_USERNAME='" + u.username + "',T_SENHAUSUARIO='" + u.password + "',T_STATUSUSUARIO='" + u.status + "',N_NIVELUSUARIO=" + u.level + " WHERE N_IDUSUARIO=" + u.id;    
        
        "DELETE FROM tb_usuarios WHERE N_IDUSUARIO='" + id + "'";
        */

    }
}
