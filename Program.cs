using System;
using System.IO;

namespace arquivocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,email;
            int idade;
            Console.Write("Digite o seu nome: ");
            nome=Console.ReadLine();

            Console.Write("Digite o seu email: ");
            email=Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            idade=Int32.Parse(Console.ReadLine());

            FileInfo fi = new FileInfo("dados_cabecalho.csv");
        
            StreamWriter arquivo;
            if(fi.Exists){
              arquivo  = new StreamWriter("dados_cabecalho.csv",true); 
              arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            }else{
              arquivo  = new StreamWriter("dados_cabecalho.csv",true); 
              arquivo.WriteLine("Nome;Email;Idade;Data de Cadastro");
              arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());


            }
            
            arquivo.Close();
        }
    }
}
