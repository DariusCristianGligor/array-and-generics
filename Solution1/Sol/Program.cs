using Sol.AddDicandCol;
using System;

namespace Sol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[10];
            //array[12] = 12;
            array[0] = 22;
           
            Console.WriteLine(array[0]);
            Console.WriteLine(array[2]);

            int[][] matrice = new int[3][];
            matrice[0] = new int[] { 0, 1, 2, 3 };
            matrice[1] = new int[] { 0, 1, 2, 3,222,123123 };
            matrice[2] = new int[] { 111, 2222, 3330, 1, 2, 3 };
            Console.WriteLine(matrice.Length);
            //da lungimea 3 pentru ca liniile au lungimi dinamice;
            int[,] matrice2 = new int[12, 12];
            matrice2[1, 2] = 15;
            Console.WriteLine(matrice2.Length);
            //da lungimea 12*12
            int[,] matrice3 = new int[,]
                {
                    { 1,2,3,4,5},
                    { 1,2,3,4,5}
                };
            int[][,,][,]ma= new int[3][,,][,];
            ma[0] = new int[3, 4, 3][,];
            ma[1] = new int[2, 5, 7][,];
            ma[1][0, 0, 0] = new int[2, 2];
            ma[1][0, 1, 0] = new int[2, 2];
            ma[1][0, 1, 0][1, 0] = 22;
            Console.WriteLine(ma[1][0, 1, 0][1, 0]);
            Console.WriteLine(ma[1][0, 0, 0][1, 0]);
            Queue<String> q = new Queue<string>(12);
            q.enqueue("asdasda");
            q.enqueue("asdasSSSSda");
            q.enqueue("asdasda");
            q.enqueue("asdasda12312");
            q.enqueue("123123asdasda");
            Console.WriteLine(q);
            Queue<int> q1 = new Queue<int>(3);
            q1.enqueue(444);
            q1.enqueue(3);
            q1.enqueue(2);
            Console.WriteLine(q1);
            Console.WriteLine(q1.dequeue());
            Console.WriteLine(q1.dequeue());
            Console.WriteLine(q1.dequeue());
            Console.WriteLine(q1);
            Masina m = new Masina("2131231X22","Audi","A6",123123,Combustibil.motorina);
            m.addReparatie("Ionel", "schimb ulei");
            Console.WriteLine(m);
        }
    }
}
