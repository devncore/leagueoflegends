﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Settings.InGame.UI.Units
{
	public class Graphic : Control
    {
        #region DefaultStyleKey

        static Graphic()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Graphic), new FrameworkPropertyMetadata(typeof(Graphic)));
        }
        #endregion
    }
}
