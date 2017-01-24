using Android.App;
using Android.OS;

namespace Xamarin.Droid.NoHistory
{
    [Activity(Label = "MainActivity")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
        }
    }
}

