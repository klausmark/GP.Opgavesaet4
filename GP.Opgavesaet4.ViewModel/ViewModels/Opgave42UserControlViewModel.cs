using GP.Opgavesaet4.ViewModel.BaseClasses;
using GP.Opgavesaet4.ViewModel.Helpers;

namespace GP.Opgavesaet4.ViewModel.ViewModels
{
    public class Opgave42UserControlViewModel : NotifyBase
    {
        private readonly Dice _dice = new Dice();

        public Opgave42UserControlViewModel()
        {
            ThrowDiceCommand = new DelegateCommand(ThrowDice);
        }

        public DelegateCommand ThrowDiceCommand { get; }
        public void ThrowDice()
        {
            _dice.Throw();
            LastDiceResult = _dice.show();
        }

        public int LastDiceResult
        {
            get { return GetField<int>(); }
            set { SetField(value); }
        }
    }
}