﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Strength : Control
    {
        #region DefaultStyleKey

        static Strength()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Strength), new FrameworkPropertyMetadata(typeof(Strength)));
        }
		#endregion
	}
}
