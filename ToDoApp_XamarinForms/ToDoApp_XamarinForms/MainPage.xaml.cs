using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_XamarinForms.Views;
using Xamarin.Forms;

namespace ToDoApp_XamarinForms {

    public partial class MainPage : ContentPage {

        public MainPage() {

            InitializeComponent();
        }

        private void GoToToDoItems(object sender, EventArgs e) {

            Navigation.PushAsync(new TodoListPage());
        }
    }
}
