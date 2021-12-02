#region Usings
using System;
#endregion

namespace Abbyy.Vantage.Utils
{
	/// <summary>
	/// Represents a helper class for linked list manipulations.
	/// It's not finished yet, you are always welcome to send pull requests to vantage team.
	/// </summary>
	public class LinkedListHelper
	{
		#region Class utility methods
		/// <summary>
		/// Reverses a linked list.
		/// </summary>
		/// <param name="node">Head of a linked list to be reversed.</param>
		/// <returns>Head of a reversed linked list.</returns>
		public static ListNode Reverse( ListNode head ) 
		{
			if( null == head || head.Next == null )
				return head;

			ListNode prev = null;
			ListNode cur = head;

			while( null != cur ) 
			{
				var next = cur.Next;
				cur.Next = prev;
				prev = cur;

				cur = next;
			}

			return prev;
		}
		/// <summary>
		/// Gets the middle node of a a linked list.
		/// </summary>
		/// <param name="node">Head of a linked list to be searched.</param>
		/// <returns>Middle node.</returns>
		public static ListNode GetMiddle( ListNode node ) 
		{
			throw new NotImplementedException( "Sorry vantage team is too busy :(" );
		}
		#endregion
	}
}
