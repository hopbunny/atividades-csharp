using System;
class Media
{
  static void Main ()
  {
    float n1, n2, n3;
    float p1, p2, p3, media;
      Console.WriteLine ("Informe a primeira nota e seu peso:");
      n1 = float.Parse (Console.ReadLine ());
      p1 = float.Parse (Console.ReadLine ());
      Console.WriteLine ("Informe a segunda nota e seu peso:");
      n2 = float.Parse (Console.ReadLine ());
      p2 = float.Parse (Console.ReadLine ());
      Console.WriteLine ("Informe a terceira nota e seu peso:");
      n3 = float.Parse (Console.ReadLine ());
      p3 = float.Parse (Console.ReadLine ());

      Console.Clear ();
      media = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);
      Console.WriteLine ("Resultado: = " + media);
  }
}