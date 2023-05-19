using System.IO;
using System.Windows;
using SerializeAndDeserialize;

namespace Practical8WPF
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void SaveData_Click(object sender, RoutedEventArgs e)
        {
            var data = new { Text = TB.Text };

            Class1.SerializeData(data, "data.json");

            MessageBox.Show("Текст сохранен в файле data.json");
        }

        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("data.json"))
            {
                var data = Class1.DeserializeData<dynamic>("data.json");
                TB2.Text = data.Text;
            }
            else
            {
                MessageBox.Show("Файл data.json не найден");
            }

        }
    }
}
