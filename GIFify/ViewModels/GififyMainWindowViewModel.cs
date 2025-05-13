using Avalonia.Dialogs;
using GIFify.ViewModels.Base;
using ReactiveUI;
using System.Windows.Input;

namespace GIFify.ViewModels
{
    public class GififyMainWindowViewModel : ViewModelBase
    {
        private string _templateButtonContent;
        
        public string Title { get; init; }
        public ICommand TemplateButtonCommand { get; }

        public string TemplateButtonContent
        {
            get => _templateButtonContent;
            private set => this.RaiseAndSetIfChanged(ref _templateButtonContent, value);
        }

        public GififyMainWindowViewModel()
        {
            Title = "GIFify";
            TemplateButtonContent = "Template";

            TemplateButtonCommand = ReactiveCommand.Create(() =>
            {
                TemplateButtonContent = "New Template";;
            });
        }
    }
}
