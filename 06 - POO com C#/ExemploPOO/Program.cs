// See https://aka.ms/new-console-template for more information
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

// 01 - Abstração
// Pessoa p1 = new Pessoa();
// p1.Nome = "Bruno";
// p1.Idade = 28;
// p1.Apresentar();

// 02 - Encapsulamento
// valores válido
// Retangulo r = new Retangulo();
// r.DefinirMedidas(15, 30);
// System.Console.WriteLine($"Área: {r.ObterArea()}m2");
// // valores inválidos
// Retangulo rInv = new Retangulo();
// rInv.DefinirMedidas(0, 0);
// System.Console.WriteLine($"Área: {rInv.ObterArea()}m2");

// 03 - Herança & Polimorfismo
// Aluno a = new Aluno();
// a.Nome = "Bruno"; //Origem Pessoa
// a.Idade = 28; //Origem Pessoa
// a.Nota = 9; //Origem Aluno
// a.Apresentar();

// Professor p = new Professor();
// p.Nome = "Renata"; //Origem Pessoa
// p.Idade = 49; //Origem Pessoa
// p.Salario = 5000; //Origem Professor
// p.Apresentar();

//04 - polimorfismo tempo de compliação
// calculadora calc = new calculadora();
// System.Console.WriteLine("Resultado 1 = " + calc.Somar(15, 06));

// System.Console.WriteLine("Resultado 2 = " + calc.Somar(15, 06, 1993));

// 05 - Classes abstratas
// Corrente c = new Corrente();
// c.Creditar(100);

// c.ExibirSaldo();

// 06 - Interfaces
// ICalculadora calc = new calculadora();
// System.Console.WriteLine(calc.Multiplicar(10, 20));

// 07 - Arquivos
var caminho = "D:\\Programação\\DIO\\DECOLA TECH #2\\DIO-desafio-github\\06 - POO com C#\\TrabalhandoComArquivos";
var caminhoPath = Path.Combine(caminho, "Pasta Teste 1");
var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

FileHelper helper = new FileHelper();
// helper.ListarDiretorios(caminho);
// helper.ListarArquivos(caminho);
// helper.CriarDiretorio(caminhoPath);
// helper.ApagarDiretorio(caminhoPath, true);
// helper.CriarArquivoTexto(caminhoArquivo, "Testanto este arquivo");
// helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
// helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
// helper.LerArquivoStream(caminhoArquivo);
// helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
// helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
helper.DeletarArquivo(caminhoArquivoTesteCopia);