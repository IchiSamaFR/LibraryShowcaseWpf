using LibraryShowcaseWpf.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace LibraryShowcaseWpf.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour PathFinderView.xaml
    /// </summary>
    public partial class PathFinderPage : INavigableView<PathFinderVM>
    {
        public PathFinderVM ViewModel { get; }

        public PathFinderPage(PathFinderVM viewModel)
        {
            ViewModel = viewModel;
            DataContext = ViewModel;

            InitializeComponent();
        }
    }
}
