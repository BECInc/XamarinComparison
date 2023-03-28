using System;
using CSharpForMarkup;
using Xamarin.Forms;

namespace ComparisonTest
{
    public class CustomCell : ViewCell
    {
        private Grid complexGrid;

        public CustomCell(Thingy thingy)
        {
            var view = this.CreateCellView(thingy);
            this.AssignGridItems();

            View = view;
        }

        Grid CreateCellView(Thingy thingy)
            => new Grid
            {
                Style = MarkupStyles.FillLayoutStyle,
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = 100 },
                    new ColumnDefinition { Width = GridLength.Star },
                    new ColumnDefinition { Width = GridLength.Star },
                },
                Children =
                {
                    new BoxView
                    {
                        Style = MarkupStyles.FillLayoutStyle,
                        Color = Color.Blue,
                        Margin = 5
                    }
                        .Col(0),

                    new Grid
                    {
                        Style = MarkupStyles.FillLayoutStyle,
                        BackgroundColor = Color.Black,
                        Margin = 5,
                        RowDefinitions =
                        {
                            new RowDefinition { Height = GridLength.Star },
                            new RowDefinition { Height = GridLength.Star }
                        },
                        Children =
                        {
                            new Label
                            {
                                Style = MarkupStyles.CellLabelStyle,
                                Text = thingy.Title,
                            }
                                .Row(0),
                            new Label
                            {
                                Style = MarkupStyles.CellLabelStyle,
                                Text = thingy.Subtitle,
                            }
                                .Row(1),
                        }
                    }
                        .Col(1),
                   new Grid
                    {
                        Style = MarkupStyles.FillLayoutStyle,
                        RowSpacing =1,
                        ColumnSpacing = 1,
                        Margin = 5,
                        RowDefinitions =
                        {
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
                            new ColumnDefinition { Width = GridLength.Star }
                        },
                    }
                        .Col(2).Assign(out complexGrid)

                }
            };

        void AssignGridItems()
        {
            for (var a = 0; a < 5; a++)
            {
                for (var b = 0; b < 5; b++)
                {
                    var box = new BoxView
                    {
                        HorizontalOptions = LayoutOptions.Fill,
                        VerticalOptions = LayoutOptions.Fill,
                        Color = (b % 2) == 0 ? Color.Red : Color.Blue
                    }.Row(a).Col(b);

                    complexGrid.Children.Add(box);
                }
            }
        }
    }
}

