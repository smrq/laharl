using System;
using LaharlCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaharlCSharpTests
{
	[TestClass]
	public class TestCompleteTransformations
	{
		[TestMethod]
		public void TestFile1()
		{
			var formatter = new Formatter();
			var output = formatter.Format(TestFiles.TestFile01_input);
			Assert.AreEqual(TestFiles.TestFile01_output, output);
		}
	}
}
