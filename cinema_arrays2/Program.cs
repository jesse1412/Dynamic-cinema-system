using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_arrays2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many movies would you like to enter?");
            int initialMaxMovies = int.Parse( Console.ReadLine() );

            string[] movieList = new string[initialMaxMovies];
            int[] movieAges = new int[initialMaxMovies];

            //Cinema manager side of program (enter movies).
            do{

                for( int i = 0; i < initialMaxMovies; i++)
                {

                    //Taking movie names.
                    Console.WriteLine("\nPlease enter the name of movie " + ( i + 1 ) + ":");
                    movieList[i] = Console.ReadLine();

                    //Taking age requirements of movies.
                    Console.WriteLine("\nPlease enter the age requirement of movie " + (i + 1) + ":");
                    do
                    {
                        try
                        {
                            movieAges[i] = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Sorry, that isn't a valid age; try again: ");
                        }
                    }
                    while (true);
                }
                Console.WriteLine( "\nHere are the movies you have entered:" );
                for(int i = 0; i < initialMaxMovies; i++)
                {
                    Console.WriteLine( "    " + movieList[i] );
                }
                Console.WriteLine("\n\nThank you for entering your movies, is this your final list? Y/N:");
                if ( Console.ReadLine().ToLower() == "n" )
                {
                    Console.WriteLine( "\nThat's okay, let's retry" );
                }
                else{
                    Console.WriteLine("\nThank you, we are now ready to proccess customers");
                    break;
                }
            }
            while(true);

            //Customer side of program (select a movie).
            do{

                //Welcoming text.
                Console.WriteLine("\n\n\nWelcome to our Multiplex. We are presently showing:\n");
                for( int i = 0; i < movieList.GetLength(0); i++)
                {
                    int DisplayNum = i + 1;
                    Console.WriteLine( " " + DisplayNum + ". " + movieList[i] + " (" + movieAges[i] + ")" );
                }

                //Movie selection.
                int selectedMovie = 0;
                Console.WriteLine("\nEnter the number of the film you wish to see:");
                do{
                    try{
                        selectedMovie = int.Parse(Console.ReadLine()) - 1;
                        if (selectedMovie > -1 && selectedMovie < initialMaxMovies)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter a valid number:");
                        }
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("\nPlease enter a valid number:");
                    }
                }
                while(true);

                Console.WriteLine("\nThank you for selecting " + movieList[selectedMovie]);

                //Entering age.
                int age = 0;
                Console.WriteLine("\nEnter your age:");
                do
                {
                    try
                    {
                        age = int.Parse(Console.ReadLine());
                        if (age >= 0 && age < 123)
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\nPlease enter a valid age:");
                    }
                }
                while (true);

                //Checking age
                if(age >= movieAges[selectedMovie])
                {
                    Console.WriteLine("\nThank you for entering your details, you may view the movie.");
                }
                else
                {
                    Console.WriteLine("\nAccess denied – you are too young");
                }
            }
            while( true );
        }
    }
}
