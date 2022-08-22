/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld
{
  static void Main ()
  {
    int n1, n2, n3, n4;
      Console.WriteLine ("Informe o primeiro nC:mero: ");
      n1 = int.Parse (Console.ReadLine ());
      Console.WriteLine ("Informe o segundo nC:mero: ");
      n2 = int.Parse (Console.ReadLine ());
      Console.WriteLine ("Informe o terceiro nC:mero: ");
      n3 = int.Parse (Console.ReadLine ());
      Console.WriteLine ("Informe o quarto nC:mero: ");
      n4 = int.Parse (Console.ReadLine ());
      Console.Clear ();
      Console.WriteLine ("Soma dos nC:meros = " + (n1 + n2 + n3 + n4));

  }
}
