#region Usings
using System;
using Xunit;
#endregion

namespace Abbyy.Vantage.Utils.Tests
{
	/// <summary>
	/// Tests main public methods of linked list helper.
	/// 
	/// dotnet test _bin\tests\abbyy.vantage.utils.tests.dll -v n --filter "FullyQualifiedName~ArrayHelperTester"
	/// </summary>
	public class ArrayHelperTester
	{
		#region Class 'Get missing numbers' tests
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario1()
		{
			Assert.Equal( new [] { 1, 5 },
				FindMissingNumbers( new [] { 0, 2, 3, 4 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario2()
		{
			Assert.Equal( new [] { 0, 5 },
				FindMissingNumbers( new [] { 1, 2, 3, 4 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario3()
		{
			Assert.Equal( new [] { 4, 5 },
				FindMissingNumbers( new [] { 0, 1, 2, 3 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario4()
		{
			Assert.Equal( new [] { 0, 1 },
				FindMissingNumbers( new [] { 2, 3, 4, 5 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario5()
		{
			Assert.Equal( new [] { 0, 2 },
				FindMissingNumbers( new [] { 1, 3, 4, 5 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario6()
		{
			Assert.Equal( new [] { 0, 3 },
				FindMissingNumbers( new [] { 1, 2, 4, 5 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario7()
		{
			Assert.Equal( new [] { 0, 4 },
				FindMissingNumbers( new [] { 1, 2, 3, 5 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario8()
		{
			Assert.Equal( new [] { 0, 5 },
				FindMissingNumbers( new [] { 1, 2, 3, 4 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario9()
		{
			Assert.Equal( new [] { 1, 5 },
				FindMissingNumbers( new [] { 0, 2, 3, 4 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario10()
		{
			Assert.Equal( new [] { 2, 5 },
				FindMissingNumbers( new [] { 0, 1, 3, 4 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario11()
		{
			Assert.Equal( new [] { 3, 5 },
				FindMissingNumbers( new [] { 0, 1, 2, 4 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario12()
		{
			Assert.Equal( new [] { 4, 5 },
				FindMissingNumbers( new [] { 0, 1, 2, 3 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario21()
		{
			Assert.Equal( new [] { 3, 4 },
				FindMissingNumbers( new [] { 0, 1, 2 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario22()
		{
			Assert.Equal( new [] { 2, 3 },
				FindMissingNumbers( new [] { 0, 1 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario23()
		{
			Assert.Equal( new [] { 0, 1 },
				FindMissingNumbers( new [] { 2, 3 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario24()
		{
			Assert.Equal( new [] { 0, 2 },
				FindMissingNumbers( new [] { 1, 3 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario25()
		{
			Assert.Equal( new [] { 0, 3 },
				FindMissingNumbers( new [] { 1, 2 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario26()
		{
			Assert.Equal( new [] { 1, 3 },
				FindMissingNumbers( new [] { 0, 2 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario27()
		{
			Assert.Equal( new [] { 2, 3 },
				FindMissingNumbers( new [] { 0, 1 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario31()
		{
			Assert.Equal( new [] { 0, 1 },
				FindMissingNumbers( new [] { 2 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario32()
		{
			Assert.Equal( new [] { 0, 2 },
				FindMissingNumbers( new [] { 1 } ) );
		}
		/// <summary>
		/// 
		/// </summary>
		[Fact]
		public void Should_FindNumbers_Scenario33()
		{
			Assert.Equal( new [] { 1, 2 },
				FindMissingNumbers( new [] { 0 } ) );
		}
		#endregion

		#region Class utility methods
		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <returns></returns>
		private int [] FindMissingNumbers( int [] arr )
		{
			var res = ArrayHelper.FindMissingNumbers( arr );
			Array.Sort( res );

			return res;
		}
		#endregion


	}
}
