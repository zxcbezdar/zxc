Console.WriteLine("значение a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("значение b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("значение с");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a^3-3a^2b+3ab^2-b^3=(a-b)^3");
int reshenie_1 = Convert.ToInt32(Math.Pow(a - b, 3));
Console.WriteLine($"({a}-{b})^3 = {reshenie_1} при а={a}, b={b}");
Console.WriteLine("a^3+3a^2b+3ab^2+b^3 = (a + b)^3");
int reshenie_2 = Convert.ToInt32(Math.Pow(a + b, 3));
Console.WriteLine($"({a} + (b])^3 = {reshenie_2} при a-(a), b=(b]");
Console.WriteLine("(a+b)(a^2-ab+b^2)=a^3+b^3");
int al = Convert.ToInt32(Math.Pow(a, 3));
int b1 = Convert.ToInt32(Math.Pow(b, 3));
int reshenie_3 = al + b1;
Console.WriteLine($"{a}^3+{b}^3={reshenie_3}при а={a},b={b}");
Console.WriteLine("(a-b)(a^2+ab+b^2)=a^3 - b^3");
int a2 = Convert.ToInt32(Math.Pow(a, 3));
int b2 = Convert.ToInt32(Math.Pow(b, 3));
int reshenie_4 = a2 - b2;
Console.WriteLine($"{a}^3 - {b}^3 = {reshenie_4} при a={a}, b={b}");





