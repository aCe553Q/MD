using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using StopwatchApp.ViewModels;

namespace StopwatchApp
{
    public partial class MainWindow : Window
    {
        private ViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            DataContext = viewModel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.StartCommand.Execute(null);
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.StopCommand.Execute(null);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ResetCommand.Execute(null);
        }
    }
}
