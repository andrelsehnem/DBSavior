using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSavior.Class
{
    public static class Globals
    {
        public enum PostgresType
        {
            psql = 0,
            pg_restore
        }

        public enum FirebirdType
        {
            fbkFbd = 0,
            gbkGbd
        }

        public static string NovaLinha = "\r\n";
    }
}
