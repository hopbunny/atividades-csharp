/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Informe um número:");
    int numero = Convert.ToInt32(Console.ReadLine());
    
    if (numero % 2 == 0){
        Console.WriteLine("O número é par!");
    }
    else{
        Console.WriteLine("O número é impar!");
    }
    Console.ReadKey();
  }
}