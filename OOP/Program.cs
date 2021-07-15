using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var margherita = new Pizza(
               "MARGHERITA",
               9.5f,
               true,
               new List<string> { "Basilico fresco", "Pomodoro San Marzano DOP*", "Fior di latte" }
            );
            var paola = new Pizza(
                "PAOLA",
                12.5f,
                false,
                new List<string> { 
                    "Mortadella",
                    "Stracciatella del Caseificio Maldera*",
                    "Pistacchio",
                    "Basilico",
                    "Pomodoro Saan Marzano DOP*",
                    "Fior di latte"
                }
             );
            var valeria = new Pizza(
                "VALERIA",
                13,
                false,
                new List<string> { 
                    "Prosciutto tartuffo di Piemonte",
                    "Stracciatella del Caseificio Maldera*",
                    "Rucola",
                    "Pomodoro Saan Marzano DOP*",
                    "Fior di latte"
                }
            );
            var carlotta = new Pizza(
                "CARLOTTA",
                10,
                true,
                new List<string> { 
                    "Provolone Piccante Cremona*",
                    "Spianata piccante de Cremona*",
                    "Cipolle rosse",
                    "Olive Leccino della Toscana*",
                    "Pomodoro Saan Marzano DOP*"
                }
            );
            var custom1 = new CustomPizza();
            var custom2 = new CustomPizza();
            var pizzasList = new List<Pizza> { margherita, paola, valeria, carlotta, custom1, custom2 }.OrderBy(p => p.price).ToList();
            var onlyVegetarian = pizzasList.Where(p => p.isVege).ToList();
            var onlyWithMortadella = pizzasList.Where(p => p.ingredients.Where(i => i.Contains("Mortadella")).ToList().Count > 0).ToList();
            foreach (var pizza in pizzasList)
            {
                pizza.Display();
            }
        }
    }
}
