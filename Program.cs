using System;

namespace URL_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string yn = "y";

            while (yn == "y")
            {
                string project; 
                Console.WriteLine("Enter the name of your project: ");
                project = Console.ReadLine();

                while(IsValid(project) !=true)
                {
                    Console.WriteLine("Please enter a project that is valid.");
                    Console.WriteLine("Enter the name of the project: ");
                    project = Console.ReadLine();

                }

                string activity;
                Console.WriteLine("Enter the name of the activity: ");
                activity = Console.ReadLine();

                while(IsValid(activity) != true)
                {
                    Console.WriteLine("Plese enter an activity that is valid.");
                    Console.WriteLine("Enter the name of the activity: ");
                    activity = Console.ReadLine();

                }
                Console.WriteLine("Generating URL...\n");

                string url = ("https://companyserver.com/content/") + project + ("/files/") + activity + "/" + activity + "report";
                Console.WriteLine("{0}", url);

                Console.WriteLine("Would you like to create another URL? type y/n: ");
                yn = Console.ReadLine();

            }
        }
        static bool IsValid(string input)
        {
            foreach(char character in input.ToCharArray())
            {
                if (character == 0x1F)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
