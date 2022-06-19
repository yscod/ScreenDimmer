using System;
using System.Windows;
using System.Windows.Controls;

namespace ScreenDimmer
{
    public partial class Controls : Window
    {
        public Window Main { get; set; }

        public Controls()
        {
            InitializeComponent();
        }

        public Controls(Window main)
        {
            this.Main = main;
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            (Main as MainWindow).OpacityValue = OpacitySlider.Value;
        }

        private void ShutdownButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void WarmthSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            (Main as MainWindow).WarmthValue = WarmthSlider.Value;
        }

        private void TextOpacityValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                //OpacitySlider.Value = double.Parse(TextOpacityValue.Text);
            } catch (Exception) { }
        }

        private void TextWarmthValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                //WarmthSlider.Value = double.Parse(TextWarmthValue.Text);
            } catch (Exception) { }
        }
    }
}
