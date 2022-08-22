Console.WriteLine("Informe seu peso (em kg) e sua altura (em metros):");
float peso = float.Parse(Console.ReadLine());
float altura = float.Parse(Console.ReadLine());

float imc = peso / (altura * altura);
Console.Clear();
if (imc < 20f)
{
Console.WriteLine("Abaixo do peso " + imc);
}
else if (imc >= 20 & imc <= 25) {
    Console.WriteLine ("Peso normal " + imc);
}
else if(imc > 25 & imc <= 30){
     Console.WriteLine ("Sobre Peso " + imc);
}
else if (imc > 30 & imc <= 40){
 Console.WriteLine ("Obeso " + imc);
}
else {
     Console.WriteLine ("Obeso Mórbido " + imc);
}
