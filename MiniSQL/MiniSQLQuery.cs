﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSQL
{
    public interface MiniSQLQuery
    {
        string Execute(Database database);
    }
}
