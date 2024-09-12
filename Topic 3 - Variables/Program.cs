// See https://aka.ms/new-console-template for more information
string name, eyes, teeth, hair;
int age, height, weight;

name = "John Smith";
age = 35; // not a lie
height = 74; // inches
weight = 180; // lbs
eyes = "Brown";
teeth = "White";
hair = "Brown";

Console.WriteLine("Let's talk about " + name + ".");
Console.WriteLine("He's " + height + " inches (or " + (height * 2.54) + " cm) tall.");
Console.WriteLine("He's " + weight + " pounds (or " + (weight / 2.2) + " kg) heavy.");
Console.WriteLine("Actually, that's not too heavy.");
Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

//This line is tricky
Console.WriteLine("If I add " + age + ", " + height + ", and " + weight + ", I get " + (age + height + weight) + ".");
Console.WriteLine();

string name1 = "Jonathan";
Console.WriteLine(name1);
name1 = "Jon";
Console.WriteLine(name1);
Console.WriteLine();

int myNumber = 15;
myNumber = 20;
Console.WriteLine(myNumber);
Console.WriteLine();

double height1 = 1.62;
Console.WriteLine(height1);
Console.WriteLine(myNumber + height1);
Console.ReadLine();