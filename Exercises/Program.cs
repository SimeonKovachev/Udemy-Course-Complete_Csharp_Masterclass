/*Console.WriteLine("Thats very strange typing in c# again");

Console.Beep();

Console.WriteLine("I beeped now type");

string n1 = Console.ReadLine();

Console.WriteLine(n1);*/

//Second video 

/*int number1;

number1 = 2;

int number2 = 30;

int sum = number1 + number2;
Console.WriteLine(sum);*/

/*//Concat strings

string myname = "Simo";

string message = "My name is " + myname;

string messageLower = message.ToLower();

Console.WriteLine(messageLower);*/

//implict conversion
//convert from one bigger type to smaller type for numbers

int num = 132123212;
long myLong = num;

float myFloat = 91.23F;

double newDouble = myFloat;

Console.WriteLine($"long: {myLong} float:{myFloat} double:{newDouble:N2}");



// explict conversion
//casting double to int(returns a whole number)
//cast double to big number

double myDouble = 19.32;

int myInt;

myInt = (int)myDouble;

Console.WriteLine(myInt);


// typeConversion
// converts a double to a string or any number type to a string
string myString = myDouble.ToString();
string myString2 = myFloat.ToString();
bool sunIsShining = false;

string myBoolString = sunIsShining.ToString();

Console.WriteLine(myString2 + ' ' + myString);




