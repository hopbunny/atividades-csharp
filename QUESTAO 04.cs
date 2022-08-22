using System;
class Salario
{
  static void Main ()
  {
    float s, a;
      Console.WriteLine ("Informe o salario:");
      s = float.Parse (Console.ReadLine ());

      Console.Clear ();
      a = s + (s * (25f / 100f));
      Console.WriteLine ("O novo aumento salarial de 25% e: " + a);
  }
}
