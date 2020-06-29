﻿using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace TPS.WPF.ModernWPF.Animation
{
    /// <summary>
    ///     Provides parameter info for the Frame.Navigate method. Controls how the transition
    ///     animation runs during the navigation action.
    /// </summary>
    public class Transition : DependencyObject
    {
        internal static readonly TimeSpan ExitDuration = TimeSpan.FromMilliseconds(150);
        internal static readonly TimeSpan EnterDuration = TimeSpan.FromMilliseconds(300);
        internal static readonly TimeSpan MaxMoveDuration = TimeSpan.FromMilliseconds(500);
        internal static readonly KeySpline AccelerateKeySpline;
        internal static readonly KeySpline DecelerateKeySpline;
        internal static readonly PropertyPath OpacityPath = new PropertyPath(UIElement.OpacityProperty);

        internal static readonly PropertyPath TranslateXPath =
            new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.X)");

        internal static readonly PropertyPath TranslateYPath =
            new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.Y)");

        internal static readonly PropertyPath ScaleXPath =
            new PropertyPath("(UIElement.RenderTransform).(ScaleTransform.ScaleX)");

        internal static readonly PropertyPath ScaleYPath =
            new PropertyPath("(UIElement.RenderTransform).(ScaleTransform.ScaleY)");

        static Transition()
        {
            AccelerateKeySpline = new KeySpline(0.7, 0, 1, 0.5);
            AccelerateKeySpline.Freeze();

            DecelerateKeySpline = new KeySpline(0.1, 0.9, 0.2, 1);
            DecelerateKeySpline.Freeze();
        }

        /// <summary>
        ///     Initializes a new instance of the Transition class.
        /// </summary>
        protected Transition() { }

        //protected virtual string GetNavigationStateCore();
        //protected virtual void SetNavigationStateCore(string navigationState);

        protected virtual Animation GetEnterAnimation(FrameworkElement element, bool movingBackwards) => null;

        protected virtual Animation GetExitAnimation(FrameworkElement element, bool movingBackwards) => null;

        public Animation GetEnterAnimation(object element, bool movingBackwards) => GetEnterAnimation(
            (FrameworkElement) element, movingBackwards);

        public Animation GetExitAnimation(object element, bool movingBackwards) => GetExitAnimation(
            (FrameworkElement) element, movingBackwards);
    }
}