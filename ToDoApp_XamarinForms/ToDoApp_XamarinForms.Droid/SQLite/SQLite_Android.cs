using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinForms.SQLite.Droid.SQLite;
using XamarinForms.SQLite.SQLite;

[assembly: Dependency(typeof(SQLite_Android))]

namespace XamarinForms.SQLite.Droid.SQLite
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "MySQLiteDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}