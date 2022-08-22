using System;
class Salario
{
  static void Main ()
  {
    float s, p, a;
      Console.WriteLine ("Informe o salario:");
      s = float.Parse (Console.ReadLine ());
      Console.WriteLine ("Informe o aumento:");
      p = float.Parse (Console.ReadLine ());
      

      Console.Clear ();
              a = s * (p / 100f);
      Console.WriteLine ("O novo aumento salarial e: " + a);
      Console.WriteLine ("O novo salario e: " + (s + a));
  }
}
