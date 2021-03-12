using Android.App;
using Android.Widget;
using Android.OS;

namespace Practice2019
{
    [Activity(Label = "Practice2019", MainLauncher = true, Icon ="@drawable/logo2019")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var int1 = FindViewById<EditText>(Resource.Id.editText1);
            var int2 = FindViewById<EditText>(Resource.Id.editText2);
            var result = FindViewById<TextView>(Resource.Id.textView1);

            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate
            {
                int x = System.Convert.ToInt32(int1.Text);
                int y = System.Convert.ToInt32(int2.Text);
                int z = x + y;

                result.Text = z.ToString();
            };

        }
    }
}

