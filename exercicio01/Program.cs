using System;

namespace Exercicio02{
    public class Program    {

        public static void Main(string[] args)        {
            int idade;
            int cont = 0;
for (int i = 1; i <=10; i++){
Console.WriteLine("digite a idade da pessoa");
idade = Convert.ToInt32(Console.ReadLine());
if (idade >= 18){
    cont ++;
}
}
Console.WriteLine("a quantidade de pessoas com 18 anos ou mais é de" + cont);
}
}
}