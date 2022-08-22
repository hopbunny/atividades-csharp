bool brasileira = true;
    Console.WriteLine("Informe sua idade:");
    int idade = int.Parse(Console.ReadLine());

    if (idade >= 16 & brasileira == true){
    Console.WriteLine ("Você pode votar");
    }else{
    Console.WriteLine("Você não pode votar!");
    }
