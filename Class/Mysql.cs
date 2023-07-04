using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBSavior.Class
{
    public class Mysql : BancoDeDados
    {
        public MySqlConnection connection { get; set; }
        public DbConnection conn;
        public DbDataReader reader;
        public DbCommand comand;
        public new Banco banco { get; set; }


        public Mysql(string conString) : base(conString)
        {

        }

        public Mysql(Banco _b) : base(_b)
        {
            banco = _b;
            connectionString = _b.GetConnectionString();
        }

        public override bool Open()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("28P01"))
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                else if (ex.Message.StartsWith("3D000"))
                {
                    if (CriaBanco()) return true;
                }
                else if (ex.Message.StartsWith("Authentication to host"))
                {
                    return false ;
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                //MessageBox.Show(ex.ToString());
            }
            return false;
        }

        public override void Close()
        {
            connection.Close();
        }

        public override DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataTable;
        }

        public override int ExecuteNonQuery(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return -1;
            }
        }

        public bool CriaBanco()
        {
            if (!Open()) return false;
            ExecuteNonQuery($"CREATE DATABASE {banco.banco} ");
            return true;
        }

        public bool IsOpen()
        {
            if (connection == null || connection.State.ToString() == "Closed")
            {
                return false;
            }
            else return true;
        }
    }
}
