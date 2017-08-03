using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp_XamarinForms.DAL;
using Xamarin.Forms;

namespace ToDoApp_XamarinForms.ViewModels {

    public class TodoCreateEditViewModel : INotifyPropertyChanged {

        private string title;
        public string Title {
            get { return title; }
            set {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        private string content;
        public string Content {
            get { return content; }
            set {
                content = value;
                OnPropertyChanged("Content");
            }
        }

        public int ItemId { get; set; }

        public TodoCreateEditViewModel(int id) {

            if (id == 0) {
                Title = "";
                Content = "";
            }
            else {

                ToDoDB _context = new ToDoDB();
                var todoItem = _context.GetItemByID(id);
                Title = todoItem.Title;
                Content = todoItem.Content;
                ItemId = id;

            }
        }


        public ICommand Save {
            get {
                return new Command(async () =>
                {

                    ToDoDB _context = new ToDoDB();

                    if (_context.IfItemExists(ItemId)) {
                        _context.UpdateItem(new Models.ToDoItem() { Content = Content, Title = Title, CreatedAt = DateTime.Now, Id = ItemId });
                    }
                    else {
                        _context.AddItem(new Models.ToDoItem() { Content = Content, Title = Title, CreatedAt = DateTime.Now });
                    }

                    await App.Current.MainPage.Navigation.PopAsync();
                });
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
