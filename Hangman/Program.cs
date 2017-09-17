using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret;
            string guess = "";
            string guesses = "";
            char currentGuess = ' ';
            int badGuesses = 0;

            Console.WriteLine("Let's play hangman.\nGive me a secret word:");
            secret = Console.ReadLine().ToUpper();

            foreach (char c in secret)
                guess += "_";



            //start game loop
            while (badGuesses < 6 && secret != guess)
            {
                Console.Clear();
                Console.WriteLine("Have your friend guess the secret word");

                Console.WriteLine($"You have already guessed: {guesses}");
                foreach (char c in guess)
                    Console.Write(c + " ");
                Console.WriteLine();


                //foreach (char c in guesses)
                //    Console.Write(c + " ");
                //Console.WriteLine();

                //for (int i = 0; i < guess.Length; i++)
                //    Console.Write(guess[i] + " ");
                //Console.WriteLine();

                currentGuess = (Console.ReadLine().ToUpper())[0]; //first input in the string
                guesses += currentGuess;


                if (!secret.Contains(currentGuess))
                    badGuesses++;
                else
                    for (int i = 0; i < secret.Length; i++)
                        if (currentGuess == secret[i])
                        {
                            string newguess = "";

                            for (int j = 0; j < guess.Length; j++)
                                if (i == j)
                                    newguess += currentGuess;
                                else
                                    newguess += guess[j];


                            guess = newguess;

                        }

            }

            Console.Clear();
            Console.WriteLine("Have your friend guess the secret word");

            //foreach (char c in guess)
            //    Console.Write(c + " ");
            //Console.WriteLine();


            Console.Write($"You have already guessed: {guesses}");
            //foreach (char c in guesses)
            //    Console.Write(c + " ");
            //Console.WriteLine();

            for (int i = 0; i < guess.Length; i++)
                Console.Write(guess[i] + " ");
            Console.WriteLine();


            if (secret == guess)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose.");





        }
    }
}
