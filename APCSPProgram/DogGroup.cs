using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class DogGroup
{
    // create a dictionart to hold the lists based on the groups
    public static Dictionary<string, List<string>> Groups = new Dictionary<string, List<string>>
    {
        ["Hounds"] = new List<string> { "Basset Hound", "Beagle", "Bloodhound", "Dachshund", "Greyhound", "Rhodesian Ridgeback" },
        ["Toy"] = new List<string> { "Chihuahua", "Havanese", "Maltese", "Papillon", "Pekingese", "Pomeranian", "Toy Poodle", "Pug" },
        ["Terriers"] = new List<string> { "Airedale Terrier", "Cairn Terrier", "Miniature Schnauzer", "Jack Russell Terrier", "Bull Terrier" },
        ["Herding"] = new List<string> { "German Shepherd", "Australian Shepherd", "Border Collie", "Spanish Water Dog", "Pembroke Welsh Corgi", "Shetland Sheepdog" },
        ["Working"] = new List<string> { "Samoyed", "Standard Schnauzer", "Alaskan Malamute", "Bernese Mountain Dog", "Boxer", "Doberman Pinscher", "Great Dane", "Mastiff", "Newfoundland", "Rottweiler", "Siberian Husky" },
        ["Sporting"] = new List<string> { "English Cocker Spaniel", "American Cocker Spaniel", "German Shorthaired Pointer", "Golden Retriever", "Irish Setter", "Labrador Retriever" },
        ["Non-Sporting"] = new List<string> { "Boston Terrier", "Dalmatian", "Chow Chow", "French Bulldog", "Miniature Poodle", "Standard Poodle", "Shiba Inu" }
    };
    public static List<string> GetGroupPick()
    {
        string? Group_pick = Console.ReadLine();
        // create if statements to assign Group as the list
        List<string> Group = new List<string>();
        if (Groups.TryGetValue(Group_pick, out List<string> selectedGroup))
        {
            Group = selectedGroup;
            return Group;
        }
        else
        {
            // Handle the case when the group is invalid
            Console.WriteLine("Invalid group selection");
            return Group;
        }
    }
    public static List<string> ContinuePickGroup(List<string> Dog_Group)
    {
        bool continueLoop = true;
        while (continueLoop)
        {
            Console.WriteLine("Would you like to add another group? Type 'y' if yes.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                continueLoop = true;
                Console.WriteLine(' ');
                Console.WriteLine("Type in the input as Hounds, Toy, Terriers, Herding, Working. Sporting, or Non-Sporting");
                List<string> Dog_Group2 = DogGroup.GetGroupPick();
                Dog_Group = Dog_Group.Concat(Dog_Group2).ToList();
            }
            else
            {
                Console.WriteLine(" ");
                continueLoop = false;
            }
        }
        return Dog_Group;
    }
}