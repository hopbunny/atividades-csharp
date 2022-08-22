Console.WriteLine("Informe sua idade:");
float idade = float.Parse(Console.ReadLine());

if (idade < 16){
Console.WriteLine("Não eleitor!");
}
else if (idade >=18 & idade <= 65){
    Console.WriteLine("Eleitor Obrigatório!");
}
else if ((idade < 18 & idade >= 16) | (idade > 65 )){
    Console.WriteLine("Eleitor Facultativo! (de 16 ate 18 e maior que 65");
}   