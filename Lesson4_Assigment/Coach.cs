using Lesson4;

internal class Coach : Person
{
    private int _experience;

    public int Experience
    {
        get { return _experience; }
        set { _experience = value; }
    }

    public Coach()
    {
    }
    public Coach(int code, string name, string address, string position, double salary, int experience)
        : base(code, name, address, position, salary)
    {
        Experience = experience;
    }

    public override string? ToString()
    {
        return base.ToString() + "\t" + Experience;
    }

}