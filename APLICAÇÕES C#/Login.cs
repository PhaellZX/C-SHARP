using System;
using System.IO; //declarando a biblioteca de entrada e saída de arquivos
                 //a biblioteca IO
 
class Login {
 
    public static void tela(){
        
        StreamReader arq;
        string administrador, senha, linha, linha2, caminho = "C:\\Users\\Administrador.IBERLEO0104\\Desktop\\Arquivo.txt";
 
        Console.Write("Login: ");
        administrador = Console.ReadLine();
        Console.Write("Senha: ");
        senha = Console.ReadLine();
 
        arq = File.OpenText(caminho);
        
        while(arq.EndOfStream != true){

         linha = arq.ReadLine();
         linha2 = arq.ReadLine();
 
         if(administrador==linha&&senha==linha2){  
                 
                 Console.WriteLine("Logado com sucesso!");
                    break;
	            }
        }
		arq.Close();
}
    public static void Main(){
 
        tela();
 
        Console.ReadKey();
    }
}