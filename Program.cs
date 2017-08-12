using System;

namespace Exercicio2CalculaIdade
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			string nome;
			int idadeAtual, idadeCasamento, anoCasamento, anoAtual, difAnos;
			anoAtual = DateTime.Now.Year;
			Console.WriteLine("Digite seu nome: ");
			nome = Console.ReadLine();
			Console.WriteLine("Digite sua idade atual: ");
			idadeAtual = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o ano do seu casamento: ");
			anoCasamento = Convert.ToInt32(Console.ReadLine());
			difAnos = anoAtual - anoCasamento;
			idadeCasamento = idadeAtual - difAnos;
			Console.Write(nome + ", você tinha " + idadeCasamento + " quando se casou em " + anoCasamento);
			Console.ReadLine();
        }
    }
}
