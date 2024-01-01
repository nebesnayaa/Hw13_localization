﻿using System;
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

namespace HW13_localization_languages
{
    public partial class MainWindow : Window
    {
        string Language { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Language = "en";
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
        }

        private void ChangeLanguageButton_Click(object sender, RoutedEventArgs e)
        {
            if (Language == "en")
            {
                ResourceDictionary newDictionary = new ResourceDictionary();
                newDictionary.Source = new Uri("Resources/Dictionary_ua.xaml", UriKind.Relative);
                Application.Current.Resources.MergedDictionaries[0] = newDictionary;
                Language = "ua";
            }
            else if (Language == "ua")
            {
                ResourceDictionary newDictionary = new ResourceDictionary();
                newDictionary.Source = new Uri("Resources/Dictionary_en.xaml", UriKind.Relative);
                Application.Current.Resources.MergedDictionaries[0] = newDictionary;
                Language = "en";
            }
        }
    }
}