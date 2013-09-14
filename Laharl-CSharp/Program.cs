using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaharlCSharpTestFiles;
using Roslyn.Compilers.CSharp;

namespace LaharlCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			var formatter = new Formatter();
			var result = formatter.Format(TestFiles.TestFile01_input);
			Debug.WriteLine(result);
		}
	}
}
