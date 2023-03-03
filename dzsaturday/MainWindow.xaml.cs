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

namespace dzsaturday
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_do_Click(object sender, RoutedEventArgs e)
        {
            if (rb_1.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: сентябрь 2015. Экран 4.7'. CPU 2x Twister 1.85 GHz. Задняя камера 12 Мп.");
            }
            else if (rb_2.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: сентябрь 2014. Экран 5.5'. CPU 2x Cyclone v2 1,4 GHz. Задняя камера 12 Мп.");
            }
            else if (rb_3.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: сентябрь 2022. Экран 6.1'. CPU 2x3.23 GHz Firestorm + 4x1.8GHz Icestorm. Двойная задняя камера: Стандартная 12 Мп, Широкоугольная 12 Мп.");
            }
            else if (rb_4.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: сентябрь 2022. Экран 6.1' CPU 2x3.46 GHz + 4xCores. Тройная задняя камера: Стандартная 48 Мп, Широкоугольная 12 Мп, Телеобъектив 12 Мп.");
            }
            else if (rb_5.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: октябрь 2022. Экран 6.3'. CPU 2x2.85GHz Cortex•A78 + 2x2.35GHz Cortex•A76 + 4x1.80GHz Cortex•A55. Двойная задняя камера: Стандартная 50 Мп, Широкоугольная 12 Мп.");
            }
            else if (rb_6.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: октябрь 2022. Экран 6.7'. CPU 2x2.85GHz Cortex•A78 + 2x2.35GHz Cortex•A76 + 4x1.80GHz Cortex•A55. Тройная задняя камера: Стандартная 50 Мп, Широкоугольная 12 Мп, Телеобъектив 48 Мп.");
            }
            else if (rb_7.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: октябрь 2021. Экран 6.4'. CPU 2x2.8GHz Cortex•A78 + 2x2.25GHz Cortex•A76 + 4x1.80GHz Cortex•A55. Двойная задняя камера: Стандартная 50 Мп, Широкоугольная 12 Мп.");
            }
            else if (rb_8.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: февраль 2020. Экран 6.9'. CPU 2x Exynos M5 2.73 GHz + 2x Cortex•A76 2.5 GHz + 4x Cortex•A55 2.0 GHz. Quad камера заднего вида: Стандартная 108 Мп, Телеобъектив 48 Мп, Широкоугольная 12 Мп, ToF сенсор 0.5 Мп.");
            }
            else if (rb_9.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: август 2022. Экран 6.2'. CPU 1x3.2 GHz Cortex•X2 +3x2.8 GHz Cortex•A710 + 4x2.0 GHz Cortex•A510. Тройная задняя камера: Стандартная 50 Мп, Широкоугольная 13 Мп, Телеобъектив 10 Мп.");
            } 
            else if (rb_10.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: июнь 2021. Экран 6.6'. CPU 4x Cortex•A76 2.2 GHz + 4x Cortex•A55 2.0 GHz. Тройная задняя камера: Стандартная 48 Мп, Широкоугольная 5 Мп, Портретный режим 5 Мп.");
            } 
            else if (rb_11.IsChecked.Value == true)
            {
                MessageBox.Show("Дата выхода: декабрь 2020. Экран 6.81'. CPU 1x Cortex X1 2.84GHz + 3x Cortex A78 2.42GHz + 4x Cortex A55 1.8GHz. Тройная задняя камера: Стандартная 108 Мп, Широкоугольная 13 Мп, Макро объектив 5 Мп.");
            } 
            
        }

        
    }
}
