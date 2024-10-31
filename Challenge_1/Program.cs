//Challenge 1
Console.Write("Gebe Ergebnis ein: ");
double ergebnis = Convert.ToDouble(Console.ReadLine());
if(ergebnis > 1 || ergebnis < 0.6)
{
    Console.WriteLine("sould be F");
}
else if( ergebnis >= 0.9)
{
    Console.WriteLine("sould be A");
}
else if (ergebnis >= 0.8)
{
    Console.WriteLine("sould be B");
}
else if (ergebnis >= 0.7)
{
    Console.WriteLine("sould be C");
}
else if (ergebnis >= 0.6)
{
    Console.WriteLine("sould be D");
}