using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

            Items = new ObservableCollection<ToDoItem>();

            ToDoItem item1 = new ToDoItem() { Content = "Lorem ipsum is dudnta esat vie", CreatedAt = DateTime.Now, Id = 1, Title = "Test 1" };
            ToDoItem item2 = new ToDoItem() { Content = "Lorem ipsum is t vie", CreatedAt = DateTime.Now, Id = 2, Title = "Test 2" };
            ToDoItem item3 = new ToDoItem() { Content = "Lorem ipsum is  vie", CreatedAt = DateTime.Now, Id = 3, Title = "Test 3" };
            ToDoItem item4 = new ToDoItem() { Content = "Lorem ipsdudnta esat vie", CreatedAt = DateTime.Now, Id = 4, Title = "Test 4" };

            Items.Add(item1);
            Items.Add(item2);
            Items.Add(item3);
            Items.Add(item4);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
