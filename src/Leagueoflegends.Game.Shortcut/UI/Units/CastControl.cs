﻿using System.Windows;
using System.Windows.Controls;

namespace Leagueoflegends.Game.Shortcut.UI.Units
{
	public class CastControl : Control
    {
        static CastControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CastControl), new FrameworkPropertyMetadata(typeof(CastControl)));
        }
    }
}
