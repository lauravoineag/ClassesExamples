namespace Zoo;

public class Animal
{
    private string _message; //instance field 
    private readonly string _name; //instance field - but can only be set once & it never changes
    private static string _colour;// every animal sees the same colour, if any animal changes it every animal sees the value
    
    public Animal(string name)
    {
        _message = "Rainbows are fun";
        _name = name;
        _colour = "grey"; //default value
    }

    public void ChangeMessage(string message)
    {
        _message = message;
    }

    public void PrintMessage()
    {
        Console.WriteLine($"{_name}'s message is: {_message} and their least favourite colour is {_colour}");
    }

    public void ChangeColour(string colour)
    {
        _colour = colour;
    }
}