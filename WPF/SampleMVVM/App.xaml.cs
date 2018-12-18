﻿using System.Collections.Generic;
using System.Windows;
using SampleMVVM.Models;
using SampleMVVM.Views;

namespace SampleMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var books = new List<Book>
            {
                new Book("Колобок", null, 3),
                new Book("CLR via C#", "Джеффри Рихтер", 1),
                new Book("Война и мир", "Л.Н. Толстой", 2)
            };

            var view = new MainView(); // создали View
            var viewModel = new ViewModels.MainViewModel(books); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }
    }
}
