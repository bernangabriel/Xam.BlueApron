﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(BlueApron.Renderers.PickerWhiteBox),
    typeof(BlueApron.Droid.Rendereres.PickerWhiteBox))]
namespace BlueApron.Droid.Rendereres
{
    public class PickerWhiteBox : PickerRenderer
    {
        public PickerWhiteBox(Context context)
            :base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.White);
            }
        }
    }
}