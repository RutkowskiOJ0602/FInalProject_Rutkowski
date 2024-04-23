// See https://aka.ms/new-console-template for more information
using DogBreedPicker;
using System.Text.RegularExpressions;

public static partial class Program
{
    public static void Main()
    {
        //describe the westminster dog groups
        Console.WriteLine("Welcome to the dog breed picker program. The following is information based on the seven dog groups in the Westminster Kennel Club");
        Console.WriteLine("The hound group consists of dogs originally used for hunting");
        Console.WriteLine("While The toy group dogs do not perform outdoor tasks, they provide their owners love and companionship");
        Console.WriteLine("Terriers originally were breed to pursue their quarry of vermin");
        Console.WriteLine("All herding dog breeds share the innate skill of guiding and controlling other animals' movements. Thus, they'd be perfect for working on a farm");
        Console.WriteLine("The dogs in the working group perform jobs like guarding property, pulling sleds, and performing water rescues. Many of these breeds also serve as draft animals, and as police, military, and service dogs");
        Console.WriteLine("The sporting group includes gun dogs developed to assist hunters");
        Console.WriteLine("The non-sporting group consist of dogs that do not fit into the other categories");
        // get a value for group based on the person's input
        Console.WriteLine("Type in the input as Hounds, Toy, Terriers, Herding, Working. Sporting, or Non-Sporting");
        List<string> Dog_Group = DogGroup.GetGroupPick();
        Dog_Group = DogGroup.ContinuePickGroup(Dog_Group);
        List<string> Dog_SubGroup = DogSubGroup.GetSubGroupPick();
        if (!Dog_SubGroup.Intersect(Dog_Group).Any())
        {
            Console.WriteLine("Lists have different elements and cannot be combined.");
            Dog_SubGroup = DogSubGroup.GetSubGroupPick();
        }
        List<string> Dogs_selection = Dog_SubGroup.Intersect(Dog_Group).ToList();
        Dogs_selection = DogSubGroup.ContinueSubGroupPick(Dogs_selection);
        string price = Prices.GetDogPrice();
        Console.WriteLine("Now go get your dream dog!!!");
    }
}
