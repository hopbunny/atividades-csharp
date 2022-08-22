int prato, sobremesa, bebiba, soma;
Console.WriteLine("ESCOLHA O SEU PRATO:");
Console.WriteLine("1. VEGETARIANO | 180cal ");
Console.WriteLine("2. PEIXE | 230cal");
Console.WriteLine("3. FRANGO | 250cal");
Console.WriteLine("4. CARNE | 350cal");
Console.WriteLine("INFORME O PRATO DESEJADO:");
prato = int.Parse(Console.ReadLine());
soma = 0;

switch (prato){
    case 1:
    soma +=  180;
    break;
    case 2:
    soma += 230;
    break;
    case 3:
    soma += 250;
    break;
    case 4:
    soma += 350;
    break;
}
Console.WriteLine("ESCOLHA O SUA SOBREMESA:");
Console.WriteLine("1. ABACAXI | 75cal ");
Console.WriteLine("2. SORVETE DIET | 110cal");
Console.WriteLine("3. MOUSE DIET | 170al");
Console.WriteLine("4. MOUSE CHOCOLATE | 200cal");
Console.WriteLine("INFORME A SOBREMESA DESEJADA:");
sobremesa = int.Parse(Console.ReadLine());

switch (prato){
    case 1:
    soma += 75;
    break;
    case 2:
    soma += 110;
    break;
    case 3:
    soma += 170;
    break;
    case 4:
    soma += 200;
    break;
}
Console.WriteLine("ESCOLHA A SUA BEBIBA:");
Console.WriteLine("1. CHÁ | 20cal ");
Console.WriteLine("2. SUCO DE LARANJA | 70cal");
Console.WriteLine("3. SUCO DE MELÃO | 100cal");
Console.WriteLine("4. REFRIGERANTE DIET| 65cal");
Console.WriteLine("INFORME A BEBIDA DESEJADA:");
sobremesa = int.Parse(Console.ReadLine());

switch (prato){
    case 1:
    soma += 20;
    break;
    case 2:
    soma += 70;
    break;
    case 3:
    soma += 100;
    break;
    case 4:
    soma += 65;
    break;
}
Console.WriteLine("O TOTAL DE CALORIAS CONSUMIDAS FOI : " + soma + " CAL ");