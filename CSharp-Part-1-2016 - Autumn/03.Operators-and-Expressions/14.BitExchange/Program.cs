using System;

namespace _14.BitExchange
{
    class Exchange
    {
        static void Main(string[] args)
        {
            //uint n = uint.Parse(Console.ReadLine());

            //// First mask starting from position 3 and coninue to 4 and 5 (we use 7, because
            //// seven in binary is 111). so we take 000000111(7) << 3 is equal to 000111000
            //// It's the same with the second mask, just start from position 24 and continue to 25 and 26
            //uint mask3 = (n & (7 << 3)) >> 3;
            //uint mask24 = (n & (7 << 24)) >> 24;

            //// store a mask in identity (use method:
            //// a = a ^ b;
            //// b = a ^ b;
            //// a = a ^ b;

            //uint identity = mask3 ^ mask24;

            //n = n ^ identity << 3;
            //n = n ^ identity << 24;

            //Console.WriteLine(n);

            // Second simple way with long code

            uint number = uint.Parse(Console.ReadLine()); // store in mask if it's zero(0) or one(1) on every position
            uint mask3 = (number >> 3) & 1;
            uint mask24 = (number >> 24) & 1;
            uint mask4 = (number >> 4) & 1;
            uint mask25 = (number >> 25) & 1;
            uint mask5 = (number >> 5) & 1;
            uint mask26 = (number >> 26) & 1;

            // if on pos3 the number is not 0, mean it's one(1).
            // number - 0000000(X)00000000000000000000(1)000
            // | or използваме го да наложим маска с единица само на 24 позиция
            // mask   - 0000000(1)00000000000000000000(0)000
            // X or 1 - no matter of x, gives 1 - so now we change pos 24 from 1 to 0
            if (mask3 != 0)
            {
                number = number | (1 << 24);
            }
            // if the number is 0
            // number &(AND) with mask 1111111(0)11111111111111111111111 give same number,
            // just change the  to 1, mean we change position 24 from 0 to 1
            else
            {
                number = number & ~((uint)1 << 24);
            }
            // change position 24 to position 3 at the same alogorithm
            if (mask24 != 0)
            {
                number = number | (1 << 3);
            }
            else
            {
                number = number & ~((uint)1 << 3);
            }
            if (mask4 != 0)
            {
                number = number | (1 << 25);
            }
            else
            {
                number = number & ~((uint)1 << 25);
            }
            if (mask25 != 0)
            {
                number = number | (1 << 4);
            }
            else
            {
                number = number & ~((uint)1 << 4);
            }
            if (mask5 != 0)
            {
                number = number | (1 << 26);
            }
            else
            {
                number = number & ~((uint)1 << 26);
            }
            if (mask26 != 0)
            {
                number = number | (1 << 5);
            }
            else
            {
                number = number & ~((uint)1 << 5);
            }
            Console.WriteLine(number);
        }
    }
}