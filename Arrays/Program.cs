//Vetores

//Conjunto de informações/dados
//vetor7array
int[] idades = new int[5];

string[] nomes = new string[10];

//Crio o vetor e dou um nome
// <tipo>[] idades;

//Inicializo o vetor
// new <tipo>[<quantidade>]

// Posição

nomes[0] = "Vinicius";
idades[4] = 26;

// for para percorrer listas/vetores

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Insira o nome");
//    nomes[i] = Console.ReadLine();
//}


//foreach (var item2 in nomes)
//{
//    Console.WriteLine(item2);
//}



//Crie um vetor de idades, use um for para preencher as idade e use o for para listar as idades


int[] idade2 = new int[3];

for (int i = 0; i < 4; i++)
{
    nomes[i] = Console.ReadLine();
}

for (int i = 0;i < 4; i++)
{
    Console.WriteLine(nomes[i]);
}