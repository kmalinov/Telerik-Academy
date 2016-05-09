//Problem 4. Print a Deck
//Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up 
//to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of 
//clubs; and K of diamonds).

//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades.


using System;
class PrintADeck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {



            if (i == 11)
            {
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                continue;

            }
            else if (i == 12)
            {
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                continue;

            }
            else  if (i == 13)
            {
                Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                continue;
            }
            else if (i == 14)
            {
                Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                break;
            }

            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
        }


    }
}
