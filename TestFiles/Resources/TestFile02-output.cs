using System;
using System.Linq;

namespace TestFile
{
	public class TestClass02
	{
		public System.Collections.Generic.IList<System.Collections.Generic.IList<string>> MakeDeepCollection(
			System.Collections.Generic.IList<string> firstElementInDeepCollection,
			System.Collections.Generic.IList<string> secondElementInDeepCollection,
			System.Collections.Generic.IList<string> thirdElementInDeepCollection)
		{
			return new System.Collections.Generic.List<System.Collections.Generic.IList<string>>
			{
				firstElementInDeepCollection,
				secondElementInDeepCollection,
				thirdElementInDeepCollection
			};
		} 
	}
}
