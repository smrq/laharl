using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roslyn.Compilers.CSharp;

namespace LaharlCSharp
{
	public class Formatter
	{
		public string Format(string input)
		{
			return input;
		}

		public void ParseFile()
		{
			var tree = SyntaxTree.ParseText(
				@"using System;
				using System.Collections;
				using System.Linq;
				using System.Text;
 
				namespace HelloWorld
				{
					class Program
					{
						static void Main(string[] args)
						{
							Console.WriteLine(""Hello, World!"");
							int integer = 6;
							methodCall(v, b, n, g, f, d, c, y, i, q, w, s, d);
						}
					}
				}");
			var root = tree.GetRoot();
			var namespaceDeclaration = (NamespaceDeclarationSyntax)root.Members.First();
			var classDeclaration = (ClassDeclarationSyntax)namespaceDeclaration.Members.First();
			var methodDeclarations = classDeclaration.Members.Cast<MethodDeclarationSyntax>();
		}
	}
}
