using System.Windows.Controls;
using TPS.WPF.ModernWPF.Animation;
using TPS.WPF.ViewModels;

namespace TPS.WPF.ModernWPF
{
    public class AnimatedContentControl : ContentControl
    {
        private static Transition Transition => SettingsPageViewModel.Transition.Object;

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            if (oldContent != null)
            {
                var exit = Transition.GetExitAnimation(oldContent,
                    false);
                exit.Begin();
            }

            if (newContent != null)
            {
                var enter =
                    Transition.GetEnterAnimation(newContent, false);
                enter.Begin();
            }
            else
            {
                base.OnContentChanged(oldContent, newContent);
            }
        }
    }
}