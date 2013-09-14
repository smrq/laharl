using System;
using System.Collections.Generic;
using System.Linq;
using LaharlCSharp.BreakLines;

namespace LaharlCSharp.BuildLines
{
	internal class NodeBuilder
	{
		private int indentationLevel = 0;

		private readonly IList<Line> lines = new List<Line>();

		internal IList<Line> Lines
		{
			get { return lines.ToList(); }
		}

		internal void AppendLine(string str)
		{
			lines.Add(new Line
			{
				IndentationLevel = indentationLevel,
				Node = new TextNode
				{
					Text = str
				}
			});
		}

		internal void IncreaseIndent()
		{
			indentationLevel++;
		}

		internal void DecreaseIndent()
		{
			indentationLevel--;
		}
	}
}
