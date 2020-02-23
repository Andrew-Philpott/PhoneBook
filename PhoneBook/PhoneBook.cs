using System;
using System.Collections.Generic;

namespace PhoneBook {
  public class PhoneBook
  {
    public string Name { get; set; }
    public Dictionary<string, string> phoneNumbers { get; set; }
    public PhoneBook(string name) {
      Name = name;
    }

    public void AddContact(string name, string number) {
      if(phoneNumbers.ContainsKey(name)) {
        Console.WriteLine(name + " is already in your phone book, their number is " + phoneNumbers[name]);
      } else {
        phoneNumbers.Add(name, number);
      }
    }

    public void LookUpContact(string name) {
      if(phoneNumbers.ContainsKey(name)) {
        Console.WriteLine(name + "\'s phone number is: " + phoneNumbers[name]);
      } else {
        Console.WriteLine(name + " is not listed in your phone book");
      }
    }
  }
}
