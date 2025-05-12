using Avalonia.Dialogs;
using GIFify.ViewModels.Base;
using ReactiveUI;
using System.Windows.Input;
using Tmds.DBus.Protocol;

namespace GIFify.ViewModels
{
    public class GififyMainWindowViewModel : ViewModelBase
    {
        public string Title { get; init; }

        public ICommand Template { get; }

        public GififyMainWindowViewModel()
        {
            Title = "GIFify";

            Template = ReactiveCommand.Create(() =>
            {
                
            });
        }
    }
}
