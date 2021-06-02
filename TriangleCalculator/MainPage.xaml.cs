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
        private const double RAD_TO_DEG_FACTOR = 180.0 / Math.PI;

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
            var height = heightNumberBox.Value;
            var length = lengthNumberBox.Value;

            var hypotenuse = Math.Sqrt(height * height + length * length);
            var angleAC = Math.Atan(length / height) * RAD_TO_DEG_FACTOR;
            var angleBC = Math.Atan(height / length) * RAD_TO_DEG_FACTOR;

            hypotenuseNumberBox.Value = hypotenuse;
            angleACNumberBox.Value = angleAC;
            angleBCNumberBox.Value = angleBC;
        }
    }
}
