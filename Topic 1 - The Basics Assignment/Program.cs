namespace Topic_1___The_Basics_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jack";
            string favMovie = "The Maxrix";

            Console.WriteLine("hello, " + firstName.ToLower() + " i see that your favorite movie is " + favMovie.ToLower() + "!");

            favMovie = "THE MATRIX";

            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");

            Console.WriteLine(favMovie);
        }
    }
}
