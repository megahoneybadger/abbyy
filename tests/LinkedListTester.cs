#region Usings
using System;
using Xunit;
#endregion

namespace Abbyy.Vantage.Utils.Tests
{
	/// <summary>
	/// Tests main public methods of linked list helper.
	/// 
	/// dotnet test _bin\tests\abbyy.vantage.utils.tests.dll -v n --filter "FullyQualifiedName~LinkedListTester"
	/// </summary>
	public class LinkedListTester
	{
		#region Class 'Reverse' tests
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_ReverseLinkedList_WithMultipleElements()
		{
			var originalList = ListNode.Create( 1, 2, 3, 4, 5 );

			var expectedList = ListNode.Create( 5, 4, 3, 2, 1 );

			var reversedList = LinkedListHelper.Reverse( originalList );

			Assert.Equal( reversedList, expectedList );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_ReverseLinkedList_WithTwoElements()
		{
			var originalList = ListNode.Create( 1, 2 );

			var expectedList = ListNode.Create( 2, 1 );

			var reversedList = LinkedListHelper.Reverse( originalList );

			Assert.Equal( reversedList, expectedList );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void ShouldNot_ReverseLinkedList_WithOneElement()
		{
			var originalList = ListNode.Create( 1 );

			var expectedList = ListNode.Create( 1 );

			var reversedList = LinkedListHelper.Reverse( originalList );

			Assert.Equal( reversedList, expectedList );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void ShouldNot_ReverseLinkedList_WithoutElements()
		{
			var reversedList = LinkedListHelper.Reverse( null );

			Assert.Null( reversedList );
		}
		#endregion

		#region Class 'Middle' tests
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void ShouldNot_GetMiddleElement()
		{
			var list = ListNode.Create( 1, 2, 3, 4, 5 );

			Assert.Throws<NotImplementedException>( () => LinkedListHelper.GetMiddle( list ) );
		}
		#endregion
	}
}
