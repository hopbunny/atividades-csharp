using System;
class Salario
{
  static void Main ()
  {
    float s, a, b;
      Console.WriteLine ("Informe o salario do funcionario:");
      s = float.Parse (Console.ReadLine ());
      

      Console.Clear ();
              a = (s + 50) - (s * (10f / 100f));
      Console.WriteLine ("O salario final é: " + a);
  }
}
