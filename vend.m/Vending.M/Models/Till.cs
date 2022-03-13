using System;
using System.Collections.Generic;
using System.Text;

namespace Vending.M
{
    class Till
    {

        private static int[] denotations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        private int[] change = new int[denotations.Length];


        public int Increase(int index)
        {
            ++change[index];
            return 1;
        }
        public int Decrease(int index)
        {
            return (((change[index]--) >= 1) ? 1 : 0);
        }

        public int GetSaldo()
        {
            return GetSaldoFromArray(change);
        }

        private int GetSaldoFromArray(int[] tillArray) 
        {
            int saldo = 0;
            foreach (int denotation in denotations)
            {
                saldo += denotations[denotation] * tillArray[denotation];
            }
            return saldo;
        }
        public int[] withDraw(int sum)
        {
            if (sum > GetSaldo()) return null;
            int[] payOut = new int[denotations.Length];
            for (int index = denotations.Length - 1; index >= 0; index--)
            {
                if (sum >= denotations[index])
                {
                    for (int giveBack = (sum % denotations[index]); giveBack > 0; giveBack--)
                    {
                        sum -= (Decrease(index) > 0) ? denotations[index] : 0;
                    }
                }
            }
            return payOut;
        }
        public int refillChange(int[] newChange)
        {
            if (newChange.Length > denotations.Length) return 0;
            for (int index = 0; index <= denotations.Length; index++)
            {
                change[index] += newChange[index];
            }
            return GetSaldoFromArray(newChange);
        }
    }
}
