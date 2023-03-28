using System;
using System.Diagnostics;
using CSharpForMarkup;
using Xamarin.Forms;

namespace ComparisonTest
{
	public class MainPage : ContentPage
	{
        public MainPage()
        {
            Content = new Grid
            {
                Style = MarkupStyles.FillLayoutStyle,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Star },
                    new RowDefinition { Height = GridLength.Star },
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
                                Text = "Xamarin Navigate",
                                Command = NavigateToNavPageCommand,
                            }
                        }
                    }
                        .Row(0),

                    new StackLayout
                    {
                        Style = MarkupStyles.CenterLayoutStyle,
                        Children =
                        {
                            new Button
                            {
                                Style = MarkupStyles.ButtonStyle,
                                Text =  "Go to Xamarin Animation Example",
                                Command = NavigateToAnimationPageCommand,
                            }
                        }
                    }
                        .Row(1),

                    new StackLayout
                    {
                        Style = MarkupStyles.CenterLayoutStyle,
                        Children =
                        {
                            new Button
                            {
                                Style = MarkupStyles.ButtonStyle,
                                Text =  "Go to Xamarin List Example",
                                Command = NavigateToListPageCommand,
                            }
                        }
                    }
                        .Row(2)
            }
            };
        }

        Command NavigateToNavPageCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    await Navigation.PushAsync(new NavTestPage());
                    stopwatch.Stop();
                    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to navigate to this page.");
                });
            }
        }

        Command NavigateToAnimationPageCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    await Navigation.PushAsync(new AnimationTestPage());
                    stopwatch.Stop();
                    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to navigate to this page.");
                });
            }
        }

        Command NavigateToListPageCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    await Navigation.PushAsync(new ListTestPage());
                    stopwatch.Stop();
                    Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms to navigate to this page.");
                });
            }
        }
    }
}


