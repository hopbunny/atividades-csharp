using System;
					
public class Program
{
	public static void Main()
	{
		float fab, lucro, imposto, result1, result2;
		Console.WriteLine("Informe o valor de fabricação da fabrica:");
		fab = float.Parse(Console.ReadLine());
		Console.WriteLine("Informe o percentual de lucro:");
		lucro = float.Parse(Console.ReadLine());
		Console.WriteLine("Informe o percentual de imposto:");
		imposto = float.Parse(Console.ReadLine());
		
		result1 = fab * (lucro/100f);
		result2 = fab * (imposto/100f);
		
		Console.WriteLine("O lucro da fabricante é:" + result1);
		Console.WriteLine("O imposto pago pela fabricante é:" + result2);
		Console.WriteLine("O preço final:" + (fab+result1+result2));
		
	}
}