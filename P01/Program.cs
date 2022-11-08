using System.Runtime.Serialization;
int soma = 0;
int media, nota = 0;
int i;
int t;
Console.WriteLine("Informe quantas notas deseja inserir: ");
t = Convert.ToInt32(Console.ReadLine());
do
{
    for (i = 0; i < t; i++)
    {
        Console.Write("Informe a nota: ");
        nota = Convert.ToInt32(Console.ReadLine());
        soma = soma + nota;
    }
    media = soma / t;
} while (nota < 0 || nota > 10);
Console.WriteLine("A média final foi: " + media);
Console.ReadKey();
