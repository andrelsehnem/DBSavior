using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSavior.Class
{
    public class Postgres : BancoDeDados
    {
        public NpgsqlConnection connection;
        public DbConnection conn;
        public DbDataReader reader;
        public DbCommand comand;
        public Banco banco { get; set; }


        public Postgres(string conString) : base(conString)
        {

        }

        public Postgres(Banco _b) : base(_b)
        {
            banco = _b;
            connectionString = _b.GetConnectionString();
        }

        public override bool Open()
        {
            try
            {
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
                return true;
            }catch (Exception ex)
            {
                if(ex.Message.StartsWith("28P01"))
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                else if (ex.Message.StartsWith("3D000"))
                {
                    if (CriaBanco()) return true;
                }
                else
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                MessageBox.Show(ex.ToString());
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
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
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
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
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
            connectionString = banco.GetConnectionString_SemBanco();
            if (!Open()) return false;
            ExecuteNonQuery($"CREATE DATABASE {banco.banco} WITH OWNER = {banco.user} ENCODING = 'UTF8' CONNECTION LIMIT = -1 IS_TEMPLATE = False; ");
            return true;
        }

        public bool IsOpen()
        {
            if(connection.State.ToString() == "Closed")
            {
                return false;
            }
            else return true;
        }

        
    }
}
