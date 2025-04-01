using GIFify.ViewModels.Base;

namespace GIFify.ViewModels
{
    public class GififyMainWindowViewModel : ViewModelBase
    {
        public string Title { get; init; }

        public GififyMainWindowViewModel()
        {
            Title = "GIFify";
        }
    }
}
