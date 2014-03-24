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

		// Args work just like in Java
		public static int Main (string[] args) //There can be only one main method in a project
		{
			// System.Console.WriteLine("Hello, World!");
			// Instead of writing System. we can use "using System" just like in C++
			Console.WriteLine ("Hello, world!");

			/* Error messages in C# are pretty understandable so that's better then in CPP
			 * but they generally only appear when we compile the code so we get less
			 * help while we write the code. (compared to eclipse/java) Idk if this is a xamarin
			 * thing or just C#, I'm gussing the latter. Also there's no spell-checking :P.
			 * 
			 * edit: Just found out that there's an option for source analysis. So now I get
			 * some helpful info when writing code. I wonder why it isn't enabled by default.
			 */
			Console.WriteLine ("Calculation Example: " + SimpleCalculate (1, 2, "plus"));
			Console.WriteLine ("Calculation Example: " + SimpleCalculate (1, 4, "minus"));
			Console.WriteLine ("Calculation Example: " + SimpleCalculate (8, 2, "divide"));
			Console.WriteLine ("Calculation Example: " + SimpleCalculate (4, 4, "multiply"));

			/* Apperently we need create the instance of this class in the main method
			 * defining it outside doesn't seem to work due to "An object reference is
			 * required to access non-static member ..."
			 */
			AdditionalClassExample example = new AdditionalClassExample ();
			example.CoolMethodInOtherClass ();

			return 0; // The main method can return stuff, forgetting to change the "void" results 
			// in a compile-time error, the editor doesn't notice it earlier..
		}
		/* 1: Ok so the source analysis tells me that method names in C# begin with a big
		 * letter unlike Java. Stackoverflow confirms this.
		 * 
		 * 2: Source analysis tells me that using a IEquatable is better then a plain string,
		 * probably because we're using the string for equal comparisons. Though I don't
		 * understand whether this is just for "nicer" code or if there's an actual
		 * performance reason.
		 */
		public static int SimpleCalculate (int number1, int number2, IEquatable<string> operation)
		{
			int total = 0;
			if (operation.Equals ("plus")) {
				total = (number1 + number2);
			} else if (operation.Equals ("minus")) {
				total = number1 - number2;
			} else if (operation.Equals ("multiply")) {
				total = number1 * number2;
			} else if (operation.Equals ("divide")) {
				total = number1 / number2;
			} else {
				Console.WriteLine ("Your input makes no sense :P!");
			}
			return total;
		}
	}
}