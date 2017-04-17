using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using ToDoApp_XamarinForms.Droid.Renderers;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace ToDoApp_XamarinForms.Droid.Renderers {
    class MyEntryRenderer : EntryRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e) {
            base.OnElementChanged(e);

            if (Control != null) {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Purple);
                Control.SetTextColor(global::Android.Graphics.Color.White);
                Control.Text = Control.Text.ToUpper();
            }
        }
    }
}