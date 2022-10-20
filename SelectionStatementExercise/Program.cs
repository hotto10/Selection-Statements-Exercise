using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)

        {
            //Exerice 1
            var r = new Random();
            var randomNum = r.Next(1, 10);

            MyGuess(randomNum);

            static void MyGuess(int randomNum)
            {
            repeat:

                Console.WriteLine("Guess the Number");

                int guess = int.Parse(Console.ReadLine());

                {

                    if (guess < randomNum)
                    {

                        Console.WriteLine("too low");
                        Console.WriteLine();
                        goto repeat;

                    }

                    else if (guess > randomNum)
                    {

                        Console.WriteLine("too high");
                        Console.WriteLine();
                        goto repeat;

                    }

                    else

                    {
                        Console.WriteLine();
                        Console.WriteLine("You guessed it!!!");
                        Console.WriteLine();
                    }
                    

                }
                 //Exercise 2
              
                Console.WriteLine();
                Console.WriteLine("What is your favorite subject?");
                string favSubject = (Console.ReadLine());
                Console.WriteLine();

                switch (favSubject.ToLower())
                {
                    case "math":
                        Console.WriteLine("Math is the same in every country!");
                        break;

                    case "literature":
                        Console.WriteLine("Readers are always smart!");
                        break ;

                    case "history":
                        Console.WriteLine("History repeats itself!!") ;
                        break ;

                    case "programming":
                        Console.WriteLine("Go to TrueCoders!!!") ;
                        break;

                        default:
                        Console.WriteLine("All subjects can be fun and awesome!");
                        break;




                }
              
            }
        }
        
    }


        

    

























}


            

           
          
