double valorDaNotaFiscal = 0;
Console.WriteLine("Informe o valor da nota fiscal:");
valorDaNotaFiscal = double.Parse(Console.ReadLine());

if (valorDaNotaFiscal <= 999){
    valorDaNotaFiscal = valorDaNotaFiscal * (2f/100);
    Console.WriteLine("O imposto a ser cobrado do valor da nota sera de 2% totalizando "  + valorDaNotaFiscal.ToString("C"));
} else if (valorDaNotaFiscal <= 2999){
    valorDaNotaFiscal = valorDaNotaFiscal * (2.5f/100);
    Console.WriteLine("O imposto a ser cobrado do valor da nota sera de 2.5% totalizando " + valorDaNotaFiscal.ToString("C"));
}else if (valorDaNotaFiscal <= 6999){
    valorDaNotaFiscal = valorDaNotaFiscal * (2.8f/100);
    Console.WriteLine("O imposto a ser cobrado do valor da nota sera de 2.8% totalizando "  + valorDaNotaFiscal.ToString("C"));
}else{
    valorDaNotaFiscal = valorDaNotaFiscal * (3f/100);
    Console.WriteLine("O imposto a ser cobrado do valor da nota sera de 3% totalizando "  + valorDaNotaFiscal.ToString("C"));
}