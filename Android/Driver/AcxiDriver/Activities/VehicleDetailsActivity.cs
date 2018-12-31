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
using Android.Support.V7.App;
using UK.CO.Chrisjenx.Calligraphy;

namespace AcxiDriver.Activities
{
    [Activity(Label = "VehicleDetailsActivity", MainLauncher = false, Theme ="@style/AcxiTheme1")]
    public class VehicleDetailsActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar mtoolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
   .SetDefaultFontPath("Fonts/Lato-Regular.ttf")
.SetFontAttrId(Resource.Attribute.fontPath)
.Build());
            SetContentView(Resource.Layout.vehicledetails_reg);
            mtoolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.vehiclereg_Toolbar);
            SetSupportActionBar(mtoolbar);
            SupportActionBar.Title = "Vehicle details";

            Android.Support.V7.App.ActionBar ab = SupportActionBar;
            ab.SetDisplayHomeAsUpEnabled(true);
            ab.SetHomeAsUpIndicator(Resource.Mipmap.ic_arrow_back_white);
            
        }

        protected override void AttachBaseContext(Android.Content.Context @base)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(@base));
        }
    }
}