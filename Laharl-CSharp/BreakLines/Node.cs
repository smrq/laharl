using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaharlCSharp.BreakLines
{
	internal abstract class Node
	{
		internal bool PrecededByTabWhenBroken { get; set; }

		internal bool PrecededBySpaceWhenUnbroken { get; set; }
		
		internal abstract string UnbrokenText { get; }

		internal int UnbrokenLength { get { return UnbrokenText.Length; } }
	}
}
