#region Usings
using System;
using System.Diagnostics;
using System.Text;
#endregion

namespace Abbyy.Vantage.Utils
{
	/// <summary>
	/// Represents a single linked list.
	/// For simplicity our team decided to work only with integers.
	/// </summary>
	public class ListNode
	{
		#region Class members
		/// <summary>
		/// Node value.
		/// </summary>
		private int _value;
		/// <summary>
		/// Node sibling.
		/// </summary>
		private ListNode _next;
		#endregion

		#region Class properties
		/// <summary>
		/// Gets or sets node value.
		/// </summary>
		public int Value 
		{
			get => _value;
			set => _value = value;
		}
		/// <summary>
		/// Gets or sets node's sibling.
		/// </summary>
		public ListNode Next
		{
			get => _next;
			set => _next = value;
		}
		#endregion

		#region Class initialization
		/// <summary>
		/// Creates a new list node.
		/// </summary>
		/// <param name="v">Node value.</param>
		/// <param name="next">Node sibling.</param>
		public ListNode( int v = 0, ListNode next = null )
		{
			Value = v;
			Next = next;
		}
		/// <summary>
		/// Creates a new list based on variable number of arguments.
		/// </summary>
		/// <param name="arr">Values for a list.</param>
		/// <returns>Newsly created single linked list.</returns>
		public static ListNode Create( params int [] arr )
		{
			ListNode root = null;
			ListNode next = null;

			for( int i = 0; i < arr.Length; ++i )
			{
				var current = new ListNode( arr [ i ] );

				if( null == root )
				{
					root = next = current;
				}
				else
				{
					next.Next = current;
					next = current;
				}
			}

			return root;
		}
		#endregion

		#region Class utility methods
		/// <summary>
		/// Returns a string that represents the current object.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString() => Value.ToString();
		/// <summary>
		/// Prints the whole list into a stdout.
		/// </summary>
		public void Print()
		{
			var current = this;

			while( null != current )
			{
				Console.Write( current.Value + " > " );
				Debug.Write( current + " > " );
				current = current.Next;
			}

			Console.WriteLine( "null" );
			Debug.WriteLine( "null" );
		}
		/// <summary>
		/// Returns a string that represents the whole list.
		/// </summary>
		public string ToFullString()
		{
			var sb = new StringBuilder();
			var current = this;

			while( null != current )
			{
				sb.Append( current.Value + " > " );
				current = current.Next;
			}

			sb.Append( "null" );

			return sb.ToString();
		}
		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <param name="obj">The list to compare with the current list.</param>
		/// <returns>true if the specified list is equal to the current list; otherwise, false.</returns>
		public override bool Equals( object obj )
		{
			if( null == obj )
				return false;

			if( ReferenceEquals( this, obj ) )
				return true;

			var d = obj as ListNode;

			if( null == d )
				return false;

			if( d.Value != Value )
				return false;

			if( Next == null && null == d.Next )
				return true;

			if( Next == null || null == d.Next )
				return false;

			return Next.Equals( d.Next );
		}
		/// <summary>
		/// Serves as the default hash function.
		/// </summary>
		/// <returns>A hash code for the current object.</returns>
		public override int GetHashCode()
		{
			HashCode hash = new();

			var cur = this;

			while( null != cur ) 
			{
				hash.Add( cur.Value );
				cur = cur.Next;
			} 
			
			return hash.ToHashCode();
		}
		#endregion
	}
}
