using System;
					
public class Program
{
	public static void Main()
	{
		      float area, b, altura;
      Console.WriteLine("Informea base de um triangulo: ");
      b = float.Parse (Console.ReadLine());
      Console.WriteLine("Informea a altura de um triangulo: ");
      altura = float.Parse (Console.ReadLine());
      
      area = (b * altura) / 2f  ;
      
      Console.WriteLine("A area do triangulo e:" + area);
	}
}