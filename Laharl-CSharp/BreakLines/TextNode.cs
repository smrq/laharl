using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaharlCSharp.BreakLines
{
	internal class TextNode : Node
	{
		internal string Text { get; set; }

		internal override string UnbrokenText
		{
			get { return Text; }
		}
	}
}
