using System;
using System.Collections.Generic;
using System.Linq;
using LaharlCSharp.BreakLines;
using Roslyn.Compilers.CSharp;

namespace LaharlCSharp.BuildLines
{
	internal static class LineBuilder
	{
		internal static IList<Line> Build(string input)
		{
			var tree = SyntaxTree.ParseText(input);
			var root = tree.GetRoot();

			var builder = new NodeBuilder();
			var walker = new NodeBuildingWalker(builder);
			walker.Visit(root);

			return builder.Lines;
		}
	}
}
