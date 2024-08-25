using services;

namespace commands;

public class ComplexCommand : ICommand
{
    private Receiver _receiver;
    private string _a;
    private string _b;

    public ComplexCommand(Receiver receiver, string a, string b) {
        _receiver = receiver;
        _a = a;
        _b = b;
    }

    public void Execute()
    {
        Console.WriteLine($"ComplexCommand: Complex stuff should be done by a receiver object.");
        this._receiver.DoSomething(this._a);
        this._receiver.DoSomething(this._b);
    }
}
