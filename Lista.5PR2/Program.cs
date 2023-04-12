using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista._5PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, exercicio = -1;

            for (; exercicio != 0;)
            {


                Console.WriteLine("Escolha em exercício");
                exercicio = int.Parse(Console.ReadLine());
                switch (exercicio)
                {


                    case 1:



                        Console.WriteLine("Digite um número");
                        n = int.Parse(Console.ReadLine());
                        for (i = 1; i <= n; i++)
                        {
                            Console.WriteLine("O valores:" + i);
                        }
                       
                        break;



                    case 2:




                        Console.WriteLine("Digite um número");
                        n = int.Parse(Console.ReadLine());
                        for (i = 1; i <= n; i++)
                        {
                            if (i % 2 == 0)
                                Console.WriteLine("O valores:" + i);
                        }

                        break;





                    case 3:


                        Console.WriteLine("Digite um número menor que 1000");
                        n = int.Parse(Console.ReadLine());
                        if (n < 1000)
                        {
                            for (i = 1000; i >= n; i--)
                            {
                                if (i % 2 == 0)
                                    Console.WriteLine("O valores:" + i);
                            }
                        }
                        else
                            Console.WriteLine("Número inválido");




                        Console.ReadKey();
                        break;




                    case 4:
                        int numer;
                        int somaPositivos = 0;

                        Console.WriteLine("Informe uma sequência de números inteiros:");
                        Console.WriteLine("Digite um número negativo para encerrar.");

                        for ( i = 1; ; i++)
                        {
                            Console.Write($"Informe o número {i}: ");
                            numer = Convert.ToInt32(Console.ReadLine());

                            if (numer >= 0)
                            {
                                // Se o número for positivo ou zero, imprime e adiciona à soma
                                Console.WriteLine($"Número positivo: {numer}");
                                somaPositivos += numer;
                            }
                            else
                            {
                                // Se o número for negativo, encerra o loop
                                break;
                            }

                            if (somaPositivos >= 200)
                            {
                                // Se a soma dos positivos for maior ou igual a 200, encerra o loop
                                break;
                            }
                        }

                        Console.WriteLine("A soma dos números positivos atingiu 200 ou mais.");
                
            
        

                        break;



                    case 5:


                        Console.WriteLine("Digite um número ");
                        n = int.Parse(Console.ReadLine());
                        for (i = 1; i <= n; i++)
                        {
                            if (n % i == 0)
                                Console.WriteLine("O valores:" + i);
                        }
                       
                        break;



                    case 6:

                        int numero;
                        int maiorNumero = int.MinValue;
                        int menorNumero = int.MaxValue;

                        Console.WriteLine("Informe 10 números inteiros:");

                        for ( i = 1; i <= 10; i++)
                        {
                            Console.Write($"Informe o número {i}: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (numero > maiorNumero)
                            {
                                maiorNumero = numero;
                            }

                            if (numero < menorNumero)
                            {
                                menorNumero = numero;
                            }
                        }

                        Console.WriteLine($"O maior número digitado foi: {maiorNumero}");
                        Console.WriteLine($"O menor número digitado foi: {menorNumero}");
                

                        break;







                    case 7:

                        int nume;
                        int somaPares = 0;
                        int somaImpares = 0;

                        Console.WriteLine("Informe uma sequência de números inteiros (informe 0 para finalizar):");

                        for (; ; )
                        {
                            Console.Write("Informe um número: ");
                            nume = Convert.ToInt32(Console.ReadLine());

                            if (nume == 0)
                            {
                                break; // Sai do laço quando o número informado for zero
                            }

                            if (nume % 2 == 0)
                            {
                                somaPares += nume;
                            }
                            else
                            {
                                somaImpares += nume;
                            }
                        }

                        Console.WriteLine($"A soma dos números pares é: {somaPares}");
                        Console.WriteLine($"A soma dos números ímpares é: {somaImpares}");
                

                break;

                }
            }
        }
    }
}
