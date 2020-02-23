using System;
using System.Collections.Generic;
using PhoneBook;
class Program
{
  public static PhoneBook.PhoneBook phoneBook;

  static void Continue() {
    Console.WriteLine("Would you like to add a name to your phone book? ['Y' for yes, 'Enter 'for no]");
    string answer = Console.ReadLine();
    if(answer == "Y" || answer == "y") {
      Console.WriteLine("Enter a name");
      string newName = Console.ReadLine();
      Console.WriteLine("Enter a number");
      string newNumber = Console.ReadLine();
      phoneBook.AddContact(newName, newNumber);
      Continue();
    } else {
      Console.WriteLine("Would you like to look up a number in your phone book? ['Y' for yes, 'Enter 'for no]");
      string lookUpAnswer = Console.ReadLine();
      if(lookUpAnswer == "Y" || lookUpAnswer == "y") {
        Console.WriteLine("Enter a name");
        string lookUpNumber = Console.ReadLine();
        phoneBook.LookUpContact(lookUpNumber);
        Continue();
      } else {
        Console.WriteLine("Are you finished with the program? ['Y' for yes, 'Enter 'for no]");
        string finishedAnswer = Console.ReadLine();
        if (finishedAnswer == "Y" || finishedAnswer == "y")
        {
          Console.WriteLine("Goodbye.");
        }
        else
        {
          Continue();
        }
      }
    }
  }
  static void Main()
  {
    Console.WriteLine("Please enter your name");
    string name = Console.ReadLine();
    phoneBook = new PhoneBook.PhoneBook(name);
    Console.WriteLine("Hello " + name);
    Continue();
  }
}