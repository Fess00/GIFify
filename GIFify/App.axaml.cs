using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using GIFify.ViewModels;
using GIFify.Views;

namespace GIFify
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new GififyMainWindow
                {
                    DataContext = new GififyMainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }

    }
}