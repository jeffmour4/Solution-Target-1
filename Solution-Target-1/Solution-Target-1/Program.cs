using System.Numerics;

namespace Solution_Target_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Questão 1
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }
            Console.WriteLine("A soma é: " + soma);

            // Questão 2
            int x = 0;
            int a = 0;
            int b = 1;
            int c = 0;
            List<int> fibonnaci = new();
            fibonnaci.Add(a);
            fibonnaci.Add(b);

            while (x < 45)
            {
                c = a + b;
                a = b;
                b = c;
                fibonnaci.Add(c);
                x++;
            }
            Console.WriteLine("Digite um número:");
            int number = Convert.ToInt32(Console.ReadLine());
            //bool result = fibonnaci.Contains(number); para evitar métoos prontos, não usei Contains() 
            bool result = false;
            foreach (int fiboNumber in fibonnaci)
            {
                if (fiboNumber == number)
                { result = true; break; }
            }
            Console.WriteLine("O número pertence à sequencia fibonnaci? ");
            Console.WriteLine(result);

            // Questão 3
            /* 
            a) 1, 3, 5, 7, 9

            b) 2, 4, 8, 16, 32, 64, 128

            c) 0, 1, 4, 9, 16, 25, 36, ____

            d) 4, 16, 36, 64, ____

            e) 1, 1, 2, 3, 5, 8, 13

            f) 2, 10, 12, 16, 17, 18, 19, ____
            */

            // Questão 4
            /* Acenderia os dois interruptores do canto, deixando o do meio apagado e entraria na primeria sala, depois na terceira.
               Se as duas estiverem acessas, os interruptores são delas e o do meio é da sala do meio.
               Se a primeira estiver acesa e a terceira apagada, os interruptores são da primeira e segunda sala, o da terceira é o do meio.
               Se a primeira estiver apagada e da terceira acesa, os interruptores são da primeira e da segunda, o da primeira é o do meio.
            */

            //Questão 5
            Console.WriteLine("Digite uma string:");
            string str = Console.ReadLine();
            string newStr = "";
            char letter;
            for (int i = str.Length-1; i >= 0; i--)
            {
                letter = Convert.ToChar(str[i]);
                newStr += (letter.ToString());
            }
            Console.WriteLine(newStr);
        }
    }
}
