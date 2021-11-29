using System;

namespace Exercicio02{
    public class Program    {

        public static void Main(string[] args)        {
            int quant = 1;
            int soma = 0;
            int soma2 = 0;
            double media;
            double media2;
while (quant <= 5){
    Console.WriteLine("digite a nota mensal");
    int notamensal = Convert.ToInt32(Console.ReadLine());
    soma = notamensal * quant;
    Console.WriteLine("digite a nota bimestral");
    int notabimestral = Convert.ToInt32(Console.ReadLine());
    soma2 = notabimestral * quant;
quant++;
}
media = soma / 5;
media2 = soma2 / 5;
Console.WriteLine("a media da prova mensal de todos os alunos é" + media);
Console.WriteLine("a media da prova bimestral de todos os alunos é" + media2);
}
}
}