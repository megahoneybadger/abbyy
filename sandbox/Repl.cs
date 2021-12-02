#region Usings
using System;
using System.Collections.Generic;
#endregion

namespace Abbyy.Vantage.Utils.Sandbox
{
	/// <summary>
	/// Represents read–eval–print loop.
	/// </summary>
	public sealed class Repl 
	{
		#region Class constants
		/// <summary>
		/// Command to exit the loop.
		/// </summary>
		private const string COMMAND_EXIT = "exit";
		/// <summary>
		/// Command to reverse a linked list.
		/// </summary>
		private const string COMMAND_REVERSE = "reverse";
		/// <summary>
		/// Command to find missing numbers in an array.
		/// </summary>
		private const string COMMAND_FIND_MISSING = "missing";
		#endregion

		#region Class members
		/// <summary>
		/// 
		/// </summary>
		private bool _run;
		#endregion

		#region Class public methods
		/// <summary>
		/// Runs main command cycle.
		/// </summary>
		public void Run() 
		{
			Console.WriteLine( "ABBYY vantage utils REPL is running..." );
			Console.WriteLine( "Enter command and arguments separated by space:" );
			Console.WriteLine();

			_run = true;

			while( _run ) 
			{
				Console.Write( ">" );

				var content = Console.ReadLine();

				Execute( CommandLineRequest.Create( content ) );

				Console.WriteLine();
			}
		}
		/// <summary>
		/// Executes command line request.
		/// </summary>
		/// <param name="r">Request to execute.</param>
		private void Execute( CommandLineRequest r ) 
		{
			try
			{
				switch( r?.Command )
				{
					case COMMAND_EXIT:
						_run = false;
						return;

					case COMMAND_REVERSE:
						ReverseLinkedList( r.Arguments );
						break;

					case COMMAND_FIND_MISSING:
						FindMissingNumbers( r.Arguments );
						break;

					default:
						ShowError( "Unknown command or invalid input." );
						break;
				}
			}
			catch 
			{
				ShowError( "Oops, our bad! Send this test case to vantage team: we will try to fix asap." );
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="error"></param>
		private static void ShowError( string error ) 
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Error.WriteLine( error );
			Console.ResetColor();
		}
		#endregion

		#region Class utility methods
		/// <summary>
		/// Wraps linked list reverse.
		/// </summary>
		private void ReverseLinkedList( int [] nums ) 
		{
			var list = ListNode.Create( nums );

			Console.WriteLine( $"List to reverse: {( list?.ToFullString() ?? "(empty)" )}" );

			var res = LinkedListHelper.Reverse( list );

			Console.WriteLine( $"Reversed list: {( res?.ToFullString() ?? "(empty)" )}" );
		}
		/// <summary>
		/// Wraps search of missing numbers in an array.
		/// </summary>
		private void FindMissingNumbers( int [] nums )
		{

		}
		#endregion

		#region Class internal structs
		/// <summary>
		/// Represents command line input.
		/// </summary>
		internal sealed class CommandLineRequest 
		{
			#region Class properties
			/// <summary>
			/// Gets command.
			/// </summary>
			public string Command { get; private set; }
			/// <summary>
			/// Get arguments.
			/// For simplicity our team decided to work only with integers at this version.
			/// </summary>
			public int [] Arguments { get; private set; }
			#endregion

			#region Class initialization
			/// <summary>
			/// Creates a new request.
			/// </summary>
			/// <param name="content">Raw command line input.</param>
			public CommandLineRequest( string content ) 
			{
				Parse( content );
			}
			/// <summary>
			/// Creates an object representing command line request.
			/// </summary>
			/// <param name="content">Raw command line input.</param>
			/// <returns>Request object if correct input, otherwise null.</returns>
			public static CommandLineRequest Create( string content )
			{
				CommandLineRequest r = null;

				try
				{
					r = new CommandLineRequest( content );
				}
				catch
				{}

				return r;
			}
			#endregion

			#region Class parsing methods
			/// <summary>
			/// 
			/// </summary>
			private void Parse( string content ) 
			{
				var parts = content.Split( ' ', StringSplitOptions.RemoveEmptyEntries );

				if( parts.Length < 1 )
					throw new ArgumentException( "Invalid command line input" );

				Command = parts [ 0 ];

				var args = new List<int>();
				var candidates = parts [ 1.. ];

				foreach( var c in candidates ) 
				{
					// Let's try to discard all non-number garbage.
					if( !int.TryParse( c, out var v ) )
						continue;

					args.Add( v );
				}

				Arguments = args.ToArray();
			}
			#endregion
		}
		#endregion
	}
}

