﻿int dividendo, divisor, resto;

Console.WriteLine("Maximo Divisor Comum (método iterativo)");

Console.Write("Digite 0 1º numero (a): ");
dividendo = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o 2º numero (b): ");
divisor = Convert.ToInt32(Console.ReadLine());

do
{
    resto = dividendo % divisor;
    dividendo = divisor;
    divisor = resto;
}
while(resto != 0);

Console.WriteLine($"MDC(a, b) = {dividendo}");