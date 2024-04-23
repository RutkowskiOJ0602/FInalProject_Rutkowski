using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DogBreedPicker
{
    public class Prices
    {
        private static Dictionary<string, string> DogPrices = new Dictionary<string, string>()
        {
            { "BassetHound", "$600 - $1200" },
            { "Beagle", "$300 - $1200" },
            { "Bloodhound", "$450 - $1200" },
            { "Dachshund", "$500 - $4000" },
            { "Greyhound", "$1500 - $3000" },
            { "RhodesianRidgeback", "$1800 - $2500" },
            { "Chihuahua", "$1000 - $4000" },
            { "Havanese", "$1000 - $1500" },
            { "Maltese", "$2000 - $4000" },
            { "Papillon", "$250 - $3000" },
            { "Pekingese", "$800 - $3745" },
            { "Pomeranian", "$800 - $2000" },
            { "ToyPoodle", "$1000 - $3000" },
            { "Pug", "$600 - $1500" },
            { "AiredaleTerrier", "$800 - $2000" },
            { "CairnTerrier", "$800 - $2500" },
            { "MiniatureSchnauzer", "$1500 - $2275" },
            { "JackRussellTerrier", "$600 - $1500" },
            { "BullTerrier", "$800 - $2000" },
            { "GermanShepherd", "$1500 - $2500" },
            { "AustralianShepherd", "$450 - $800" },
            { "BorderCollie", "$600 - $1200" },
            { "SpanishWaterDog", "$1500 - $2500" },
            { "PembrokeWelshCorgi", "$700 - $2000" },
            { "ShetlandSheepdog", "$1000 - $2000" },
            { "Samoyed", "$1000 - $3000" },
            { "StandardSchnauzer", "$1500 - $2500" },
            { "AlaskanMalamute", "$500 - $2500" },
            { "BerneseMountainDog", "$700 - $2000" },
            { "Boxer", "$800 - $2800" },
            { "DobermanPinscher", "$1000 - $5000" },
            { "GreatDane", "$600 - $3000" },
            { "Mastiff", "$1000 - $3500" },
            { "Newfoundland", "$1000 - $2000" },
            { "Rottweiler", "$1500 - $4000" },
            { "SiberianHusky", "$600 - $2000" },
            { "EnglishCockerSpaniel", "$800 - $1600" },
            { "AmericanCockerSpaniel", "$800 - $2000" },
            { "GermanShorthairedPointer", "$600 - $1500" },
            { "GoldenRetriever", "$500 - $3000" },
            { "IrishSetter", "$1200 - $2500" },
            { "LabradorRetriever", "$800 - $1500" },
            { "BostonTerrier", "$350 - $3500" },
            { "Dalmatian", "$300 - $3000" },
            { "ChowChow", "$800 - $1500" },
            { "FrenchBulldog", "$800 - $4000" },
            { "MiniaturePoodle", "$1500 - $3000" },
            { "StandardPoodle", "$500 - $1500" },
            { "ShibaInu", "$1400 - $2200" }
        };
        public static string GetDogPrice()
        {
            string Breed = " ";
            bool continueloop = true;
            while (continueloop)
            {
                Console.WriteLine("Type in a dog dog breed to get a price range");
                Console.WriteLine("Hint: type in as seen above.");
                Breed = Console.ReadLine();
                Breed = Breed.Replace(" ", "");
                if (DogPrices.TryGetValue(Breed, out string selectedBreed))
                {
                    Breed = selectedBreed;
                }
                else
                {
                    // Handle the case when the group is invalid
                    Console.WriteLine("Invalid breed selection");
                }
                Console.WriteLine("The price range is from " + Breed);

                Console.WriteLine("Type 'Y' to continue");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Y)
                {
                    Console.WriteLine(" ");
                    continueloop = true;
                }
                else
                {
                    continueloop = false;
                }
            }
            return Breed;
        }
    }
}
