using System;
					
public class Program
{
	public static void Main()
	{
		double a, r, rc, n, b;
		Console.WriteLine("Informe um numero positivo:");
		n = float.Parse(Console.ReadLine());
		
		b = n* n;
		a = n * n * n;
		r = Math.Pow(n,0.5);
		rc = Math.Pow(n,1.0/3.0);
		
		Console.WriteLine("O numero digitado elevado ao quadrado e:" + b);
		Console.WriteLine("O numero digitado elevado ao cubo e:" + a);
		Console.WriteLine("A raiz quadrada do numero digitado é:" + r);
		Console.WriteLine("A raiz cubica do numero digitado é:" + rc);
	}
}