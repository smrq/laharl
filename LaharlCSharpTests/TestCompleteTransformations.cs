using System;
using LaharlCSharp;
using LaharlCSharpTestFiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaharlCSharpTests
{
	[TestClass]
	public class TestCompleteTransformations
	{
		private Formatter formatter;

		[TestInitialize]
		public void Initialize()
		{
			formatter = new Formatter();
		}

		[TestMethod]
		public void TestFile1()
		{
			Assert.AreEqual(
				TestFiles.TestFile01_output,
				formatter.Format(TestFiles.TestFile01_input));
		}

		[TestMethod]
		public void TestFile2()
		{
			Assert.AreEqual(
				TestFiles.TestFile02_output,
				formatter.Format(TestFiles.TestFile02_input));
		}
	}
}
