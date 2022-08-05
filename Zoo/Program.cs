// See https://aka.ms/new-console-template for more information

using Zoo;

var bob=new Animal("Bob");
var sunshine = new Animal("Sunshine");

sunshine.PrintMessage();


bob.PrintMessage();
bob.ChangeMessage("Changing Message");

sunshine.ChangeColour("blue");
sunshine.PrintMessage();


bob.PrintMessage();//one shared colour 

