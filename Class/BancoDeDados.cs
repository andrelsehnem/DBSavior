using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSavior.Class
{
    public abstract class BancoDeDados
    {
        protected string connectionString;
        protected DbConnection conn;
        protected DbDataReader reader;
        protected DbCommand comand;
        protected Banco banco { get; set; }
        public BancoDeDados(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public BancoDeDados(Banco _b)
        {
            this.banco = _b;
        }

        public abstract bool Open();

        public abstract void Close();

        public abstract DataTable ExecuteQuery(string query);

        public abstract int ExecuteNonQuery(string query);
    }
}
