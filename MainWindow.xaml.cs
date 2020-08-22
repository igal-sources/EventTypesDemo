using EventTypesDemo.ViewModels;
using System.Windows;

namespace EventTypesDemo
{
    public partial class MainWindow : Window
    {
        private EventTypesViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new EventTypesViewModel();
            DataContext = _viewModel;
        }
    }
}
