using GP.Opgavesaet4.ViewModel.BaseClasses;
using GP.Opgavesaet4.ViewModel.Helpers;

namespace GP.Opgavesaet4.ViewModel.ViewModels
{
    public class Opgave41UserControlViewModel : NotifyBase
    {
        private readonly Coin _coin = new Coin();

        public Opgave41UserControlViewModel()
        {
            ThrowCoinCommand = new DelegateCommand(ThrowCoin);
        }

        public DelegateCommand ThrowCoinCommand { get; }
        public void ThrowCoin()
        {
            LastCoinResult = _coin.Throw();
        }

        public string LastCoinResult
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }
    }
}