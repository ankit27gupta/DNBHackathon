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
using FinMan.Custom;
using FinMan.Data;

namespace FinMan
{
    [Activity]
    public class TargetHistoryActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var listView = FindViewById<ListView>(Resource.Id.targetListView);
            var targets = TargetGenerator.GetPreviousMockedTargets();

        }
    }
}