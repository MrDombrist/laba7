
class Employee : Person,ICLIable
{
    public double Salary { get; set; }
    public double Percent { get; set; }
    public Employee(string surname, string name, DateTime birth, char s, double salary, double percent) : base(surname, name, birth, s)
    {
        Salary = salary;
        Percent = percent;
    }
    public Employee() { }
    public Employee(Employee a) : base(a)
    {
        Salary = a.Salary;
        Percent = a.Percent;
    }
    public override void Input()
    {
        base.Input();
        Console.WriteLine("Введите оклад: ");
        Salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите процентнкю ставку премии: ");
        Percent = Convert.ToDouble(Console.ReadLine());
    }
    public override void Output()
    {
        base.Output();
        Console.WriteLine(" итоговый доход: " + itog());
    }
    public override string ToString()
    {
        return Surname + " " + Name[0] + ". " + fullage() + " " + S + " " + Salary + " " + Percent + " " + itog();
    }
    virtual public double money()
    {
        return Salary + Salary * Percent/100;
    }
    public double nalog()
    {
        return money() * 0.13;
    }
    public double itog()
    {
        return money() - nalog();
    }
}
