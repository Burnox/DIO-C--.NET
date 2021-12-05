// // 1 - Array unidimensional
// // int[] arrayInteiros = new int[3];

// // arrayInteiros[0] = 49;
// // arrayInteiros[1] = 29;
// // arrayInteiros[2] = 28;

// // System.Console.WriteLine("1 - For Loop");
// // for (int i = 0; i < arrayInteiros.Length; i++)
// // {
// //   System.Console.WriteLine(arrayInteiros[i]);
// // }

// // System.Console.WriteLine("2 - Foreach Loop");
// // foreach (var numero in arrayInteiros)
// // {
// //   System.Console.WriteLine(numero);
// // }

// // 2 - Matriz
// // int[,] matriz = new int[3, 2]{
// //   { 1, 49 },
// //   { 2, 29 },
// //   { 3, 28 }
// // };

// // for (int i = 0; i < matriz.GetLength(0); i++)
// // {
// //   for (int j = 0; j < matriz.GetLength(1); j++)
// //   {
// //     System.Console.WriteLine(matriz[i, j]);
// //   }
// // }

// // 3 - Listas
// using Colecoes.Helper;

// // List<string> estados = new List<string> { "AC", "AM", "AP", "PA", "RO", "RR" };
// // string[] estadosArray = new string[1] { "TO" };

// // // System.Console.WriteLine($"Quantidade de estados na ragião norte: {estados.Count}");

// // OperacaoLista opLista = new OperacaoLista();

// // opLista.ImprimirListaString(estados);

// // // estados.AddRange(estadosArray);

// // // opLista.ImprimirListaString(estados);

// // System.Console.WriteLine();

// // estados.Insert(6, "TO");

// // opLista.ImprimirListaString(estados);


// // 4 - Queues e Stacks

// // Queue<string> fila = new Queue<string>();

// // fila.Enqueue("Bruno");
// // fila.Enqueue("Renata");
// // fila.Enqueue("Mayara");

// // System.Console.WriteLine($"Número de pessoas na fila: {fila.Count}");

// // while (fila.Count > 0)
// // {
// //   System.Console.WriteLine($"Ordem: {fila.Peek()}");
// //   System.Console.WriteLine($"{fila.Dequeue()} foi atendido(a)!");
// // }

// // System.Console.WriteLine($"Número de pessoas na fila: {fila.Count}");

// // Stack<string> pilhaLivros = new Stack<string>();

// // pilhaLivros.Push("Sherlock Holmes");
// // pilhaLivros.Push("Nosso Lar");
// // pilhaLivros.Push("A Odisséia");

// // System.Console.WriteLine($"Livros restante para leitura: {pilhaLivros.Count}");

// // while (pilhaLivros.Count > 0)
// // {
// //   System.Console.WriteLine($"Livro a ser lido: {pilhaLivros.Peek()}");
// //   System.Console.WriteLine($"O livro {pilhaLivros.Pop()} foi lido com sucesso");
// // }
// // System.Console.WriteLine($"Livros restante para leitura: {pilhaLivros.Count}");

// //05 - Dicionário
// Dictionary<string, int> familia = new Dictionary<string, int>();

// familia.Add("Renata", 49);
// familia.Add("Bruno", 28);
// familia.Add("Mayara", 29);


// string valorProcurado = "Bruno";
// // System.Console.WriteLine(familia[valorProcurado]);

// familia["Mayara"] = 30;

// familia.Remove(valorProcurado);

// foreach (KeyValuePair<string, int> item in familia)
// {
//   System.Console.WriteLine($"Membro: {item.Key}, possui {item.Value} anos.");
// }

// if (familia.TryGetValue(valorProcurado, out int idadeEncontrada))
// {
//   System.Console.WriteLine(idadeEncontrada);
// }
// else
// {
//   System.Console.WriteLine($"A chave {valorProcurado} não foi encontrada!");
// }

// 06 - LINQ

int[] numeros = new int[9] { 9, 8, 1, 4, 1, 2, 5, 7, 0 };

// var paresQuery =
//     from num in numeros
//     where num % 2 == 0
//     orderby num
//     select num;

// var paresMetodo = numeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

// System.Console.WriteLine("Números pares query: " + string.Join(", ", paresQuery));

// System.Console.WriteLine("Números pares método: " + string.Join(", ", paresMetodo));

var minimo = numeros.Min();
var maximo = numeros.Max();
var media = numeros.Average();
var soma = numeros.Sum();
var numerosUnicos = numeros.Distinct().ToArray();

System.Console.WriteLine($"Array original: {string.Join(", ", numeros)}");
System.Console.WriteLine($"Valor mínimo: {minimo}");
System.Console.WriteLine($"Valor máximo: {maximo}");
System.Console.WriteLine($"Valor médio: {media}");
System.Console.WriteLine($"Valor somado: {soma}");
System.Console.WriteLine($"Array modificado: {string.Join(", ", numerosUnicos)}");