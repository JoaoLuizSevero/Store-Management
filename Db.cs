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
            return DataQuery("SELECT N_ID as 'ID', T_NAME as 'Name', CASE WHEN N_ACCESSLEVEL = 0 THEN 'Intern' WHEN N_ACCESSLEVEL = 1 THEN 'Operator' WHEN N_ACCESSLEVEL = 2 THEN 'Supervisor' WHEN N_ACCESSLEVEL = 3 THEN 'Manager' END as 'Access level' FROM tb_users WHERE T_NAME NOT IN (SELECT T_NAME FROM `tb_users` WHERE T_NAME='admin') ORDER BY N_ID");
        }

        public static DataTable GetAllItems()
        {
            return DataQuery("SELECT N_ID as 'ID', T_MODEL as 'Model', T_PRICE as 'Price', N_QUANTITY as 'Stock', T_DESCRIPTION as 'Size', T_COLOR as 'Color' FROM tb_items ORDER BY N_ID");
        }

        public static DataTable GetUser(string username, string password)
        {
            return DataQuery("SELECT * FROM tb_users WHERE T_USERNAME='" + username + "' AND T_PASSWORD='" + password + "'");
        }

        public static DataTable GetPerId(Int32 id, String table)
        {
            return DataQuery("SELECT * FROM tb_"+table+" WHERE N_ID=" + id);
        }

        public static void Delete(string id, String table)
        {
            DataManipulation("DELETE FROM tb_"+table+" WHERE N_ID = " + id,"Deleted successful!","Error deleting!");
        }

        public static void SaveUser(User thisUser, String id)
        {
            if(id != null)
            {
                var command = "UPDATE tb_users SET T_NAME='" + thisUser.name + "', T_USERNAME='" + thisUser.username + "', T_PASSWORD='" + thisUser.password + "', N_ACCESSLEVEL=" + thisUser.accessLevel + ", T_PHOTO='" + thisUser.photo + "' WHERE N_ID=" + id;
                var successMessage = "User updated!";
                var errorMessage = "Error updating user!";
                DataManipulation(command, successMessage, errorMessage);
            }
            else
            {
                var command = "INSERT INTO tb_users (T_NAME, T_USERNAME, T_PASSWORD, N_ACCESSLEVEL, T_PHOTO) VALUES ('" + thisUser.name + "','" + thisUser.username + "','" + thisUser.password + "'," + thisUser.accessLevel + ",'" + thisUser.photo + "')";
                var successMessage = "New user added!";
                var errorMessage = "Error adding new user!";
                DataManipulation(command, successMessage, errorMessage);
            }
        }

        public static void SaveItem(Item thisItem, string id)
        {
            if (id != null)
            {
                var command = "UPDATE tb_items SET T_MODEL='" + thisItem.model + "', T_PRICE='" + thisItem.price + "', N_QUANTITY=" + thisItem.stock + ", T_DESCRIPTION='" + thisItem.description + "', T_COLOR='" + thisItem.color + "', T_IMAGE='"+ thisItem.image+ "' WHERE N_ID=" + id;
                var successMessage = "Item updated!";
                var errorMessage = "Error updating Item!";
                DataManipulation(command, successMessage, errorMessage);
            }
            else
            {
                var command = "INSERT INTO tb_items (T_MODEL, T_PRICE, N_QUANTITY, T_DESCRIPTION, T_COLOR, T_IMAGE) VALUES ('" + thisItem.model + "','" + thisItem.price + "'," + thisItem.stock + ",'" + thisItem.description + "','" + thisItem.color +"','" + thisItem.image + "')";
                var successMessage = "New item added!";
                var errorMessage = "Error adding new item!";
                DataManipulation(command, successMessage, errorMessage);
            }
        }

    }
}
