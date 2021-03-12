using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howdy
{
    class Program
    {
        static void Main(string[] args)
        {
            //level of drunkness -> weight and gender -> tolerance -> alcohol preferences -> duration -> bakfylletips

            //1. nothing
            //2. talky
            //3. dancy
            //4. drunk as hell
            string input = string.Empty;
            float bac = 0;
            int weight;
            int gender = 0;
            float tolerance = 1.0f;
            Console.WriteLine("How drunk do woould you like to get?");
            Console.WriteLine("1. Not at all, just want to feel the taste.");
            Console.WriteLine("2. Talkative and more social. And a little bit of confidence.");
            Console.WriteLine("3. Dancy, even though you know you can't dance");
            Console.WriteLine("4. Shitfaced. I want to ease the pain of existence.");
            input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    bac = 0.1f;
                    break;
                case "2":
                    bac = 0.3f;
                    break;
                case "3":
                    bac = 0.9f;
                    break;
                case "4":
                    bac = 2.0f;
                    break;
            }

            Console.WriteLine("How much do you weigh?");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gender?");
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    gender = 1;
                    break;
                case "2":
                    gender = 2;
                    break;
            }

            Console.WriteLine("How high is your tolerance towards alcohol?");
            Console.WriteLine("1. Not high, I get drunk from a half bottle of wine.");
            Console.WriteLine("2. Average, I drink once or twice a week in moderate amounts");
            Console.WriteLine("3. Higher than average.");
            Console.WriteLine("4. Vodka is water for me.");

            switch (input)
            {
                case "1":
                    tolerance = 1.5f;
                    break;
                case "2":
                    tolerance = 1.0f;
                    break;
                case "3":
                    tolerance = 0.7f;
                    break;
                case "4":
                    tolerance = 0.3f;
                    break;
            }

            Console.WriteLine("What is your preferred posion?");
            Console.WriteLine("1. Beer");
            Console.WriteLine("2. Wine");
            Console.WriteLine("3. Whiskey");
            Console.WriteLine("4. Vodka");
            Console.WriteLine("5. Drinks");
            Console.WriteLine("6. Absinthe");
        }
    }
}
