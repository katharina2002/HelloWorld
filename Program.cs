// Kleiner Taschenrechner
/* 15.06.2023 Katharina Wolf
 * einfacher Taschenrechner
 */
double a, b, erg;
string rechnen;
Console.WriteLine("kleiner Taschenrechner");

Console.WriteLine("Wie ist die erste Zahl?");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Wie ist die zweite Zahl?");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Soll mit +, -, * oder / gerechnet werden?");
rechnen = Console.ReadLine();

if (rechnen == "+")
{
    erg = a + b;
} else if (rechnen == "-")
{
    erg = a - b;
} else if (rechnen == "*")
{
    erg = a * b;
} else
{
    erg = a / b;
}

Console.WriteLine("{0} {1} {2} = {3}", a, rechnen, b, erg);