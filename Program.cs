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

            StreamWriter arquivo = new StreamWriter("dados.csv",true);
            arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            arquivo.Close();
        }
    }
}
