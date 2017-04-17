using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ToDoApp_XamarinForms.Views {

    public partial class TodoListPage : ContentPage {

        public TodoListPage() {

            InitializeComponent();

            BindingContext = new ToDoApp_XamarinForms.ViewModels.TodoListViewModel();
        }

        private void OnItemSelected(object sender, ItemTappedEventArgs e) {

        }


        private void OnNewItem(object sender, EventArgs e) {
            Navigation.PushAsync(new ToDoCreateEditPage());
        }
    }
}
