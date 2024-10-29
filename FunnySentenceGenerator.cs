using System;

class FunnySentenceGenerator
{
    static void Main(string[] args)
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        Random random = new Random();
        string funnySentence = "";
        int wordCount = 7;

        int count = 0;
        while (count < wordCount)
        {
            funnySentence += words[random.Next(words.Length)] + " ";
            count++;
        }

        Console.WriteLine(funnySentence.Trim());
    }
}
