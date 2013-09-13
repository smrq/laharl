using System;
using System.Collections.Generic;
using System.Linq;

namespace LaharlCSharp.BreakLines
{
	static class LineBreaker
	{
		const int IndentSize = 4;

		public static IList<Line> Break(IList<Line> lines)
		{
			int previousLineCount;
			do
			{
				previousLineCount = lines.Count;
				lines = lines.SelectMany(Break).ToList();
			} while (lines.Count != previousLineCount);
			return lines;
		}

		private static int CalculateMaxLineLength(int indentationLevel)
		{
			return 80 + 2 * indentationLevel;
		}
		
		private static IList<Line> Break(Line line)
		{
			var indentation = line.IndentationLevel * IndentSize;
			var maxLineLength = CalculateMaxLineLength(line.IndentationLevel);

			if (line.Node is TextNode || line.Node.UnbrokenLength + indentation <= maxLineLength)
			{
				return new [] { line };
			}

			var breakableNode = (BreakableNode)line.Node;
			return breakableNode
				.Children
				.Select(node =>
					new Line
					{
						Node = node,
						IndentationLevel = line.IndentationLevel + (node.PrecededByTabWhenBroken ? 1 : 0)
					})
				.ToList();
		}
	}
}
