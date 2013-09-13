using System;
using System.Collections.Generic;
using System.Linq;
using LaharlCSharp.BreakLines;
using LaharlCSharp.FormatLines;
using Roslyn.Compilers.CSharp;

namespace LaharlCSharp
{
	public class Formatter
	{
		public string Format(string input)
		{
			var tree = SyntaxTree.ParseText(input);
			var root = tree.GetRoot();
			var lines = PretendToDoFirstPass(root);
			var brokenLines = LineBreaker.Break(lines);
			var formattedLines = LineFormatter.Format(brokenLines);
			return formattedLines;
		}

		private List<Line> PretendToDoFirstPass(CompilationUnitSyntax root)
		{
			/*
			var namespaceDeclaration = (NamespaceDeclarationSyntax)root.Members.First();
			var classDeclaration = (ClassDeclarationSyntax)namespaceDeclaration.Members.First();
			var methodDeclarations = classDeclaration.Members.Cast<MethodDeclarationSyntax>();
			*/
			return new List<Line>();
		}
	}
}
