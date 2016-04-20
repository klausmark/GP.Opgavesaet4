using GP.Opgavesaet4.ViewModel.BaseClasses;

namespace GP.Opgavesaet4.ViewModel.ViewModels
{
    public class Opgave43UserControlViewModel : NotifyBase
    {
        private readonly Dice _dice = new Dice();
        public int NumberOfThrows
        {
            get { return GetField<int>(); }
            set
            {
                SetField(value);
                ThrowDice();
            }
        }

        private void ThrowDice()
        {
            Throws = _dice.ThrowTimes(NumberOfThrows);
        }

        public int[] Throws
        {
            get { return GetField<int[]>(); }
            set { SetField(value); }
        }

    }
}