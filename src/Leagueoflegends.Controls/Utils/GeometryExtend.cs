﻿using System.Windows.Media;

namespace Leagueoflegends.Controls.Utils
{
	public static class GeometryExtend
    {
        #region ToGeometry

        public static Geometry ToGeometry(this string geometryString)
        {
            return Geometry.Parse(geometryString);
        }
        #endregion
    }
}