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

namespace Violet.Droid
{
    [Activity(Label = "AboutActivity1", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class AboutActivity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Sobre);
        }
    }
}