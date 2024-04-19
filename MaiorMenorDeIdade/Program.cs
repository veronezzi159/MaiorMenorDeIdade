int idade;

Console.WriteLine("Digite sua idade");
idade = int.Parse(Console.ReadLine());

if (idade >= 0)
{
    if (idade < 18)
    {
        Console.WriteLine("\n Menor de idade");
    } 
    else
    {
        Console.WriteLine("\n Maior de idade");
    }
}