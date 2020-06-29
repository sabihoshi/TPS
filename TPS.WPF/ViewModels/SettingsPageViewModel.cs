using System.Collections.Generic;
using System.Linq;
using Stylet;
using TPS.WPF.ModernWPF;
using TPS.WPF.ModernWPF.Animation;

namespace TPS.WPF.ViewModels
{
    public class SettingsPageViewModel : Screen
    {
        public static IEnumerable<CaptionedObject<Transition>> Transitions { get; } = new TransitionCollection();

        public static CaptionedObject<Transition> Transition { get; set; } = Transitions.First();
    }
}