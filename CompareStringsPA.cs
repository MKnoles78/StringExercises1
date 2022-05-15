//Michael Knoles
//Unit 1.7 PA: CompareStringsPA.cs
//Comparing strings: Pseudocode
    //Take in user input for two values
    //Store values into strings
    //Compare values using CompareTo
    //Output whether first string is less than, equal to or greater than the second value by comparing lengths of inputs
using System;

class CompareStringsPA
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("\nEnter your userName");
        string userName = Console.ReadLine();
        //take in first input value
        Console.WriteLine("\nWelcome {0}! Please enter a password: ", userName);
        string password = Console.ReadLine();          
        
        Console.WriteLine("\nThank you, {0}! Please reenter your password: ", userName);
        string newPassword = Console.ReadLine();
        int status = newPassword.CompareTo(password);
        Console.WriteLine(status);
        // if password when compared to previous password is true, then it returns this message.
        if (status == 0)
        {
            Console.WriteLine("\nYour password is {0}: ", password);
            Console.WriteLine("The new password {0} equals your old password {1}. ", newPassword, password);
            Console.WriteLine("Your password has been stored.\n");
        }
        // else if password when compared to previous is false, then it returns this message.
        else if (status != 0)
        {
            if (password.Length < newPassword.Length)
                {
                Console.WriteLine("\nYour second password entry {0} is greater than your previous password {1} and doesn't match: ", newPassword, password);
                Console.WriteLine("Passwords should match. You will need to renter your password.\n");
                }
            else if (password.Length > newPassword.Length)
                {
                Console.WriteLine("\nYour second password entry {0} is less than your previous password {1} and doesn't match: ", newPassword, password);
                Console.WriteLine("Passwords should match. You will need to renter your password.\n");
                }
            else
                {
                Console.WriteLine("\nYour entries are the same length, but do not match: initial {0}, reentry {1}", password, newPassword); 
                Console.WriteLine("Passwords should match. You will need to renter your password.\n");              
                }
        }
    } //end Main
} //end class CompareStringsPA