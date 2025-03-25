using System.ComponentModel;

namespace Dagsoppgave_backend_uke_2_dag_2;

class Program
{
    static void Main(string[] args)
    {
        //needs some variables

        string? userInput = "";
        string? mainMenuInput = "";
        string? storageMenuInput = "";

        List<int> intStorage = new();
        List<string> intStorageTime = new();

        List<string> stringStorage = new();

        List<double> doubleStorage = new();
        List<string> doubleStorageTime = new();

        List<decimal> decimalStorage = new();
        List<string> decimalStorageTime = new();

        List<float> floatStorage = new();
        List<string> floatStorageTime = new();


        //initializes the main menu loop.
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the input checker and storage.");
            Console.WriteLine("Please enter where you want to go, or enter exit to exit.");
            Console.WriteLine();
            Console.WriteLine(" 1. Here you can write an input and choose if you want to store it.");
            Console.WriteLine(" 2. Here you can look at the different inputs stored.");
            Console.WriteLine(" 3. Here you can see the current date and time");
            Console.WriteLine();
            Console.WriteLine("NB: Should you enter anything except 1, 2, 3, or exit, nothing will happen.");

#pragma warning disable CS8602  //The warning here is accounted for and is just annoying.
            mainMenuInput = Console.ReadLine().ToLower().Trim().Replace(" ", "");

            if (mainMenuInput != null)
            {
                if (mainMenuInput == "1")
                {

                    //input menu loop here
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Please write your input here. Or write back to go back.");
                        userInput = Console.ReadLine().ToLower().Trim().Replace(" ", "");
                        if (userInput != null)
                        {
                            if (int.TryParse(userInput, out int intNumber))
                            {

                                bool intSaveLoop = true;
                                do
                                {

                                    Console.WriteLine($"Your input was the integer {intNumber}.");
                                    Console.WriteLine();
                                    Console.WriteLine("If you'd like to store your input, please enter 1. If not, enter 2 to return to the main menu.");

                                    string? intSaveInput = Console.ReadLine();

                                    //Here I save the input to the list it belongs into, and also the current date and time it was saved
                                    // into another list.
                                    if (intSaveInput != null)
                                    {
                                        switch (intSaveInput)
                                        {
                                            case "1":
                                                intStorage.Add(intNumber);
                                                intStorageTime.Add(DateTime.Now.ToString());
                                                Console.WriteLine($"{intNumber} was added to integer storage. Press enter to return the main menu.");
                                                Console.ReadLine();
                                                intSaveLoop = false;
                                                userInput = "back";
                                                break;

                                            case "2":
                                                intSaveLoop = false;
                                                userInput = "back";
                                                break;
                                            default:
                                                Console.WriteLine("Only enter 1 or 2 please.");
                                                break;
                                        }
                                    }
                                } while (intSaveLoop);
                            }
                            else if (double.TryParse(userInput, out double doubleNumber))
                            {
                                bool doubleSaveLoop = true;
                                do
                                {

                                    Console.WriteLine($"Your input was the double {doubleNumber}.");
                                    Console.WriteLine();
                                    Console.WriteLine("If you'd like to store your input, please enter 1. If not, enter 2 to return main menu.");
                                    string? doubleSaveInput = Console.ReadLine();
                                    if (doubleSaveInput != null)
                                    {
                                        switch (doubleSaveInput)
                                        {
                                            case "1":
                                                doubleStorage.Add(doubleNumber);
                                                doubleStorageTime.Add(DateTime.Now.ToString());
                                                Console.WriteLine($"{doubleNumber} was added to double storage. Press enter to return to main menu.");
                                                Console.ReadLine();
                                                doubleSaveLoop = false;
                                                userInput = "back";
                                                break;

                                            case "2":
                                                doubleSaveLoop = false;
                                                userInput = "back";
                                                break;

                                            default:
                                                Console.WriteLine("Only enter 1 or 2 please.");
                                                break;
                                        }
                                    }
                                } while (doubleSaveLoop);
                            }
                            else if (decimal.TryParse(userInput, out decimal decimalNumber))
                            {

                                bool decimalSaveLoop = true;
                                do
                                {

                                    Console.WriteLine($"Your input was the decimal {decimalNumber}.");
                                    Console.WriteLine();
                                    Console.WriteLine("If you'd like to store your input, please enter 1. If not, enter 2 to return to the main menu.");
                                    //TODO add submenu with save functionality. adds the int to a list.
                                    //intStorage.Add(intNumber);
                                    string? decimalSaveInput = Console.ReadLine();
                                    if (decimalSaveInput != null)
                                    {
                                        switch (decimalSaveInput)
                                        {
                                            case "1":
                                                decimalStorage.Add(decimalNumber);
                                                decimalStorageTime.Add(DateTime.Now.ToString());
                                                Console.WriteLine($"{decimalNumber} was added to decimal storage. Press enter to return to main menu.");
                                                Console.ReadLine();
                                                decimalSaveLoop = false;
                                                userInput = "back";
                                                break;

                                            case "2":
                                                decimalSaveLoop = false;
                                                userInput = "back";
                                                break;
                                            default:
                                                Console.WriteLine("Only enter 1 or 2 please.");
                                                break;
                                        }
                                    }
                                } while (decimalSaveLoop);
                            }
                            else if (float.TryParse(userInput, out float floatNumber))
                            {
                                bool floatSaveLoop = true;
                                do
                                {

                                    Console.WriteLine($"Your input was the float {floatNumber}.");
                                    Console.WriteLine();
                                    Console.WriteLine("If you'd like to store your input, please enter 1. If not, enter 2 to return to the main menu.");
                                    string? floatSaveInput = Console.ReadLine();
                                    if (floatSaveInput != null)
                                    {
                                        switch (floatSaveInput)
                                        {
                                            case "1":
                                                floatStorage.Add(floatNumber);
                                                floatStorageTime.Add(DateTime.Now.ToString());
                                                Console.WriteLine($"{floatNumber} was added to float storage. Press enter to return to main menu.");
                                                Console.ReadLine();
                                                floatSaveLoop = false;
                                                userInput = "back";
                                                break;

                                            case "2":
                                                floatSaveLoop = false;
                                                userInput = "back";
                                                break;
                                            default:
                                                Console.WriteLine("Only enter 1 or 2 please.");
                                                break;
                                        }
                                    }
                                } while (floatSaveLoop);
                            }
                            else if (userInput != "back")
                            {
                                bool stringSaveLoop = true;
                                do
                                {

                                    Console.WriteLine($"Your input was the string {userInput}.");
                                    Console.WriteLine();
                                    Console.WriteLine("If you'd like to store your input, please enter 1. If not, enter 2 to return to the main menu.");
                                    string? stringSaveInput = Console.ReadLine();
                                    if (stringSaveInput != null)
                                    {
                                        switch (stringSaveInput)
                                        {
                                            case "1":
                                                stringStorage.Add(userInput + " was stored at " + DateTime.Now.ToString());
                                                Console.WriteLine($"{userInput} was added to string storage. Press enter to return to main menu.");
                                                Console.ReadLine();
                                                stringSaveLoop = false;
                                                userInput = "back";
                                                break;

                                            case "2":
                                                stringSaveLoop = false;
                                                userInput = "back";
                                                break;
                                            default:
                                                Console.WriteLine("Only enter 1 or 2 please.");
                                                break;
                                        }
                                    }
                                } while (stringSaveLoop);
                            }
                            // else
                            // {
                            //     Console.WriteLine("ERROR: Could not read input! Press enter to go back.");
                            //     Console.ReadLine();
                            // }
                        }


                    } while (userInput != "back");
                }
                else if (mainMenuInput == "2")
                {
                    //initializes the storage menu loop, which closes if the user enters back.
                    // if the storage chosen is not empty, it will print out the contents of the list
                    //if it is, the program prints out a message saying it is empty.
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("This is the storage menu. What type of storage would you like to view the contents of?");
                        Console.WriteLine();
                        Console.WriteLine(" 1. String storage");
                        Console.WriteLine(" 2. Integer storage");
                        Console.WriteLine(" 3. Double storage");
                        Console.WriteLine(" 4. Decimal storage");
                        Console.WriteLine(" 5. Float storage");
                        Console.WriteLine();
                        Console.WriteLine(" Please enter your selection below, or enter back to go back.");

                        storageMenuInput = Console.ReadLine().ToLower().Trim().Replace(" ", "");

                        //Making sure that only the valid inputs will work, and the list out the contents of the 
                        // storage variables.
                        // Also lists the time they were input
                        if (storageMenuInput != null)
                        {
                            switch (storageMenuInput)
                            {
                                case "1":
                                    if (stringStorage.Count > 0)
                                    {
                                        Console.WriteLine("These are the strings currently stored, and at what time they were stored.");
                                        Console.WriteLine();
                                        Console.WriteLine("--------------------------------------");
                                        foreach (var strings in stringStorage)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"The string {strings}");
                                            Console.WriteLine();
                                        }
                                        Console.WriteLine("--------------------------------------");
                                        Console.WriteLine();
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The String storage is empty");
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;
                                    }

                                case "2":
                                    if (intStorage.Count > 0)
                                    {
                                        //Here I zip the timestorage and intstorage together
                                        var typeTimeInt = intStorage.Zip(intStorageTime, (first, second) => first + " was input at " + second);

                                        Console.WriteLine("These are the Integers currently stored, and at what time they were stored.");
                                        Console.WriteLine();
                                        Console.WriteLine("--------------------------------------");
                                        foreach (var ints in typeTimeInt)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"The integer {ints}");
                                            Console.WriteLine();
                                        }
                                        Console.WriteLine("--------------------------------------");
                                        Console.WriteLine();
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The Integer storage is empty");
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;
                                    }
                                case "3":
                                    if (doubleStorage.Count > 0)
                                    {
                                        var typeTimeDouble = doubleStorage.Zip(doubleStorageTime, (first, second) => first + " was input at " + second);

                                        Console.WriteLine("These are the doubles currently stored.");
                                        Console.WriteLine();
                                        Console.WriteLine("--------------------------------------");
                                        foreach (var doubles in typeTimeDouble)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine($"The double {doubles}");
                                            Console.WriteLine();

                                        }
                                        Console.WriteLine("--------------------------------------");
                                        Console.WriteLine();
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine("The Double storage is empty");
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;

                                    }
                                case "4":
                                    if (decimalStorage.Count > 0)
                                    {
                                        var typeTimeDecimal = decimalStorage.Zip(decimalStorageTime, (first, second) => first + " was input at " + second);
                                        Console.WriteLine("These are the decimals currently stored.");
                                        Console.WriteLine();
                                        Console.WriteLine("--------------------------------------");
                                        foreach (var decimals in typeTimeDecimal)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine(decimals);
                                            Console.WriteLine();
                                        }
                                        Console.WriteLine("--------------------------------------");
                                        Console.WriteLine();
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine("The Decimal storage is empty");
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;

                                    }
                                case "5":
                                    if (floatStorage.Count > 0)
                                    {
                                        var typeTimeFloat = floatStorage.Zip(floatStorageTime, (first, second) => first + " was input at " + second);
                                        Console.WriteLine("These are the floats currently stored.");
                                        Console.WriteLine();
                                        Console.WriteLine("--------------------------------------");
                                        foreach (var floats in typeTimeFloat)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine(floats);
                                            Console.WriteLine();
                                        }
                                        Console.WriteLine("--------------------------------------");
                                        Console.WriteLine();
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine("The Float storage is empty");
                                        Console.WriteLine("Press enter to return to the previous menu");
                                        Console.ReadLine();
                                        break;

                                    }
                                default:
                                    Console.WriteLine("Please only enter a whole number between 1 and 5, or back.");
                                    break;
                            }
                        }


                    } while (storageMenuInput != "back");
                }
                else if (mainMenuInput == "3")
                {
                    Console.WriteLine($"This is the current UTC date and time: {DateTime.UtcNow}");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to return to main menu.");
                    Console.ReadLine();
                }
                //Error message in case it's anything except the given options
                else if (mainMenuInput != "exit")
                {
                    Console.WriteLine("Please only enter a whole number between 1 and 3, or exit.");
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                }
            }

        } while (mainMenuInput != "exit");
    }
}
