using Amazing.Droid;
using Amazing.Vistas.Inicio;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyCustomeEntry), typeof(MyEntryRenderer))]

namespace Amazing.Droid
{
    public class MyEntryRenderer: EntryRenderer
    {
        public MyEntryRenderer(Context context): base (context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}