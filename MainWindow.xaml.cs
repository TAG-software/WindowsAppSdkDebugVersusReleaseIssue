using DebugVersusReleaseIssue.ViewModels;
using DebugVersusReleaseIssue.Views;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DebugVersusReleaseIssue
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            Activated += MainWindow_Activated;
        }

        private void MainWindow_Activated(object sender, WindowActivatedEventArgs args)
        {
            //var content = new MainWindowView();
            //content.DataContext = new MainWindowViewModel();

            //Content = content;
        }
    }
}
