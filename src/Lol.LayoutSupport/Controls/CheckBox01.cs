﻿using Lol.Controls.Primitives;
using System.Windows;

namespace Lol.LayoutSupport.Controls
{
	public class CheckBox01 : RiotCheckBox
	{
		#region DefaultStyleKey

		static CheckBox01()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(CheckBox01), new FrameworkPropertyMetadata(typeof(CheckBox01)));
		}
		#endregion
	}
}
