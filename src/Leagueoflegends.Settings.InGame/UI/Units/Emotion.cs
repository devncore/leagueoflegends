﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Emotion : Control
    {
        static Emotion()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Emotion), new FrameworkPropertyMetadata(typeof(Emotion)));
        }
    }
}