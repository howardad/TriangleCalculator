using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Globalization.NumberFormatting;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace TriangleCalculator
{
    public sealed partial class MainPage : Page
    {
        private INumberFormatter2 MyFormatter { get; } = new DecimalFormatter
        {
            NumberRounder = new IncrementNumberRounder
            {
                Increment = 0.01
            },
            IsGrouped = false,
            FractionDigits = 0
        };

        public MainPage()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            hypotenuseNumberBox.Value = RightTriangleMath.FindHypotenuse(heightNumberBox.Value, lengthNumberBox.Value);
            angleACNumberBox.Value = RightTriangleMath.FindAngleFromSides(heightNumberBox.Value, lengthNumberBox.Value);
            angleBCNumberBox.Value = RightTriangleMath.FindOtherAngle(angleACNumberBox.Value);
        }
    }
}
