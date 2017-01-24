using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Xamarin.Droid.NoHistory
{
    [Activity(Label = "LoginActivity", MainLauncher = true, Icon = "@drawable/icon", NoHistory = true)]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LoginLayout);

            Button startMainActivityButton = FindViewById<Button>(Resource.Id.login_button);
            startMainActivityButton.Click += (sender, args) =>
            {
                StartActivity(typeof(MainActivity));
            };

        }

    }
}