Console.WriteLine("Informe o salário do funcionário:");
float s = float.Parse(Console.ReadLine());
Console.WriteLine("1. Imposto:");
Console.WriteLine("2. Novo salario:");
Console.WriteLine("3. Classificação:");
Console.WriteLine("Digite a opção desejada.");
int opcao = int.Parse(Console.ReadLine());

switch (opcao){
    case 1:
    if (s < 500)
    Console.WriteLine("O imposto sobre o salário é de 5% e equivale a R$" + (s * 0.95f));

    if (s <= 850 & s >= 500)
    Console.WriteLine("O imposto sobre o salário é de 10% e equivale a R$" + (s * 0.90f));

    if (s > 850)
    Console.WriteLine("O imposto sobre o salário é de 15% e equivale a R$" + (s * 0.85f));

    break;

    case 2:
    if (s < 1500)
    Console.WriteLine("O salário sofre um aumento de R$25,00" + (s + 25));

    if (s >= 750 & s <= 1500)
    Console.WriteLine("O salário sofre um aumento de R$50,00" + (s + 50));

    if (s >= 450 & s <= 750)
    Console.WriteLine("O salário sofre um aumento de R$75,00" + (s + 75));

    if (s < 450)
    Console.WriteLine("O salário sofre um aumento de R$100,00" + (s + 100));

    break;

    case 3:
    if (s <= 700)
    Console.WriteLine("Mal remunerado:");
    else
    Console.WriteLine("Bem remunerado:");

    break;

    default:
    Console.WriteLine("Opção Inválida");
    break;

}