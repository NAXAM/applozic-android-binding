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
using Java.Lang;

namespace Com.Applozic.Audiovideo.Authentication
{
    public partial class MakeAsyncRequest
    {
        protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Void>().ToArray());
        }
    }
}