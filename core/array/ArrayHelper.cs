#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Abbyy.Vantage.Utils
{
	/// <summary>
	/// Represents a helper class for array manipulations.
	/// It's not finished yet, you are always welcome to send pull requests to vantage team.
	/// </summary>
	public class ArrayHelper
	{
		#region Class utility methods
		/// <summary>
		/// Find two missing numbers in an array  [0..n]
		/// </summary>
		/// <param name="nums">Input array of length n - 1.</param>
		/// <returns>Two missing numbers as an array</returns>
		public static int[] FindMissingNumbers( int [] arr ) 
		{
			var n = arr.Length + 1;

			// Sum of 2 missing numbers
			int sum = ( n * ( n + 1 ) ) / 2 -	arr.Sum();

			// Find average of two elements
			int avg = ( sum / 2 );

			int sumSmallerHalf = 0,	sumGreaterHalf = 0;

			for( int i = 0; i < n - 1; i++ )
			{
				if( arr [ i ] <= avg )
				{
					sumSmallerHalf += arr [ i ];
				}
				else
				{
					sumGreaterHalf += arr [ i ];
				}
			}

			int totalSmallerHalf = ( avg * ( avg + 1 ) ) / 2;

			var first = totalSmallerHalf - sumSmallerHalf;

			var second = ( ( n * ( n + 1 ) ) / 2 - totalSmallerHalf ) - sumGreaterHalf;

			return new [] { first, second };
		}
		/// <summary>
		/// Find two missing numbers in an array  [0..n]
		/// </summary>
		/// <param name="nums">Input array of length n - 1.</param>
		/// <returns>Two missing numbers as an array</returns>
		public static int [] FindMissingNumbersOld( int [] nums )
		{
			var len = nums.Length;

			var min = 0;
			var max = len + 1;

			var hasMin = false;
			var hasMax = false;

			for( int i = 0; i < len; ++i )
			{
				var n = nums [ i ];

				if( n <= 0 || n >= max )
				{
					nums [ i ] = max + 1;
				}

				if( n == min )
				{
					hasMin = true;
				}

				if( n == max )
				{
					hasMax = true;
				}
			}

			if( !hasMin && !hasMax )
				return new [] { min, max };

			// let's use values as pigeon holes (i.e. as indexes)

			for( int i = 0; i < len; ++i )
			{
				var n = nums [ i ];
				var index = Math.Abs( n );

				if( index > max )
					continue;

				--index;

				if( nums [ index ] > 0 )
				{
					nums [ index ] *= -1;
				}
			}

			var list = new List<int>();

			for( int i = 0; i < len; ++i )
			{
				var n = nums [ i ];

				if( n >= 0 )
				{
					list.Add( i + 1 );
				}
			}

			if( !hasMin )
			{
				list.Add( min );
			}

			if( !hasMax )
			{
				list.Add( max );
			}

			return list.ToArray();
		}
		#endregion
	}
}
