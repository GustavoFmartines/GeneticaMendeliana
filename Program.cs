Console.Clear();

string NormalizaAlelo(string alelos)
{
    char[] chars = alelos.ToUpper().ToCharArray();

    Array.Sort(chars);
    Array.Reverse(chars); 

    return new string(chars);
}

Console.WriteLine("Alelos da Mãe (AA, Aa ou aa): ");
    String AleloM = NormalizaAlelo(Console.ReadLine()!).Substring(0, 2);

Console.WriteLine("Alelos do Pai (AA, Aa ou aa): ");
    String AleloP = NormalizaAlelo(Console.ReadLine()!).Substring(0, 2);

Console.WriteLine("Tipo de dominância (C/I): ");
    String domi = Console.ReadLine()!;

string AleloM1 = AleloM.Substring(0, 1);
string AleloM2 = AleloM.Substring(1, 1);

string AleloP1 = AleloP.Substring(0, 1);
string AleloP2 = AleloP.Substring(1, 1);


Console.WriteLine(@$"

   | {AleloM1} | {AleloM2} 
---------------------------------------
{AleloP1} | {AleloM1}{AleloP1} | {AleloM2}{AleloP1}
---------------------------------------
{AleloP2} | {AleloM1}{AleloP2} | {AleloM2}{AleloP2}
");
