﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlueApron.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodItem : ContentView
    {
        public FoodItem()
        {
            InitializeComponent();
        }
    }
}