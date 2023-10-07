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
using WpfApp1.UserElements;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] TextData = new string[] { "Text1", "Text2", "Text3" };
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < TextData.Length; i++)
            {
                UserControl1 userControl = new UserControl1();
                userControl.Text = TextData[i]; // Установите Text свойство вашего пользовательского элемента

                // Добавьте UserControl1 в контейнер UserControl (или другой контейнер по вашему выбору)
                // Например, если у вас есть StackPanel в UserControl с именем "stackPanel":
                stackPanel.Children.Add(userControl);
            }
        }
    }
}
