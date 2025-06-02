// Receba um número e logo em seguida exiba sua tabuada.

Console.Clear();

Console.WriteLine("Digite um número para ver sua tabuada:");
string entrada = Console.ReadLine()!;

if (int.TryParse(entrada, out int numero))
{
    Console.Clear();
    Console.WriteLine($"Tabuada do {numero}:\n");
    for (int i = 1; i <= 10; i++)
    {
        int resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.Clear();
    Console.WriteLine("Por favor, digite um número válido!");
}