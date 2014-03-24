using System;

/* Note to self about using git version control in xamarin:
 * 1. it's best to use an empty repo for a new project instead of initializing it right away
 * 2. pull is called "update solution"
 * 3. commit is called "commit solution"
 * */

namespace SeeSharpWithC
{
	public class MainClassRunner
	{
		//Args work just like in Java
		public static int Main(string[] args) //There can be only one main method in a project
		{
			// System.Console.WriteLine("Hello, World!");
			// Instead of writing System. we can use "using System" just like in C++
			Console.WriteLine ("Hello, world!");
			return 0; //The main method can return stuff, forgetting to change the "void" results 
					  //in a compile-time error, the editor doesn't notice it earlier..
		}
	}
}

