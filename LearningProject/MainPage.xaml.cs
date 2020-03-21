using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace LearningProject
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int i = 0;
        public MainPage()
        {
            this.InitializeComponent();
            Button button1 = new Button();
            button1.Content = "Нажми меня ,крошка!";
            button1.Width = 200;
            button1.Height = 40;
            button1.HorizontalAlignment = HorizontalAlignment.Center;
            button1.Click += button_Click;
            layoutGrid.Children.Add(button1);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            i++;
            Button button = sender as Button;
            button.Content = $"О да! {i}";
        }
    }

    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Смартфон {this.Name}; цена: {this.Price}";
        }
    }
}
