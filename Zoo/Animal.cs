namespace Zoo;

public class Animal
{
    private string _message;
    private readonly string _name; //set once only

    public Animal(string name)
    {
        _message = "Rainbows are fun";
        _name = name;
    }

    public void ChangeMessage(string message)
    {
        _message = message;
    }

    public void PrintMessage()
    {
        Console.WriteLine($"{_name}'s message is: {_message}");
    }
}