using Xamarin.Forms;
using Android.Content.Res;
using Xamarin.Forms.Platform.Android;
using tastxam;
using tastxam.Droid;
using Android.Graphics;

[assembly: ExportRenderer(typeof(ExtendedLabel), typeof(ExtendedLabelRenderer))]
namespace tastxam.Droid
{
    internal class ExtendedLabelRenderer : LabelRenderer
    {

        public ExtendedLabelRenderer()
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var extendedLabel = Element as ExtendedLabel;

            if (this.Control == null || extendedLabel == null)
                return;

            if (!string.IsNullOrWhiteSpace(extendedLabel.FontFamily))
                this.Control.Typeface = Typeface.CreateFromAsset(Resources.Assets, "Planet N 2 cyr-lat.ttf");

        }
    }
}