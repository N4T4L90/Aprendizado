using System;

namespace URI_1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            int X;
            /**Leia a hora inicial e a hora final de um jogo.
            * A seguir calcule a duração do jogo, sabendo que o mesmo pode
            * começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            * 
            * Entrada
            * A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
            * 
            * Saída
            * Apresente a duração do jogo conforme exemplo abaixo.*/
            if ((A>=12 && B<=12) || (A<12 && B<12) || (A<12 && B==12))
            {
                X = (24 - A) + B;
                Console.WriteLine("O JOGO DUROU " + X + " HORAS(S)");
            }
            else if ((A>12 && B>12) || (A<=12 && B>12))
            {
                X = B - A;
                Console.WriteLine("O JOGO DUROU " + X + " HORAS(S)");
            }
            
            
            
        }
    }
}
