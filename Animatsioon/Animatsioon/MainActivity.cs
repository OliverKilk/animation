using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics.Drawables;

namespace Animatsioon
{
    [Activity(Label = "Animation", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
        }
        public override void OnWindowFocusChanged(bool hasFocus)
        {
            if (hasFocus)
            {
                ImageView imageView = FindViewById<ImageView>(Resource.Id.animated_android);
                AnimationDrawable animation = (AnimationDrawable)imageView.Drawable;
                animation.Start();
            }
        }
    }
}

