using System;
class Salario
{
  static void Main ()
  {
    float s, a, b;
      Console.WriteLine ("Informe o salario do funcionario:");
      s = float.Parse (Console.ReadLine ());
      

      Console.Clear ();
              a = (s * ((5f / 100f)) - (s * (7f / 100f)));
      Console.WriteLine ("O salario final é: " + (s + a));
  }
}
