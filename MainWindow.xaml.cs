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

namespace ISRPO_Palashicheva_PR3__3__
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


        private void Pusk_Click(object sender, RoutedEventArgs e)
        {
            //Получение исходных данных из TextBox
            double x = Convert.ToDouble(X.Text);

            //Ввод исходных данных в окно результатов
            Itog.Text = "Результаты работы программы ст. Палашичевой" + Environment.NewLine;
            Itog.Text += "При X = " + X.Text + Environment.NewLine;

            //Определение номера выбранной функции
            int n = 0;
            double f;

            if (menshe.IsChecked == true) n = 1;


            //Вычисление U
            switch (n)
            {
                case 0:
                    if ((x) >= 3)
                    {
                        f = Math.Pow((-x), 2) + 3 * x + 9;

                        Itog.Text += "F = " + Convert.ToString(f) + Environment.NewLine;
                    }
                    else
                    {
                        Itog.Text += "Решение не найдено " + Environment.NewLine;
                    }
                    break;
                case 1:
                    if ((x) < 3)
                    {
                        f = (x) / ((Math.Pow(x, 3)) - 6);
                        Itog.Text += "F = " + Convert.ToString(f) + Environment.NewLine;
                    }
                    else
                    {
                        Itog.Text += "Решение не найдено " + Environment.NewLine;
                    }
                    break;

            }

        }
        private void Clin_Click(object sender, RoutedEventArgs e)
        {
            Itog.Clear();
            X.Clear();
        }
    }
}
