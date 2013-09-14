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

			var lines = new List<Line>
			{
				new Line
				{
					IndentationLevel = 0,
					Node = new BreakableNode
					{
						Children = new List<Node>
						{
							new TextNode { Text = "collection" },
							new BreakableNode
							{
								PrecededByTabWhenBroken = true,
								PrecededBySpaceWhenUnbroken = false,
								Children = new List<Node>
								{
									new TextNode { Text = ".Where(x =>" },
									new TextNode { Text = "x.Count > 3)", PrecededByTabWhenBroken = true, PrecededBySpaceWhenUnbroken = true }
								}
							},
							new BreakableNode
							{
								PrecededByTabWhenBroken = true,
								PrecededBySpaceWhenUnbroken = false,
								Children = new List<Node>
								{
									new TextNode { Text = ".Select(thingamabob =>" },
									new TextNode
									{
										Text = "new ReallyLongClassNameThatShouldBeShorter",
										PrecededByTabWhenBroken = true,
										PrecededBySpaceWhenUnbroken = true
									},
									new BreakableNode
									{
										PrecededByTabWhenBroken = true,
										PrecededBySpaceWhenUnbroken = true,
										Children = new List<Node>
										{
											new TextNode { Text = "{" },
											new BreakableNode
											{
												PrecededByTabWhenBroken = true,
												PrecededBySpaceWhenUnbroken = true,
												Children = new List<Node>
												{
													new TextNode { Text = "FirstGuy =" },
													new BreakableNode
													{
														PrecededByTabWhenBroken = true,
														PrecededBySpaceWhenUnbroken = true,
														Children = new List<Node>
														{
															new TextNode { Text = "thingamabob" },
															new TextNode { Text = ".LastGuy,", PrecededByTabWhenBroken = true, PrecededBySpaceWhenUnbroken = false }
														}
													}
												}
											},
											new BreakableNode
											{
												PrecededByTabWhenBroken = true,
												PrecededBySpaceWhenUnbroken = true,
												Children = new List<Node>
												{
													new TextNode { Text = "SecondGuy =" },
													new BreakableNode
													{
														PrecededByTabWhenBroken = true,
														PrecededBySpaceWhenUnbroken = true,
														Children = new List<Node>
														{
															new TextNode { Text = "thingamabob" },
															new TextNode { Text = ".FirstGuy", PrecededByTabWhenBroken = true, PrecededBySpaceWhenUnbroken = false }
														}
													}
												}
											},
											new TextNode { PrecededByTabWhenBroken = false, PrecededBySpaceWhenUnbroken = true, Text = "})" }
										}
									}
								}
							},
							new TextNode { PrecededByTabWhenBroken = true, PrecededBySpaceWhenUnbroken = false, Text = ".ToList();" }
						}
					}
				}
			};
			return lines;
		}
	}
}
