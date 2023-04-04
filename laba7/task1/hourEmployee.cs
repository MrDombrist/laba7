class HourEmployee: Employee,ICLIable
{
    public int Hour { get; set; }
    public override double money()
    {
        return Salary*Hour+ Salary*Hour * Percent / 100;
    }
    public HourEmployee(HourEmployee a) : base(a)
    {
        Hour= a.Hour;
    }
    public HourEmployee() { }
    public override void Input()
    {
        Console.WriteLine("Введите фамилию: ");
        Surname = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите имя: ");
        Name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите дату рождения: ");
        Birth = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Введите пол: ");
        S = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введите почасовую ставку: ");
        Salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите процентнкю ставку премии: ");
        Percent = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите часы работы: ");
        Hour = Convert.ToInt32(Console.ReadLine());
    }
}