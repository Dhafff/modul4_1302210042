using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210042
{
    internal class PosisiKarakterGame
    {
        public interface State
        {
            void Terbang();
            void Jongkok();
        }

        public class Position : State
        {
            public void Terbang()
            {
                Console.WriteLine("Posisi landing");
            }
            public void Jongkok()
            {
                Console.WriteLine("Posisi take off");
            }
        }
    }
}
