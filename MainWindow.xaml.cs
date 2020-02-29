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

namespace WpfApplication1
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
        
        int i = 0;
        private void btnExample_Click(object sender, RoutedEventArgs e)
        {
            var tb = new TextBox();
            tb.HorizontalAlignment = HorizontalAlignment.Left;
            tb.VerticalAlignment = VerticalAlignment.Top;
            tb.Width = 100;
            tb.Margin = new Thickness(10, (i++) * 30 + 50, 0, 0);
            tb.TextChanged += textBox_TextChanged;

            gMain.Children.Add(tb);
        }

        private void textBox_TextChanged(object sender, object args)
        {
            lblResult.Content = GetSum();
        }

        public int GetSum()
        {
            int sum = 0;
            foreach(var child in gMain.Children)
            {
                if(child is TextBox)
                {
                    var tb = (TextBox) child;
                    if(!string.IsNullOrEmpty(tb.Text))
                        sum += int.Parse(tb.Text);
                }
            }
            return sum;
        }
    }
}
