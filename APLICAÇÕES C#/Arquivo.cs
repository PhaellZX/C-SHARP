using System;
using System.IO;

class MeuArquivo {

	public static void Main(){
		// Variavel do arquivo
		
		//StreamWriter arq;

		//Variavel para ler um arquivo

		StreamReader arq;

		// Caminho
		string CaminhoNome = "C:\\Users\\Administrador.IBERLEO0104\\Desktop\\Arquivo.txt";

		// Gerando o Arquivo
		//x = File.CreateText(CaminhoNome);

		// Abrir Arquivo

		//arq = File.AppendText(CaminhoNome);

		//Abrindo um arquivo texto indicado

		arq = File.OpenText(CaminhoNome);

		//Enquanto não retornar valor booleano
		//quer dizer que não chegou no final do arquivo

		while(arq.EndOfStream != true){

		// Lendo conteúdo da linha do arquivo texto

		string linha = arq.ReadLine();
  		
		Console.WriteLine(linha);

  		}
		//Console.WriteLine("Arquivo gerado com sucesso!");
		
		// Escrever no arquivo

		/*arq.WriteLine("Escrevendo mais no arquivo");
		arq.WriteLine("HAHAHAHAHAHAHAH");
		arq.WriteLine("blablablablabla");
		arq.WriteLine("Isso foi umas quebras de Linhas");*/

		arq.Close();

		Console.ReadKey();
	}	
}
