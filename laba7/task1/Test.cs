
//Console.WriteLine("Сколько человек вы хотите ввести? ");
//int n= Convert.ToInt32(Console.ReadLine());
//HourEmployee[] a=new HourEmployee[n];
//for(int i = 0; i < n; i++)
//{
//    a[i] = new HourEmployee();
//    a[i].Input();   
//}
//foreach(Employee e in a)
//{
//    e.Output();
//}
//Console.WriteLine("Cуммы, начисленной работникам: "+ sum(a));
//Console.WriteLine("Cуммы уплаченных налогов для массива работников: "+per(a));
//Console.Write("объект работника с наибольшей полученной на руки суммой: "+ na(a));

//static Employee na(Employee[] a)
//{
//    int k=0;
//    for (int i = 1; i < a.Length; i++) {
//        //double c = a[i].itog(), d = a[k].itog();
//        if (a[i].itog() > a[k].itog())
//        {
//            k = i;
//        }
//    }
//    return a[k];
//}
//static double sum(Employee[] a)
//{
//    double sum = 0;
//    for (int i = 0; i < a.Length; i++) {
//        sum += a[i].itog();
//    }
//    return sum;
//}
//static double per(Employee[] a)
//{
//    double per = 0;
//    for (int i = 0; i < a.Length; i++)
//    {
//        per += a[i].nalog();
//    }
//    return per;
//}
