using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace XamarinForms.SQLite.SQLite {

    public interface ISQLite {

        SQLiteConnection GetConnection();
    }
}
