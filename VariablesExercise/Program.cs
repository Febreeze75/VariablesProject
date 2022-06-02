using System;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName; //Declaration syntax
            dogName = "Zuko"; //Initializing syntax
            int dogAge = 7; // Declaring &Initializing syntax
            char firstInitial = 'Z';
            bool isThirsty = true;
            double dogWeight = 47.5; //decimals
            decimal dogHeight = 11.7m; //ends with m

            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old, he weighs {dogWeight} lbs, and he is {dogHeight} inches tall.");
            Console.WriteLine($"It is {isThirsty} that he is always thirsty.");

            
        }
    }
}
