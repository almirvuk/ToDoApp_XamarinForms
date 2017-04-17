using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp_XamarinForms.DAL;
using ToDoApp_XamarinForms.ViewModels;
using Xamarin.Forms;

namespace ToDoApp_XamarinForms.Views {

    public partial class TodoCreateEditPage : ContentPage {

        public TodoCreateEditPage(int id = 0) {

            InitializeComponent();

            BindingContext = new TodoCreateEditViewModel(id, this.Navigation);
        }

    }
}
