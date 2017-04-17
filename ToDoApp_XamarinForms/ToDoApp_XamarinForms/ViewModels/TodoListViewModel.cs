using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_XamarinForms.DAL;
using ToDoApp_XamarinForms.Models;

namespace ToDoApp_XamarinForms.ViewModels {

    public class TodoListViewModel : INotifyPropertyChanged {

        private ObservableCollection<ToDoItem> items;

        public ObservableCollection<ToDoItem> Items {
            get { return items; }
            set { items = value;
                OnPropertyChanged("Items");
            }
        }


        public TodoListViewModel() {

            ToDoDB _context = new ToDoDB();

            Items = new ObservableCollection<ToDoItem>(_context.GetAllItems());
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
