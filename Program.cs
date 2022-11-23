Console.WriteLine(value:"Введите первое число ");
int num1 = Convert.ToInt32 (value: Console.ReadLine());
Console.WriteLine(value:"Введите второе число ");
int num2 = Convert.ToInt32 (value: Console.ReadLine());
Console.WriteLine(value:"Введите третье число ");
int num3 = Convert.ToInt32 (value: Console.ReadLine());
int max = num1;   
    
    if(num2 > max)
{        max = num2;
    if(num3 > max)
        max = num3;
    
}
    Console.Write("Максимальное число ");
    Console.WriteLine(max);
