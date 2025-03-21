//listagem de elementos

int[] arryadoscria = [1, 2, 3, 4, 5];

for (int i= 0; i < arryadoscria.Length; i++)
{
    Console.WriteLine($"Index {i} valor "+arryadoscria[i]);
}



//soma dos elementos de um array

int[] somadoe5 = [1,2,3,4,5];
int somatotal = 0;
for (int i = 0; i < somadoe5.Length; i++)
{
    somatotal += somadoe5[i];
}

Console.WriteLine("soma total dos 5"+somatotal);



//Encontrar o maior numero do arrary

int[] maiorarray = [0, 7, 131, 2, 30];
int maior = 0;
for(int i = 0; i < maiorarray.Length;i++)
{
    if (maiorarray[i] > maior)
    {
        maior = maiorarray[i];
    }
}

Console.WriteLine($"O maior numero da array é {maior}");


//Contagem de numeros pares
int[] listadenumeros = new int[10];
int varaux = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Insira o {i +1}º numero: ");
    int inputnum = int.Parse(Console.ReadLine());
    if (inputnum%2 == 0)
    {
        listadenumeros[varaux] = inputnum;
        varaux++;
    }
}

int tamanho = 0;
for(int i = 0; i < listadenumeros.Length; i++)
{
    if (listadenumeros[i] != 0)
    {
        tamanho++;
    }
}
Console.WriteLine($"O Array possui: {tamanho} numeros pares");

//Inversao de elementos



// Projeto de revisao

