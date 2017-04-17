using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_XamarinForms.Models;
using Xamarin.Forms;
using XamarinForms.SQLite.SQLite;

namespace ToDoApp_XamarinForms.DAL {

    public class ToDoDB {

        private readonly SQLiteConnection _sqLiteConnection;

        public ToDoDB() {

            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();

            _sqLiteConnection.CreateTable<ToDoItem>();
        }

        public void AddItem(ToDoItem item) {
            _sqLiteConnection.Insert(item);
        }

        public void UpdateItem(ToDoItem item) {
            _sqLiteConnection.Update(item);
        }
        public void RemoveItem(ToDoItem item) {
            _sqLiteConnection.Delete(item);
        }

        public List<ToDoItem> GetAllItems() {
            return _sqLiteConnection.Table<ToDoItem>().ToList();
        }

        public ToDoItem GetItemByID(int Id) {
            return _sqLiteConnection.Table<ToDoItem>().Where(i => i.Id == Id).FirstOrDefault();
        }

        internal bool IfItemExists(int itemId) {
            return _sqLiteConnection.Table<ToDoItem>().Where(i => i.Id == itemId).Any();
        }
    }
}
