using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaharlCSharp.BreakLines
{
	internal class BreakableNode : Node
	{
		internal IList<Node> Children { get; set; }

		internal override string UnbrokenText
		{
			get
			{
				var builder = new StringBuilder();
				foreach (var node in Children)
				{
					if (node.PrecededBySpaceWhenUnbroken)
						builder.Append(" ");
					builder.Append(node.UnbrokenText);
				}
				return builder.ToString();
			}
		}
	}
}
