using System;

// forums question
// http://forums.xamarin.com/discussion/17278/custom-font-in-xamarin-forms-font-awesome#latest

// custom fonts in iOS
// http://blog.xamarin.com/custom-fonts-in-ios/

// open-source font download
// https://www.google.com/fonts

using Xamarin.Forms;

namespace tastxam
{
	
	public class FontPageCs : ContentPage
	{
		public FontPageCs()
		{

			var label = new ExtendedLabel
            {
                Text = "Hello, Xamarin.Forms!",
                FontFamily = Device.OnPlatform(
                    "Lobster-Regular", // iOS
                    "#Planet N 2 cyr-lat", // Android
                    @"\Assets\Fonts\Lobster-Regular.ttf#Lobster-Regular" // WinPhone
                ),
                VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,

			};
            
            //label.FontFamily = "Planet N 2 cyr-lat";
                label.FontSize = Device.OnPlatform(
				24,
				Device.GetNamedSize(NamedSize.Medium, label),
				Device.GetNamedSize(NamedSize.Large, label)
			);
            

			var labelBold = new Label
			{
				Text = "Bold",
				FontSize = 14,
				FontAttributes = FontAttributes.Bold,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
            //labelBold.FontFamily = "Arial";

            var labelItalic = new Label
			{
				Text = "Italic",
				FontSize = 14,
				FontAttributes = FontAttributes.Italic,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
           // labelBold.FontFamily = "Arial";
            var labelBoldItalic = new Label
			{
				Text = "BoldItalic",
				FontSize = 14,
				FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			// Span formatting support
			var labelFormatted = new Label();
			var fs = new FormattedString();
			fs.Spans.Add(new Span { Text = "Red, ", ForegroundColor = Color.Red, FontSize = 20, FontAttributes = FontAttributes.Italic });
			fs.Spans.Add(new Span { Text = " blue, ", ForegroundColor = Color.Blue, FontSize = 32 });
			fs.Spans.Add(new Span { Text = " and green!", ForegroundColor = Color.Green, FontSize = 12 });
			labelFormatted.FormattedText = fs;

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					label, labelBold, labelItalic, labelBoldItalic, labelFormatted
				}
			};
            labelBold.FontFamily = "Arial";

        }  
    }
}

