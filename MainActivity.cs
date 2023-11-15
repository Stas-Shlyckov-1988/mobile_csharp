using Android.Content;
using Android.Widget;

namespace AndroidMobile
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);

            button1.Click += (sender, e) => {
                // Perform action on click
                button1.Text = "clicked!";
            };

            Button button2 = FindViewById<Button>(Resource.Id.button2);

            button2.Click += (sender, e) => {
                // Perform action on click
                button2.Text = "clicked!";
            };
        }
    }
}