using System;
using CSharpForMarkup;
using Xamarin.Forms;

namespace ComparisonTest
{
    public static class MarkupStyles
    {
        public static Style<Button> ButtonStyle = new Style<Button>(
            (Button.StyleProperty, CenterLayoutStyle),
            (Button.FontSizeProperty, 20),
            (Button.FontAttributesProperty, FontAttributes.Bold),
            (Button.BackgroundColorProperty, Color.Blue),
            (Button.TextColorProperty, Color.White),
            (Button.HeightRequestProperty, 50),
            (Button.CornerRadiusProperty, 10),
            (Button.PaddingProperty, new Thickness(10, 0)));

        public static Style<View> CenterLayoutStyle = new Style<View>(
             (View.HorizontalOptionsProperty, LayoutOptions.Center),
             (View.VerticalOptionsProperty, LayoutOptions.Center));

        public static Style<Layout> FillLayoutStyle = new Style<Layout>(
             (Layout.HorizontalOptionsProperty, LayoutOptions.Fill),
             (Layout.VerticalOptionsProperty, LayoutOptions.Fill));

        public static Style<Label> TimerLabelStyle = new Style<Label>(
            (Label.StyleProperty, CenterLayoutStyle),
            (Label.VerticalTextAlignmentProperty, TextAlignment.Center),
            (Label.HorizontalTextAlignmentProperty, TextAlignment.Center),
            (Label.FontSizeProperty, 60));

        public static Style<Label> CellLabelStyle = new Style<Label>(
            (Label.StyleProperty, CenterLayoutStyle),
            (Label.TextColorProperty, Color.White),
            (Label.BackgroundColorProperty, Color.Transparent),
            (Label.VerticalTextAlignmentProperty, TextAlignment.Center),
            (Label.HorizontalTextAlignmentProperty, TextAlignment.Center),
            (Label.FontSizeProperty, 25));
    }
}

