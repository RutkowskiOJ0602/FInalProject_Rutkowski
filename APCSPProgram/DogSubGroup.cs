using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
internal class DogSubGroup
{
    // Create a dictionary for the Subgroups
    public static Dictionary<string, List<string>> SubGroups = new Dictionary<string, List<string>>()
    {
        // create sublists based on characteristics people look for when buying a dog
        ["Family Friendly"] = new List<string> { "Basset Hound", "Beagles", "Bloodhound", "Dachshund", "Greyhound", "Rhodesian Ridgeback", "Chihuahua", "Havanese", "Maltese", "Papillon", "Pekingese", "Pomeranian", "Toy Poodle", "Pug", "Airedale Terrier", "Cairn Terrier", "Miniature Schauzer", "Jack Russel Terrier", "German Shepherd", "Australian Shepherd", "Border Collie", "Spanish Water Dog", "Pembroke Welsh Corgi", "Shetland Sheepdog", "Samoyed", "Standard Schnauzer", "Alaskan Malamute", "Bernese Mountain Dog", "Great Dane", "Newfoundland", "Siberian Husky", "English Cocker Spaniel", "American Cocker Spaniel", "German Shorthaired Pointer", "Golden Retriever", "Irish Setter", "Labrador Retriever", "Boston Terrier", "Dalmatian", "French Bulldog", "Miniature Poodle", "Standard Poodle", "Shiba Inu" },
        ["Hypoallergenic"] = new List<string> { "Havanese", "Maltese", "Toy Poodle", "Airedale Terrier", "Cairn Terriers", "Miniature Schnauzer", "Miniature Poodle", "Spanish Water Dog", "Standard Schnauzer", "Standard Poodle" },
        ["Small"] = new List<string> { "Basset Hound", "Beagle", "Dachshund", "Chihuahua", "Havanese", "Maltese", "Papillon", "Pekingese", "Pomeranian", "Toy Poodle", "Pug", "Cairn Terrier", "Miniature Schnauzer", "Jack Rusell Terrier", "Pembroke Welsh Corgi", "American Cocker Spaniel", "French Bulldog", "Miniature Poodle" },
        ["Large"] = new List<string> { "Rhodesian Ridgeback", "Bloodhound", "Greyhound", "German Shepherd", "Alaskan Malamute", "Bernese Mountain Dog", "Boxer", "Doberman Pinscher", "Great Dane", "Mastiff", "Newfoundland", "Rottweiler", "Siberian Husky", "Labrador Retriever", "Chow Chow", "Standard Poodle" },
        ["Medium"] = new List<string> { "Airedale Terrier", "Bull Terrier", "Australian Shepherd", "Border Collie", "Spanish Water Dog", "Shetland Sheepdog", "Samoyed", "Standard Schnauzer", "English Cocker Spaniel", "German Shorthaired Pointer", "Golden Retriever", "Irish Setter", "Boston Terrier", "Dalmatian", "Shiba Inu", "Standard Poodle" }
    };
    public static List<string> GetSubGroupPick()
    {
        List<string> SubGroup = new List<string>();
        //Give instructions for the input
        Console.WriteLine("Hint:the toy dogs are all small");
        Console.WriteLine("Type in the input as Family Friendly, Hypoallergenic, Small, Medium, or Large");
        Console.WriteLine("Pick a subcategory based on what you look for in a dog");
        string SubGroup_pick = Console.ReadLine();
        // List<string> SubGroup = new List<string>();
        if (SubGroups.TryGetValue(SubGroup_pick, out List<string> selectedSubGroup))
        {
            SubGroup = selectedSubGroup;
            return SubGroup;
        }
        else
        {
            // Handle the case when the group is invalid
            Console.WriteLine("Invalid group selection");
            return SubGroup;
        }
    }
    public static List<string> ContinueSubGroupPick(List<string> Dogs_selection) 
    {
        bool continueLoop = true;
        while (continueLoop)
        {
            Console.WriteLine("Would you like to add another subgroup? Type 'y' if yes.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                Console.WriteLine(" ");
                continueLoop = true;
                List<string> Dog_SubGroup = DogSubGroup.GetSubGroupPick();
                if (!Dogs_selection.Intersect(Dog_SubGroup).Any())
                {
                    Console.WriteLine("Lists have different elements and cannot be combined.");
                    Dog_SubGroup = DogSubGroup.GetSubGroupPick();
                }
                Dogs_selection = Dog_SubGroup.Intersect(Dogs_selection).ToList();
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(string.Join(", ", Dogs_selection));
                continueLoop = false;
            }
        }
        Console.WriteLine("Now go buy your dream dog!!!");
        return Dogs_selection;
    }
}
