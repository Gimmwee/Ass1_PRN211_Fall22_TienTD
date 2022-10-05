using Lesson4;
using System;

internal class Player : Person

{
    private int _number;

    public int Number
    {
        get { return _number; }
        set { _number = value; }
    }

    public Player()
    {
    }

    public Player(int code, string name, string address, int number, string position, double salary)
        : base(code, name, address, position, salary)
    {
        Number = number;
    }

    public override string? ToString()
    {
        return base.ToString() + String.Format("{0,-10}", Number);
    }
}
