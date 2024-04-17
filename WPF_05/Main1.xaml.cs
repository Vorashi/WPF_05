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

namespace WPF_05
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Main1 : Window
    {
        public Main1()
        {
            InitializeComponent();
        }

        public void SetColor(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                switch (element.Name)
                {
                    case "itemRed": case "ButtonRed":
                        if (stateInfo.Text.Length != 21) stateInfo.Text = "Пользователь выбрал: ";
                        stateInfo.Text += "Color Red";
                        Window.Background = Brushes.Red;
                        break;
                    case "itemBlue": case "ButtonBlue":
                        if (stateInfo.Text.Length != 21) stateInfo.Text = "Пользователь выбрал: ";
                        stateInfo.Text += "Color Blue";
                        Window.Background = Brushes.Blue;
                        break;
                    case "itemGreen": case "ButtonGreen":
                        if (stateInfo.Text.Length != 21) stateInfo.Text = "Пользователь выбрал: ";
                        stateInfo.Text += "Color Green";
                        Window.Background = Brushes.Green;
                        break;
                } 
            }
        }

        public void GetDeveloperInfo(object sender, RoutedEventArgs e) 
        {
            MessageBox.Show("Developer - Шаров Матвей Михайлович", "Информация", MessageBoxButton.OK, MessageBoxImage.Information) ;
        }

        public void MenuColorRed(object sender, RoutedEventArgs e) 
        {
            SetColor(sender, e);
        }

        public void MenuColorBlue(object sender, RoutedEventArgs e)
        {
            SetColor(sender, e);
        }

        public void MenuColorGreen(object sender, RoutedEventArgs e)
        {
            SetColor(sender, e);
        }

        public void GetInforation(object sender, RoutedEventArgs e) 
        {
            if (objectInfo.Text.Length != 23) objectInfo.Text = "Вы навелись на объект: ";
            if (sender is FrameworkElement element) objectInfo.Text += element.Name;
        }

        private void Element_MouseEnter(object sender, MouseEventArgs e)
        {
            GetInforation(sender, e);
        }

        public void Menu_Close(object sender, RoutedEventArgs e) 
        {
            Close();
        }
    }
}
