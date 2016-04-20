using System;
using GP.Opgavesaet4.ViewModel;

namespace GP.Opgavesaet4.View.ViewHelpers
{
    public class ViewModelLocator
    {
        private readonly Lazy<MainWindowViewModel> _mainWindowViewModel = new Lazy<MainWindowViewModel>();
        public MainWindowViewModel MainWindowViewModel => _mainWindowViewModel.Value;
    }
}
