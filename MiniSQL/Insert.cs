using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    public class Insert: MiniSQLQuery
    {
        public string Table= null;
        public List<string> Columns = null;
        public List<string> Values = null;

        public Insert(string table, List<string> columns, List<string> values)
        {
            Table = table;
            Columns = columns;
            Values = values;
        }

        public string Execute(Database database)
        {
            return database.Insert(Table, Columns, Values);
        }
    }
}
