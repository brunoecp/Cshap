using System.Numerics;

//1.elabore um algaritmo de 3 digitos e de a saida da quantidade de centenas, dezenas e unidades
//2.faça um programa q diga os numeros pares ate 1000 a 1
//3.faça um fibonacci 3x3

//1

//int a = Convert.ToInt16(Console.ReadLine());
//int centena = 0;
//int dezena = 0;
//int unidade = 0;

//while(a >= 100)
//{
//    centena += 1;
//    a -= 100;
//}
//while(a >= 10)
//{
//    dezena += 1;
//    a-=10;
//}
//while(a >= 1)
//{
//    unidade += 1;
//    a -= 1;
//}
//Console.WriteLine("centena: " + centena + " dezena: " + dezena + " unidade: " + unidade);

////2

//for (int i = 1000; i >0; i--)
//{
//    if (i % 2 == 0)
//    {
//       Console.WriteLine(i);
//    }
//}

//3
int numeroAnterior = 0;
int numeroAtual = 1;
int novoNumero;
int fibonacci;
List<int> fibonacciList = new List<int>();
fibonacciList.Add(numeroAnterior);
fibonacciList.Add(numeroAtual);


for (int i = 0; i < 10; i++)
{
    fibonacci = numeroAnterior + numeroAtual;
    fibonacciList.Add(fibonacci);
    numeroAnterior = numeroAtual;
    numeroAtual = fibonacci;
}
for  (int i = 0; i < 3; i++)
{
    string matrix = "";
    for (int j = 0; j < 3; j++)
    {
        if (i == 0)
        {
            matrix += "  " + fibonacciList[j];
        }
        if (i == 1)
        {
            matrix += "  " + fibonacciList[j + 3];
        }
        if (i == 2) 
        {
            matrix += "  " + fibonacciList[j + 6];
        }

    }
    Console.WriteLine(matrix);
}