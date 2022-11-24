Console.Write(value:"Введите число ");
int n = Convert.ToInt32 (value: Console.ReadLine());

for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);