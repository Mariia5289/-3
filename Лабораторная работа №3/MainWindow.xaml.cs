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

namespace Лабораторная_работа__3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z;//описание переменных
            string cStr;
            bool result1 = double.TryParse(TextBox.Text, out x);
            if (result1 == false) // если возникла ли ошибка преобразования
            {              // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show("Неверный формат числа " + TextBox.Text + "!");
                return;// заканчиваем работу метода
            }
            bool result2 = double.TryParse(TextBox2.Text, out y);
            if (result2 == false) // если возникла ли ошибка преобразования
            {              // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show("Неверный формат числа " + TextBox2.Text + "!");
                return;// заканчиваем работу метода
            }
            z = (7 * x + 3 * y) * 4.5;
            cStr = z.ToString();
            Label1.Content = cStr;
            return;// заканчиваем работу метода
        }
    }
}
