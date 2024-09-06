namespace Topic_1___The_Basics_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jack";
            string favMovie = "The Maxrix";

            Console.WriteLine("hello, " + firstName.ToLower() + " i see that your favorite movie is " + favMovie.ToLower() + "!");

            favMovie = favMovie.ToUpper();

            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");

            Console.WriteLine(favMovie);

            string favQuote = "I don't really have a favourite quote from something... Sorry.";

            favQuote = favQuote.ToLower();

            favQuote = favQuote.Replace("a", "");
            favQuote = favQuote.Replace("e", "");
            favQuote = favQuote.Replace("i", "");
            favQuote = favQuote.Replace("o", "");
            favQuote = favQuote.Replace("u", "");
            favQuote = favQuote.Replace("y", "");

            Console.WriteLine(favQuote);

            Console.WriteLine();

            Console.Write("                          ");
            Console.WriteLine("   |\\---/|                ");
            Console.Write("   / \\__                  ");
            Console.WriteLine("   | ,_, |                 ");
            Console.Write("  (    @\\___              ");
            Console.WriteLine("    \\_`_/-..----.         ");
            Console.Write("  /         O              ");
            Console.WriteLine(" ___/ `   ' ,\"\"+ \\  sk  ");
            Console.Write(" /   (_____/               ");
            Console.WriteLine("(__...'   __\\    |`.___.';");
            Console.Write("/_____/   U                ");
            Console.WriteLine("  (_,...'(_,.`__)/'.....+  ");
        }
    }
}
