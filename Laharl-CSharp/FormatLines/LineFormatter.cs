using System;
using System.Collections.Generic;
using System.Text;
using LaharlCSharp.BreakLines;

namespace LaharlCSharp.FormatLines
{
	internal static class LineFormatter
	{
		public static string Format(IList<Line> lines)
		{
			var builder = new StringBuilder();
			foreach (var line in lines)
			{
				builder.Append(new string('\t', line.IndentationLevel));
				builder.AppendLine(line.Node.UnbrokenText);
			}
			return builder.ToString();
		}
	}
}
