Console.WriteLine ("Informe o saldo médio do ano:");
float saldo = float.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Saldo médio = " + saldo);
if (saldo < 500f){
    Console.WriteLine("Nenhum crédito aprovado!");
}
else if (saldo >= 501 & saldo <= 1000){
    Console.WriteLine("Crédito aprovado com 30 % do valor do saldo médio = " + (saldo*0.3f));
}
else if (saldo > 1001 & saldo <= 3000){
     Console.WriteLine("Crédito aprovado com 40 % do valor do saldo médio = " + (saldo*0.4f));
}
else {
     Console.WriteLine("Crédito aprovado com 50 % do valor do saldo médio = " + (saldo*0.5f));
}