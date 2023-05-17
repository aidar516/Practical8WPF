using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using SerializeAndDeserialize;

namespace Practical8WPF
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"/ThemeLib/Themes/BlackTheme.xaml", UriKind.Relative);
            ResourceDictionary? resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(@"/ThemeLib/Themes/WhiteTheme.xaml", UriKind.Relative);
            ResourceDictionary? resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }

        private async void SaveData_Click(object sender, RoutedEventArgs e)
        {
            var person = new Person
            {
                Name = "Виктор",
                Surname = "Петров",
                Age = 50
            };

            Class1.SerializeData(person, "person.json");
            MessageBox.Show("Сериализация выполнена успешно!");
        }

        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            var deserializedPerson = Class1.DeserializeData<Person>("person.json");
            MessageBox.Show($"Имя: {deserializedPerson.Name}\nФамилия: {deserializedPerson.Surname} \nВозраст: {deserializedPerson.Age}");
        }
    }
}
