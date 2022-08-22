using System;
					
public class Program
{
	public static void Main()
	{
		float r, a;
		Console.WriteLine("Informe o raio de um circulo:");
		r = float.Parse(Console.ReadLine());
		
		a = 3.14f * r*r;
		Console.WriteLine("A area do circulo e:" + a);
	}
}