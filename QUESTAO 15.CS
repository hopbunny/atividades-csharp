using System;
					
public class Program
{
	public static void Main()
	{
		float pe, jar, mi, pol;
		Console.WriteLine("Informe a medida em pés:");
		pe = float.Parse(Console.ReadLine());
		
		pol = pe * 12;
		jar = pe / 3f;
		mi = jar / 1760f;
		
		Console.WriteLine("O medida em polegadas é:" + pol);
		Console.WriteLine("O medida em jardas é:" + jar);
		Console.WriteLine("O medida em milhas é:" + mi);
	}
}