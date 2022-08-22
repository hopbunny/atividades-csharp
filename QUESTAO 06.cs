using System;
class Media
{
    static void Main ()
    {
        float n1, n2, n3;
        float media;
        Console.WriteLine("Informe a primeira nota:");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota:");
        n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a terceira nota:");
        n3 = float.Parse(Console.ReadLine());
        
        Console.Clear();
        media = (n1+n2+n3)/3;
        Console.WriteLine ("Média de notas = " + media);
        
    }
}
