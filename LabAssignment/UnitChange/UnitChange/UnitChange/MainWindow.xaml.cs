using System;
using System.Windows;

namespace UnitChange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float x = 0;
                if (!float.TryParse(value.Text, out x))
                {
                    throw new Exception("Invalid Input");
                }

                if (from.SelectedIndex == to.SelectedIndex)
                {
                    result.Text = x.ToString();
                } else if (from.SelectedIndex == 0 && to.SelectedIndex == 1)
                {
                    result.Text = MeterToInch(x).ToString();
                } else if (from.SelectedIndex == 0 && to.SelectedIndex == 2)
                {
                    result.Text = MeterToMile(x).ToString();
                } else if (from.SelectedIndex == 1 && to.SelectedIndex == 0)
                {
                    result.Text = InchToMeter(x).ToString();
                } else if (from.SelectedIndex == 1 && to.SelectedIndex == 2)
                {
                    result.Text = InchToMile(x).ToString();
                } else if (from.SelectedIndex == 2 && to.SelectedIndex == 0)
                {
                    result.Text = MileToMeter(x).ToString();
                } else if (from.SelectedIndex == 2 && to.SelectedIndex == 1)
                {
                    result.Text = MileToInch(x).ToString();
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private float MeterToInch(float number)
        {
            return number * 39.3701f;
        }
        private float InchToMeter(float number)
        {
            return number * 1000f;
        }
        private float MeterToMile(float number)
        {
            return number / 1609.344f;
        }
        private float MileToMeter(float number)
        {
            return number * 1609.344f;
        }
        private float InchToMile(float number)
        {
            return number / 1.57828e-5f;
        }
        private float MileToInch(float number)
        {
            return number * 63360f;
        }
    }
}