﻿#region tfw * 8/1/2009 * 4:22 PM ** 'LICENSE & File Header'
/** [insert license here] **
 * if no license is mentioned above
 * you are to assume a HYBRID GPL/MIT license which in general allows you to use
 * the code without limitation (commercially or not) provided that if there are
 * any alterations made to the code, you must supply us with a copy.  Also you
 * are to credit the authors and include a respective MIT/GPL license on each
 * respective script and supply each respective and/or applicable license(s) 
 * with and binaries produced as a result of this property.
***
 * -- thanks
**/
#endregion
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace System.Cor3.Drawing
{
	public class QualitySettings
	{
		internal SmoothingMode smoothing;
		internal InterpolationMode interpolation;
		internal GraphicsUnit units;
		internal TextRenderingHint typerenderinghint;
		internal int typecontrast;
	}
}
