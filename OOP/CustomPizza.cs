using System;
using System.Collections.Generic;

namespace OOP
{
    class CustomPizza : Pizza
    {
        static int number = 0;
        public CustomPizza() : base("Custom", 5, false, null)
        {
            ingredients = new List<string>();
            number++;
            name = $"custom {number}";
            while (true)
            {
                Console.Write("Enter an ingredient (press enter to finish): ");
                var ingredient = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ingredient))
                {
                    break;
                }
                if (ingredients.Contains(ingredient))
                {
                    Console.Write("The pizza already contains this ingredient");
                }
                else
                {
                    ingredients.Add(ingredient);
                    Console.WriteLine(string.Join(", ", ingredients));
                }
                Console.WriteLine();
            }
            price = 5 + ingredients.Count * 1.5f;
        }

    }
}
