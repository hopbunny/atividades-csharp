Console.WriteLine ("Informe o salário atual:");
float s = float.Parse(Console.ReadLine());
Console.WriteLine ("1. Cargo Escriturário:");
Console.WriteLine ("2. Cargo Secretário:");
Console.WriteLine ("3. Cargo Caixa:");
Console.WriteLine ("4. Cargo Gerente:");
Console.WriteLine ("5. Cargo Diretor:");
int opcao = int.Parse(Console.ReadLine());
float num;

switch (opcao){
    case 1:
    Console.WriteLine ("o novo aumento salárial foi de 50%");
    num = s * (50f / 100f);
    Console.WriteLine ("O novo sálario do cargo escriturário sera de:" + (num+s));
    break;
    
    case 2:
    Console.WriteLine ("o novo aumento salárial foi de 35%");
    num = s * (35f / 100f);
    Console.WriteLine ("O novo sálario do cargo de secretário sera de:" + (num+s));
    break;

    case 3:
    Console.WriteLine ("o novo aumento salárial foi de 20%");
    num = s * (20f / 100f);
    Console.WriteLine ("O novo sálario do cargo caixa sera de:" + (num+s));
    break;

    case 4:
    Console.WriteLine ("o novo aumento salárial foi de 10%");
    num = s * (10f / 100f);
    Console.WriteLine ("O novo sálario do cargo gerente sera de:" + (num+s));
    break;

    case 5:
    Console.WriteLine ("Este cargo de diretor nao teve aumento!");
    break;
 }
