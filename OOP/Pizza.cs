using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Pizza
    {
        protected string name;
        public float price { get; protected set; }
        public bool isVege { get; private set; }
        public List<string> ingredients { get; protected set; }

        public Pizza(string name, float price, bool isVege, List<string> ingredients)
        {
            this.name = name;
            this.price = price;
            this.isVege = isVege;
            this.ingredients = ingredients;
        }

        private static string FormatString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }
            return $"{s.ToUpper()[0]}{s.ToLower()[1..]}";
          
        }
        public void Display()
        {
            var formattedIngredients = ingredients.Select(i => FormatString(i));
            Console.WriteLine($"{FormatString(name)} {(isVege ? "(V)" : "")} - {price}€");
            Console.WriteLine(string.Join(", ", formattedIngredients));
            Console.WriteLine();
        }
    }
}
