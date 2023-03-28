using System;
using System.Diagnostics;
using CSharpForMarkup;
using Xamarin.Forms;

namespace ComparisonTest
{
	public class NavTestPage : ContentPage
	{
        private Grid grid;
        private Stopwatch stopwatch;
        private Label timerLabel;
        public NavTestPage()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();

            timerLabel = new Label
            {
                Style = MarkupStyles.TimerLabelStyle
            }
               .Row(0);

            var outterGrid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = 100 },
                    new RowDefinition {Height = GridLength.Star }
                }
            };

            grid = new Grid
            {

                Style = MarkupStyles.FillLayoutStyle,
                RowSpacing = 1,
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
                .Row(1);

            AssignGridItems();
            outterGrid.Children.Add(timerLabel);
            outterGrid.Children.Add(grid);
            Content = outterGrid;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            stopwatch.Stop();
            timerLabel.Text = $"{stopwatch.ElapsedMilliseconds} ms";
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to load this page.");
        }


        void AssignGridItems()
        {
            for(var a = 0; a < 25; a++)
            {
                for(var b = 0; b < 25; b++)
                {
                    grid.Children.Add(new BoxView
                    {
                        Style = MarkupStyles.FillLayoutStyle,
                        Color = (b % 2) == 0 ? Color.Red : Color.Blue
                    }, b, a);
                }
            }
        }
    }
}


