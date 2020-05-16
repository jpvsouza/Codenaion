using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> fibonacci = new List<int>();
            int ultimo = 0;



            int penultimo = 0;
            for (int i = 0; ultimo + penultimo < 350; i++)
            {
                if (i <= 1)
                {
                    fibonacci.Add(i);
                    ultimo = i;
                }
                else
                {
                    fibonacci.Add(ultimo + penultimo);
                    int tempUltimo = ultimo + penultimo;
                    penultimo = ultimo;
                    ultimo = tempUltimo;
                }
            }
            return fibonacci;
        }

        public bool IsFibonacci(int numberToTest)
        {
            return Fibonacci().Contains(numberToTest);
        }
    }
}
