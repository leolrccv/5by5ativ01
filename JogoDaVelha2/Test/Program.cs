using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    class Program {
        static void Main(string[] args) {
            int pos = 0; ;
            string[,] matriz = new string[3, 3];

            
            int linha = 0;
            if (pos >= 4 && pos < 7) {
                pos -= 3;
                linha = 1;
            }
            else if (pos >= 7 && pos<10) {
                pos -= 6;
                linha = 2;
            }

            matriz[linha, pos - 1] = "X";

            for (int l = linha; l < 3; l++) {
                for (int c = pos-1; c < 3; c++) {

                }
            }

            Console.ReadKey();
        }
    }
}
