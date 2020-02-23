# _PhoneBook_
#### _PhoneBook_, 02.23.2020_
#### By _**Andrew Philpott**_
## Description
_The application allows a user to add and lookup name/phone number pairs using a console based interface._

## Specs
* _Spec: The application should be able to let the user enter their name and have it say hello back to them.
  * Input: "Andrew"
  * Output: "Hello Andrew"

* _Spec: The application should inform the user that a name already exists in the phone book if they try to use the same name twice.
  * Input: "Andrew" "Andrew"
  * Output: "Andrew is already in your phone book, their number is..."

* _Spec: The application should let the user add a name and phone number to a book if the name doesn't exist in the phonebook already.
  * Input: "Andrew" "2062222222"
  * Output:

* _Spec: The application should inform the user that a name doesn't exist in their phone book if it hasn't been added to the phone book.
  * Input: Lookup "Andrew" without adding "Andrew" to phonebook 
  * Output: "Andrew is not listed in your phone book"

* _Spec: The application should return the name and number of a name that they wanted to lookup.
  * Input: Lookup "Andrew"
  * Output: "Andrew's phone number is: 2062222222"

## Setup/Installation Requirements
_Clone this repository._

_dotnet build_

_dotnet run_

## Support and contact details
_Issues or concerns? Contact us at andrewphilpott92@gmail.com_

## Technologies Used
_C#_

### License
Copyright (c) 2020 **_Andrew Philpott_**

*This software is licensed under the MIT license.*
