using System;
using GP.Opgavesaet4.ViewModel.BaseClasses;

namespace GP.Opgavesaet4.ViewModel.ViewModels
{
    public class FrontPageUserControlViewModel : NotifyBase
    {
        public string Tekst { get; } = $"Mine løsninger på Opgavesæt4 dog uden 4.4 grundet mangel på tid.{Environment.NewLine}Jeg håber det faktum at jeg har lavet dem rigtig godt opvejer manglen på 4.4";
    }
}