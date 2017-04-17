using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_XamarinForms.Models;
using ToDoApp_XamarinForms.Views;
using Xamarin.Forms;

namespace ToDoApp_XamarinForms.Views {

    public partial class TodoListPage : ContentPage {

        public TodoListPage() {

            InitializeComponent();

        }

        protected override void OnAppearing() {
            base.OnAppearing();

            BindingContext = new ToDoApp_XamarinForms.ViewModels.TodoListViewModel();
        }

        private void OnItemSelected(object sender, ItemTappedEventArgs e) {

            var item = (ToDoItem)e.Item;

            Navigation.PushAsync(new TodoCreateEditPage(item.Id));

        }


        private void OnNewItem(object sender, EventArgs e) {
            Navigation.PushAsync(new TodoCreateEditPage());
        }
    }
}
