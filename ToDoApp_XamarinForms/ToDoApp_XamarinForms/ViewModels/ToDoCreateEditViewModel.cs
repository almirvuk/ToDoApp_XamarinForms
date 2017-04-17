using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp_XamarinForms.ViewModels {

    public class TodoCreateEditViewModel : INotifyPropertyChanged {

        private string title;

        public string Title {
            get { return title; }
            set { title = value;
                OnPropertyChanged("Title");
            }
        }

        private string content;

        public string Content {
            get { return content; }
            set { content = value;
                OnPropertyChanged("Content");

            }
        }

        public TodoCreateEditViewModel(int id) {

            if (id == 0) {
                Title = "";
                Content = "";
            }
            else {
                Title = "";
                Content = "";
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
