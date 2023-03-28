using System;
using System.Threading.Tasks;
using CSharpForMarkup;
using Xamarin.Forms;
namespace ComparisonTest
{
	public class AnimationTestPage : ContentPage
	{
        private Grid animationGrid;
        private int gridSideLength = 15;
        private uint animationLength = 2000;

        public AnimationTestPage()
        {
            var grid = CreatePageGrid();
            AssignGridItems();
            Content = grid;
        }

        public Grid CreatePageGrid()
            => new Grid
            {
                Style = MarkupStyles.FillLayoutStyle,
                RowDefinitions =
                {
                new RowDefinition { Height = 100 },
                new RowDefinition { Height = GridLength.Star }
                },
                Children =
                {
                new StackLayout
                {
                    Style = MarkupStyles.CenterLayoutStyle,
                    Children =
                    {
                        new Button
                        {
                            Style = MarkupStyles.ButtonStyle,
                            Text = "Animate",
                            Command = AnimateCommand,
                        }
                    }
                }
                    .Row(0),

                new Grid
                {
                    Style = MarkupStyles.CenterLayoutStyle,
                    HeightRequest = 600,
                    WidthRequest = 600,
                    RowSpacing =1,
                    ColumnSpacing = 1,
                    RowDefinitions =
                    {
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },

                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },

                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star },
                        new RowDefinition { Height = GridLength.Star }
                    },

                    ColumnDefinitions =
                    {
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },

                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },

                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star },
                        new ColumnDefinition { Width = GridLength.Star }
                    },
                }
                    .Row(1).Assign(out animationGrid)
                }
            };

        void AssignGridItems()
        {
            for (var a = 0; a < gridSideLength; a++)
            {
                for (var b = 0; b < gridSideLength; b++)
                {
                    var box = new BoxView
                    {
                        Style = MarkupStyles.FillLayoutStyle,
                        Color = (b % 2) == 0 ? Color.Red : Color.Blue
                    }.Row(a).Col(b);

                    animationGrid.Children.Add(box);
                }
            }
        }

        Command AnimateCommand =>
            new Command(async () =>
            {

                var headerShrinkAnimation = new Animation();
                headerShrinkAnimation.Add(
                    0,
                    1,
                    new Animation(v => this.animationGrid.HeightRequest = v, 600, 100, Easing.CubicInOut));
                headerShrinkAnimation.Add(
                    0,
                    1,
                    new Animation(v => this.animationGrid.WidthRequest = v, 600, 100, Easing.CubicInOut));

                headerShrinkAnimation.Commit(
                    this,
                    "AnimateShrinkGrid",
                    16,
                    animationLength,
                    null);
                await Task.Delay((int)animationLength);
                var headerExpandAnimation = new Animation();
                headerExpandAnimation.Add(
                    0,
                    1,
                    new Animation(v => this.animationGrid.HeightRequest = v, 100, 600, Easing.CubicInOut));
                headerExpandAnimation.Add(
                    0,
                    1,
                    new Animation(v => this.animationGrid.WidthRequest = v, 100, 600, Easing.CubicInOut));


                headerExpandAnimation.Commit(
                    this,
                    "AnimateExpandGrid",
                    16,
                    animationLength,
                    null);
            });
    }
}


