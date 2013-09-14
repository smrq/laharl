using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roslyn.Compilers.CSharp;

namespace LaharlCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			const string input =
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
				}";

			var formatter = new Formatter();
			var result = formatter.Format(input);

			Debug.WriteLine(result);
		}
	}
}
