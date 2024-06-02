using System;

public class Program
{
    public static void Main(string[] args)
    {
        // We interact with the user to discover the speed of the hurricane
        Console.WriteLine("Hello user\nEnter the hurricane's sustained wind speed in numerical mph: ");

        // Here is where we initialize a string to collect the hurricane speed data
        var windSpeed = Console.ReadLine();

        // Here we are declaring a placeholder variable to be used in order to determine if we have entered a correct value for a hurricane speed
        double wind;

        // Here we are asking the program if we can parse the user data collected in the var windSpeed and use it as a double for a switch statement
        if (double.TryParse(windSpeed, out wind))
        {
            // Here is where the swtich statement begins
            switch (wind)
            {
              // If the user data is greater or equal to 157
              case >= 157:
                  // We notify the user they are in the midst of a category 5 hurricane
                  Console.WriteLine("Category Five Hurricane");
                  break;
              // If the user data is greater or equal to 130
              case >= 130:
                  // We notify the user they are in the midst of a category 4 hurricane
                  Console.WriteLine("Category Four Hurricane");
                  break;
              // If the user data is greater or equal to 111
              case >= 111:
                  // We notify the user they are in the midst of a category 3 hurricane
                  Console.WriteLine("Category Three Hurricane");
                  break;
              // If the user data is greater or equal to 96
              case >= 96:
                  // We notify the user they are in the midst of a category 2 hurricane
                  Console.WriteLine("Category Two Hurricane");
                  break;
              // If the user data is greater or equal to 74
              case >= 74:
                  // We notify the user they are in the midst of a category 1 hurricane
                  Console.WriteLine("Category One Hurricane");
                  break;
              // If the user data does not meet any of the previous conditions
              default:
                  // We notify the user they are not seeing a Hurricane
                  Console.WriteLine("Not a Hurricane");
                  break;
            }
        }
        // If the user input is not a number
        else
        // Inform the user they did not enter a valid hurricane wind speed
        { Console.WriteLine("I'm sorry, I asked you to write a valid hurricane wind speed."); }
        
    }
}