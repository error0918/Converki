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

namespace Converki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dictionary<string, Dictionary<string, float>> converter = new Dictionary<string, Dictionary<string, float>>();

        public MainWindow()
        {
            InitializeComponent();

            Dictionary<string, float> dimensionConverter = new Dictionary<string, float>();
            dimensionConverter.Add("mm", 1);
            dimensionConverter.Add("cm", 10);
            dimensionConverter.Add("m", 10000);
            dimensionConverter.Add("km", 10000000);
            dimensionConverter.Add("inch(es)", 3.93701f);
            converter.Add("넓이", dimensionConverter);

            Dictionary<string, float> storageConverter = new Dictionary<string, float>();
            dimensionConverter.Add("KB", 1);
            dimensionConverter.Add("MB", 1024);
            dimensionConverter.Add("GB", 1024 * 1024);
            dimensionConverter.Add("TB", 1024 * 1024 * 1024);
            converter.Add("용량", storageConverter);

            Dictionary<string, float> timeConverter = new Dictionary<string, float>();
            dimensionConverter.Add("초", 1);
            dimensionConverter.Add("분", 60);
            dimensionConverter.Add("시", 60 * 60);
            dimensionConverter.Add("일", 60 * 60 * 24);
            converter.Add("시간", timeConverter);

            DataContext = this;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
