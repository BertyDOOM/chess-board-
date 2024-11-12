int A = 1; int B = 2; int C = 3; int D = 4; int E = 5; int F = 6; int G = 7; int H = 8; int цифра = 1; //a)
Console.WriteLine("Изберете буква на квадратчето от която да започне ред (от A-H, главна)");
string буква = Console.ReadLine();
switch (буква)
{
    case "A":
        while (A < 9)
        {
            цифра++;
            A++;
            Console.WriteLine("A" + цифра + " = " + A);

        }
        break;
    case "B":
        while (B < 10)
        {
            цифра++;
            B++;
            Console.WriteLine("B" + цифра + " = " + B);
        }
        break;
    case "C":
        while (C < 11)
        {
            цифра++;
            C++;
            Console.WriteLine("C" + цифра + " = " + C);
        }
        break;
    case "D":
        while (D < 12)
        {
            цифра++;
            D++;
            Console.WriteLine("D" + цифра + " = " + D);
        }
        break;
    case "E":
        while (E < 13)
        {
            цифра++;
            E++;
            Console.WriteLine("E" + цифра + " = " + E);
        }
        break;
    case "F":
        while (F < 14)
        {
            цифра++;
            F++;
            Console.WriteLine("F" + цифра + " = " + F);
        }
        break;
    case "G":
        while (G < 15)
        {
            цифра++;
            G++;
            Console.WriteLine("G" + цифра + " = " + G);
        }
        break;
    case "H":
        while (H < 16)
        {
            цифра++;
            H++;
            Console.WriteLine("H" + цифра + " = " + H);
        }
        break;
}
int общо; int Аред;  //b)
int a = 1; int b = 2; int c = 3; int d = 4; int e = 5; int f = 6; int g = 7; int h = 8; //защото вече една от по горните променливи е променена
общо = a + b + c + d + e + h + g + f;
Аред = a + b + c + d + e + h + g + f;
int whi_le = 1; int nov_red_navytre =8;
while (whi_le < 8)
{
    общо += nov_red_navytre;
    общо += Аред;
    break;    
}
Console.WriteLine("От " + общо);

