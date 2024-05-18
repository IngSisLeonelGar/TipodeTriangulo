int lado1, lado2, lado3;
string linea;
Console.WriteLine("digite lado 1: ");
linea =  Console.ReadLine();
lado1 = int.Parse(linea);
Console.WriteLine("digite lado 2: ");
linea = Console.ReadLine();
lado2 = int.Parse(linea);
Console.WriteLine("digite lado 3: ");
linea = Console.ReadLine();
lado3 = int.Parse(linea);
if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("Triangulo equilatero, todos sus lados son iguales");
}
else
{
    if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
    {
        Console.WriteLine("Triangulo escaleno, ninguno de sus lados son iguales");
    }
    else
    {
        Console.WriteLine("Triangulo isosceles, dos lados son iguales y uno es diferente");
    }
    Console.WriteLine("Presione una tecla.");
    Console.ReadLine();
        
}