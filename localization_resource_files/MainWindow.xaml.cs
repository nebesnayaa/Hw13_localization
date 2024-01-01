using System.Globalization;
using System.Threading;
using System.Windows;

namespace HW13_localization2
{
    public partial class MainWindow : Window
    {
        string Language { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Language = "en";
        }

        private void UpdateUI()
        {
            mainWindow.Title = lang.windowTitle;
            firstNameLabel.Content = lang.firstNameLabel;
            lastNameLabel.Content = lang.lastNameLabel;
            phoneNumberLabel.Content = lang.phoneNumberLabel;
            okButton.Content = lang.okButton;
            cancelButton.Content = lang.cancelButton;
            changeLanguageButton.Content = lang.changeLanguageButton;
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
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ua");
                UpdateUI();
                Language = "ua";
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                UpdateUI();
                Language = "en";
            }
        }
    }
}
