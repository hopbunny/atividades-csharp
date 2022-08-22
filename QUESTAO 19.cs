// See https://aka.ms/new-console-template for more information

Console.WriteLine ("1. Somar dois números");
Console.WriteLine ("2. Raiz Quadrada de um número");
Console.WriteLine ("Informe uma opção:");
int opcao = int.Parse(Console.ReadLine());

switch (opcao){
    case 1:
        Console.WriteLine("Informe dois número:");
        float num = float.Parse(Console.ReadLine());
        float num1 = float.Parse(Console.ReadLine());
        num = num + num1;
        Console.WriteLine("O resultado é:" + num);
    break;
    case 2:
    Console.WriteLine("Informe um número:");
    double raiz = double.Parse(Console.ReadLine());
    raiz = Math.Pow(raiz,0.5);
    Console.WriteLine("O resultado é:" + raiz);
    break;
    default:
        Console.WriteLine("Opcção Inválida");
    break;
}