using System;

class Program
{
    static void Main(string[] args)
    {
        // Test cases for Scrabble class
        Scrabble s1 = new Scrabble("");
        Console.WriteLine(s1.Score()); // should return 0

        Scrabble s2 = new Scrabble(" \t\n");
        Console.WriteLine(s2.Score()); // should return 0

        Scrabble s3 = new Scrabble("a");
        Console.WriteLine(s3.Score()); // should return 1

        Scrabble s4 = new Scrabble("f");
        Console.WriteLine(s4.Score()); // should return 4

        Scrabble s5 = new Scrabble("street");
        Console.WriteLine(s5.Score()); // should return 6

        Scrabble s6 = new Scrabble("quirky");
        Console.WriteLine(s6.Score()); // should return 22

        Scrabble s7 = new Scrabble("OXyPHEnBUTaZoNE");
        Console.WriteLine(s7.Score()); // should return 41
    }
}
