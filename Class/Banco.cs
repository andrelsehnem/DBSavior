using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSavior.Class
{
    public enum TipoBanco
    {
        MySql,
        SqlServer,
        Firebird,
        Postgress
    }
    public class Banco
    {
        public string banco { get; set; }
        public string server { get; set; }
        public string porta { get; set; }
        public string user { get; set; }
        public string senha { get; set; }
        //public int database { get; set; } //0=mysql, 1=sql server, 2= firebird
        public TipoBanco tpBanco { get; set; }

        public Banco(string _banco, string _server, string _porta, string _user, string _senha, TipoBanco _database)
        {
            banco = _banco;
            server = _server;
            porta = _porta;
            user = _user;
            senha = _senha;
            tpBanco = _database;
        }

        public string GetConnectionString()
        {
            switch (tpBanco)
            {
                case TipoBanco.MySql:
                    return $"Server ={server}; Port ={porta}; Database ={banco}; uid={user};pwd={senha}; SslMode= none"; 
                case TipoBanco.Postgress:
                    return $"Server={server};Port={porta};Database={banco};User Id={user};Password={senha}"; 
            }
            return "";
        }

        public string GetConnectionString_SemBanco()
        {
            switch (tpBanco)
            {
                case TipoBanco.MySql:
                    return "";
                case TipoBanco.Postgress:
                    return $"Server={server};Port={porta};Database=;User Id={user};Password={senha}";
            }
            return "";
        }

    }

    
}
