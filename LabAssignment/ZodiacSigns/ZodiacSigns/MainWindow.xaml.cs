using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZodiacSigns
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

        private DateTime? selectedDate;
        public string checkDate(int dayNum, int monthNum)
        {
            if(dayNum >= 21 && monthNum == 3 || dayNum<=19 && monthNum==4)
            {
                return "Aries";
            }

            if ( dayNum >= 20 && monthNum == 4 || dayNum <= 20 && monthNum == 5)
            {
                return "Taurus";
            }

            if (dayNum >= 21 && monthNum == 5 || dayNum <= 20 && monthNum == 6)
            {
                return "Gemini";
            }

            if (dayNum >= 21 && monthNum == 6 || dayNum <= 22 && monthNum == 7)
            {
                return "Cancer";
            }

            if (dayNum >= 23 && monthNum == 7 || dayNum <= 22 && monthNum == 8)
            {
                return "Leo";
            }

            if (dayNum >= 23 && monthNum == 8 || dayNum <= 22 && monthNum == 9)
            {
                return "Virgo";
            }

            if (dayNum >= 23 && monthNum == 9 || dayNum <= 22 && monthNum == 10)
            {
                return "Libra";
            }

            if (dayNum >= 23 && monthNum == 10 || dayNum <= 21 && monthNum == 11)
            {
                return "Scorpio";
            }

            if (dayNum >= 22 && monthNum == 11 || dayNum <= 21 && monthNum == 12)
            {
                return "Sagittarius";
            }

            if (dayNum >= 22 && monthNum == 12 || dayNum <= 19 && monthNum == 1)
            {
                return "Capricorn";
            }

            if (dayNum >= 20 && monthNum == 1 || dayNum <= 18 && monthNum == 2)
            {
                return "Aquarius";
            }

            if (dayNum >= 19 && monthNum == 2 || dayNum <= 20 && monthNum == 3)
            {
                return "Pisces";
            }

            return "Unknown";
        }
        private void Submit(object sender, RoutedEventArgs e)
        {
            selectedDate = birthdate.SelectedDate;

            if (selectedDate.HasValue)
            {
                ChangeContent();
            }
        }

        private void GetDetails(object sender, RoutedEventArgs e)
        {
            if (selectedDate.HasValue)
            {
                Tab2.IsSelected = true;
            }
            
        }

        private void DisplayDetail(object sender, RoutedEventArgs e)
        {
            string sign = e.Source.ToString().Remove(0, 32);
            string detail = System.IO.File.ReadAllText(@"C:\Users\Nati\Desktop\C# projects\LabAssignment\ZodiacSigns\ZodiacSigns\textFiles\details\" + sign + ".txt");

            Details.Text = detail;
            SignName.Content = sign;
            SignImg.Source = new BitmapImage(new Uri(@"C:\Users\Nati\Desktop\C# projects\LabAssignment\ZodiacSigns\ZodiacSigns\img\" + sign + ".jpg"));

        }

        void ChangeContent()
        {
            if (selectedDate != null)
            {
                int day = selectedDate.Value.Day;
                int month = selectedDate.Value.Month;

                string sign = checkDate(day, month);

                string info = System.IO.File.ReadAllText(@"C:\Users\Nati\Desktop\C# projects\LabAssignment\ZodiacSigns\ZodiacSigns\textFiles\info\" + sign + ".txt");
                string detail = System.IO.File.ReadAllText(@"C:\Users\Nati\Desktop\C# projects\LabAssignment\ZodiacSigns\ZodiacSigns\textFiles\details\" + sign + ".txt");

                Info.Content = info;
                Details.Text = detail;
                SignName.Content = sign;
                SignImg.Source = new BitmapImage(new Uri(@"C:\Users\Nati\Desktop\C# projects\LabAssignment\ZodiacSigns\ZodiacSigns\img\" + sign + ".jpg"));
            }
        }
    }
}
