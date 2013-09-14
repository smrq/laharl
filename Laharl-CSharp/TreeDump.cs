using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roslyn.Compilers.CSharp;

namespace LaharlCSharp
{
	public static class TreeDump
	{
		public static void ToConsole(this SyntaxTree tree) 
		{
			var writer = new ConsoleDumpWalker();
			writer.Visit(tree.GetRoot());
		}

		class ConsoleDumpWalker : SyntaxWalker
		{
			private int padding = 0;

			public override void Visit(SyntaxNode node)
			{
				//To identify leaf nodes vs nodes with children
				var prepend = node.ChildNodes().Any() ? "[-]" : "[.]";
				//Get the type of the node
				var line = new String(' ', padding * 4) + prepend +
										" " + node.GetType().ToString();
				//Write the line
				Debug.WriteLine(line);

				padding++;
				base.Visit(node);
				padding--;

				/* collection.Select(x => new ReallyLongClassNameThatShouldBeShorter { FirstGuy = x.LastGuy, SecondGuy = x.FirstGuy ..... } );
				
				collection
					.Where(x => ...)
					.Select(x =>
						new ReallyLongClassNameThatShouldBeShorter
						{
							FirstGuy = x.LastGuy,
							SecondGuy = x.FirstGuy,
							...
						})
					.ToList();
				
				collection.Select(x =>
					new ReallyLongClassNameThatShouldBeShorter {
						FirstGuy...
						...
					}
				);
				
				*/
			}

		}
	}
}
