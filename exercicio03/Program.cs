using System;

namespace Exercicio03{
    public class Program    {

        public static void Main(string[] args)        {
        int matr;
        int nota;
double media = 0;        
            for (int al = 1; al <= 5; al++){
Console.WriteLine("digite o número da matrícula");
matr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite a nota");
nota = Convert.ToInt32(Console.ReadLine());
            }
media = (nota + al) / 5;
            
Console.WriteLine("a media da prova dos alunos é" + media);
        

}
}
}