int a, b, c;
Console.WriteLine("Informe o valor de A:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de B:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor de C:");
c = int.Parse(Console.ReadLine());

    if  (a > b & b > c){
    Console.WriteLine(a + " " + b + " " + c);
    }
    else if (a > c & c > b){
    Console.WriteLine(a + " " + c + " " + b);
    }
    else if (b > a & a > c){
        Console.WriteLine(b + " " + a + " " + c);
    }
    else if (b > c & c > a){
        Console.WriteLine(b + " " + c + " " + a);
    }
    else if (c > a & a > b){
        Console.WriteLine(c + " " + a + " " + b);
    }
    else {
        Console.WriteLine(c + " " + b + " " + a);
    }
