using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XAMLApp.Data
{
    public interface ISQLite
    {
        SQLiteConnection PegarConexao();
    }
}
