using System;
using GP.Opgavesaet4.ViewModel.ViewModels;

namespace GP.Opgavesaet4.View.ViewHelpers
{
    public class ViewModelLocator
    {
        private readonly Lazy<MainWindowViewModel> _mainWindowViewModel = new Lazy<MainWindowViewModel>();
        public MainWindowViewModel MainWindowViewModel => _mainWindowViewModel.Value;

        private readonly Lazy<FrontPageUserControlViewModel> _frontPageUserControlViewModel = new Lazy<FrontPageUserControlViewModel>();
        public FrontPageUserControlViewModel FrontPageUserControlViewModel => _frontPageUserControlViewModel.Value;

        private readonly Lazy<Opgave41UserControlViewModel> _opgave41UserControlViewModel = new Lazy<Opgave41UserControlViewModel>();
        public Opgave41UserControlViewModel Opgave41UserControlViewModel => _opgave41UserControlViewModel.Value;

        private readonly Lazy<Opgave42UserControlViewModel> _opgave42UserControlViewModel = new Lazy<Opgave42UserControlViewModel>();
        public Opgave42UserControlViewModel Opgave42UserControlViewModel => _opgave42UserControlViewModel.Value;

        private readonly Lazy<Opgave43UserControlViewModel> _opgave43UserControlViewModel = new Lazy<Opgave43UserControlViewModel>();
        public Opgave43UserControlViewModel Opgave43UserControlViewModel => _opgave43UserControlViewModel.Value;

        private readonly Lazy<Opgave44UserControlViewModel> _opgave44UserControlViewModel = new Lazy<Opgave44UserControlViewModel>();
        public Opgave44UserControlViewModel Opgave44UserControlViewModel => _opgave44UserControlViewModel.Value;
    }
}
