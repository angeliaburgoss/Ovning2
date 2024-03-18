// Angelia Burgos Zamora
// angeliaburgos55@gmail.com


namespace ovning2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program");

        // the bool variable "Continue" must be true for the while loop to run

        bool Continue = true;

        while (Continue)

        {
            //writes out the menu to the user
            Console.WriteLine("Choose the action you want to do:");
            Console.WriteLine("1. Check age for cinema entrance");
            Console.WriteLine("2. Check price for a group ");
            Console.WriteLine("3. Text repitition x10");
            Console.WriteLine("4. Output of third word");
            Console.WriteLine("0. Exit");

            //store the user input in a string variabble
            string input = Console.ReadLine();

            // this is the sceleton for the program, depending on the user input, a case will run
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter your age");
                    string age = Console.ReadLine();
                    Console.WriteLine(CheckAge(age));
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine("Enter number of people");
                    string amountPeople = Console.ReadLine();
                    CheckPriceGroup(amountPeople);
                    break;

                case "3":
                    Console.WriteLine("Enter a text");
                    string inputText = Console.ReadLine();
                    outputText(inputText);
                    break;

                case "4":
                    thirdWord();
                    break;

                case "0":
                    Continue = false;
                    Console.WriteLine("End of program");
                    break;

                default:
                    Console.WriteLine("Wrong input, the input must be between 1-4");
                    break;


            }


        }

    }

    // Method for checking age, executes when invoked by case 1
    static string CheckAge(string age)

    {
        // checks if age is lower than 20 or higher than 64 and returns the price for respective age
        // converts a string value to an integer
        int age2 = int.Parse(age);

        if (age2 < 20 || age2 > 64)
        {
            if (age2 < 20)
            {
                return "Youth price: 80 kr";
            }
            if (age2 > 64)
            {
                return "Senior price: 90 kr";
            }
        }

        // other ages between 20 and 64, the price is returned for those ages

        else
        {
            return "Standard price: 120 kr";
        }

        return "";


    }


    // Method for checking a groups entree price, executes when invoked by case 2
    static void CheckPriceGroup(string amountPeople)
    {
        // converts a string value to an integer
        int amountPeople2 = int.Parse(amountPeople);

        // total is set to a default value 0
        int total = 0;

        // loops through x amount of times depending on the users input and asks for their age to calculate the entry fee for the group
        for (int i = 0; i < amountPeople2; i++)
        {
            Console.WriteLine("Enter the age of person: " + (i + 1));
            int agePeople = int.Parse(Console.ReadLine());

            if (agePeople < 20)
            {
                total += 80;
            }

            else if (agePeople > 64)
            {
                total += 90;
            }

            else
            {
                total += 120;
            }
        }

        Console.WriteLine("Number of people: " + amountPeople);
        Console.WriteLine("Total cost for group: " + total + "kr");
        Console.WriteLine();
    }


    // Method for output users input ten times
    static void outputText(string inputText)
    {
        string text = "";

        // for each iteration the text variable is added with the same input
        for (int i = 0; i < 10; i++)
        {
            text += (i + 1) + ". " + inputText + ", ";
        }

        Console.WriteLine(text);
        Console.WriteLine();

    }


    // Method for spiliting out the third word of a users input
    static void thirdWord()
    {
        Console.WriteLine("Enter a sentece with minimum three words");

        var sentence = Console.ReadLine();

        // splits up the sentence into words by whitespace
        string[] words = sentence.Split(' ');

        // checks if the sentence has three or more words 
        if (words.Length >= 3)
        {
            // prints out the thirds words of the sentence by indexing number 2
            Console.WriteLine("The third word of the sentence is: " + words[2]);
        }

        else
        {
            Console.WriteLine("Wrong input, sentence is less than three words");
        }


        Console.WriteLine();
    }

}


